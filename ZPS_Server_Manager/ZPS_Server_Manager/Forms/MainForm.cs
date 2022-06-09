using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZPS_Server_Manager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open the about form
            using (Form f = new AboutForm())
            {
                f.ShowDialog();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            IntPtr handle = CustomCursorClass.LoadCursorFromFile("Cursor\\Hn.cur");
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
            Checkfirewalrules();
        }

        private void SteamDirbutton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            f.Description = "Please select the folder where you would like to install SteamCMD";

            if (f.ShowDialog() == DialogResult.OK)
            {
                string sp = f.SelectedPath;
                SteamDirbutton.Text = sp;
                Properties.Settings.Default.SteamCMDPath = SteamDirbutton.Text;
                Properties.Settings.Default.Save();//Save the directory to the config file
            }
        }
        private void Downloadcomplete(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download SteamCMD", "Download SteamCMD Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ZipFile.ExtractToDirectory($@"{Properties.Settings.Default.SteamCMDPath}\steamcmd.zip", $@"{Properties.Settings.Default.SteamCMDPath}\steamcmd");
            RunSteamCMDClass.RunExeActions();
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
                ProcessClass.RunProcess($@"{Application.StartupPath}\TextFiles\SteamCMD_Steps.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Download SteamCMD Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoggerClass.WriteLine(" *** Error:" + ex.Message + " [MainForm] ***");
                return;
            }
        }
        private void Checkfirewalrules()
        {
            bool tcp = PortFirewallClass.GetIsRuleActiveAsync("ZPS_TCP_Firewall_Rule");
            bool udp = PortFirewallClass.GetIsRuleActiveAsync("ZPS_UDP_Firewall_Rule");
            LoggerClass.WriteLine($" *** Checkfirewalrules TCP is Active?: {tcp} [MainForm] ***");
            LoggerClass.WriteLine($" *** Checkfirewalrules UDP is Active?: {udp} [MainForm] ***");
        }

        private void Addrules()
        {
            PortFirewallClass.AddTCPRule("ZPS_TCP_Firewall_Rule", "27015");
            PortFirewallClass.AddUDPRule("ZPS_UDP_Firewall_Rule", "27015");
            PortFirewallClass.GetIsRuleActiveAsync("ZPS_TCP_Firewall_Rule");
            PortFirewallClass.GetIsRuleActiveAsync("ZPS_UDP_Firewall_Rule");
        }

        private void OpenPortForwardbutton_Click(object sender, EventArgs e)
        {
            //Opens link to https://www.yougetsignal.com/tools/open-ports
            //Process.Start("https://www.yougetsignal.com/tools/open-ports");
            Addrules();
            //RunProcess("WF.msc");
        }

        private void Servercfgbutton_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessClass.RunProcess($@"{Properties.Settings.Default.SteamCMDPath}\steamcmd\zpsserver\zps\cfg\server.cfg");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Open server.cfg Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoggerClass.WriteLine(" *** Error:" + ex.Message + " [MainForm] ***");
                return;
            }
        }

        private void Adminsbutton_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessClass.RunProcess($@"{Properties.Settings.Default.SteamCMDPath}\steamcmd\zpsserver\zps\data\adminsystem\admins.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Open admins.txt Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoggerClass.WriteLine(" *** Error:" + ex.Message + " [MainForm] ***");
                return;
            }
        }

        private void Groupsbutton_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessClass.RunProcess($@"{Properties.Settings.Default.SteamCMDPath}\steamcmd\zpsserver\zps\data\adminsystem\groups.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Open groups.txt Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoggerClass.WriteLine(" *** Error:" + ex.Message + " [MainForm] ***");
                return;
            }
        }

        private void readMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open the readme form
            using (Form f = new ReadmeForm())
            {
                f.ShowDialog();
            }
        }
    }
}
