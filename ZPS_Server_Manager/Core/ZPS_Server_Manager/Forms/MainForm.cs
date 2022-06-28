using System.ComponentModel;
using System.IO.Compression;
using System.Runtime.InteropServices;
using ZPS_Server_Manager.Classes;
using ZPS_Server_Manager.Classes.Cursor;
using ZPS_Server_Manager.Classes.DarkMode;
using ZPS_Server_Manager.Classes.FirewallRules;
using ZPS_Server_Manager.Classes.Logs;

namespace ZPS_Server_Manager
{
    public partial class MainForm : Form
    {
        private readonly string _var;
        public MainForm(string var)
        {
            _var = var;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DarkTitleBarClass.UseImmersiveDarkMode(Handle, true);
            IntPtr handle = CustomCursorClass.LoadCursorFromFile(@"Cursor\Hn.cur");
            Cursor = new Cursor(handle);
            //Load all the saved properties from the config file on app startup
            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.SteamCMDPath))
            {
                GetSteamCMDbutton.Enabled = true;
                SteamDirbutton.Text = Properties.Settings.Default.SteamCMDPath;//Gets SteamCMDPath directory.
            }
            else
            {
                GetSteamCMDbutton.Enabled = false;
            }
        }
        private void Downloadcomplete(object sender, AsyncCompletedEventArgs e)
        {
            LoggerClass.WriteLine(" *** SteamCMD Download Complete [MainForm] ***");
            MessageBox.Show("Download SteamCMD", "Download SteamCMD Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ZipFile.ExtractToDirectory($@"{Properties.Settings.Default.SteamCMDPath}\steamcmd.zip", $@"{Properties.Settings.Default.SteamCMDPath}\steamcmd");
            RunSteamCMDClass.RunExeActions();
        }

        private void Addrules()
        {
            PortFirewallClass.AddTCPRule("ZPS_TCP_Firewall_Rule", "27015");
            PortFirewallClass.AddUDPRule("ZPS_UDP_Firewall_Rule", "27015");
            PortFirewallClass.GetIsRuleActiveAsync("ZPS_TCP_Firewall_Rule");
            PortFirewallClass.GetIsRuleActiveAsync("ZPS_UDP_Firewall_Rule");
            LoggerClass.WriteLine(" *** Addrules ZPS_TCP_Firewall_Rule 27015 [MainForm] ***");
            LoggerClass.WriteLine(" *** Addrules ZPS_UDP_Firewall_Rule 27015 [MainForm] ***");
        }

        private void SteamDirbutton_Click(object sender, EventArgs e)
        {
            LoggerClass.WriteLine(" *** SteamDirbutton_Click [MainForm] ***");
            FolderBrowserDialog f = new()
            {
                Description = "Please select the folder where you would like to install SteamCMD"
            };

            if (f.ShowDialog() == DialogResult.OK)
            {
                string sp = f.SelectedPath;
                SteamDirbutton.Text = sp;
                Properties.Settings.Default.SteamCMDPath = SteamDirbutton.Text;
                Properties.Settings.Default.Save();//Save the directory to the config file
            }
        }

        private void GetSteamCMDbutton_Click(object sender, EventArgs e)
        {
            //check if cmd path is valid
            //check that cmd has not been installed already
            try
            {
                /*                using (WebClient wc = new WebClient())
                                {
                                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(Downloadcomplete);
                                    wc.DownloadFileAsync(new Uri("https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip"), $@"{Properties.Settings.Default.SteamCMDPath}\steamcmd.zip");

                                }*/
                LoggerClass.WriteLine(" *** GetSteamCMDbutton_Click [MainForm] ***");
                ProcessClass.RunProcess($@"{Application.StartupPath}\TextFiles\SteamCMD_Steps.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Download SteamCMD Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoggerClass.WriteLine($" *** Error:{ex.Message} [MainForm] ***");
                return;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoggerClass.WriteLine(" *** aboutToolStripMenuItem_Click [MainForm] ***");
            //Open the about form
            using Form f = new AboutForm();
            f.ShowDialog();
        }

        private void readMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open the readme form
            LoggerClass.WriteLine(" *** readMeToolStripMenuItem_Click [MainForm] ***");
            using Form f = new ReadmeForm();
            f.ShowDialog();
        }

        private void OpenPortForwardbutton_Click(object sender, EventArgs e)
        {
            //Opens link to https://www.yougetsignal.com/tools/open-ports
            //Process.Start("https://www.yougetsignal.com/tools/open-ports");
            Addrules();
            //RunProcess("WF.msc");
            LoggerClass.WriteLine(" *** OpenPortForwardbutton_Click [MainForm] ***");
        }

        private void Groupsbutton_Click(object sender, EventArgs e)
        {
            try
            {
                LoggerClass.WriteLine(" *** Groupsbutton_Click [MainForm] ***");
                ProcessClass.RunProcess($@"{Properties.Settings.Default.SteamCMDPath}\steamcmd\zpsserver\zps\data\adminsystem\groups.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Open groups.txt Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoggerClass.WriteLine($" *** Error:{ex.Message} [MainForm] ***");
                return;
            }
        }

        private void Servercfgbutton_Click(object sender, EventArgs e)
        {
            try
            {
                LoggerClass.WriteLine(" *** Servercfgbutton_Click [MainForm] ***");
                ProcessClass.RunProcess($@"{Properties.Settings.Default.SteamCMDPath}\steamcmd\zpsserver\zps\cfg\server.cfg");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Open server.cfg Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoggerClass.WriteLine($" *** Error:{ex.Message} [MainForm] ***");
                return;
            }
        }

        private void Adminsbutton_Click(object sender, EventArgs e)
        {
            try
            {
                LoggerClass.WriteLine(" *** Adminsbutton_Click [MainForm] ***");
                ProcessClass.RunProcess($@"{Properties.Settings.Default.SteamCMDPath}\steamcmd\zpsserver\zps\data\adminsystem\admins.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Open admins.txt Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoggerClass.WriteLine($" *** Error:{ex.Message} [MainForm] ***");
                return;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.Beep();
        }

        private void openLogsFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessClass.RunProcess($@"{AppDomain.CurrentDomain.BaseDirectory}\Logs\");
        }

        private void viewCurrentLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var f = new ShowLogsForm();
            DarkTitleBarClass.UseImmersiveDarkMode(f.Handle, true);
            f.ShowDialog();
        }
    }
}