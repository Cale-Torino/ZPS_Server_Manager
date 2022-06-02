using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            ZipFile.ExtractToDirectory($@"{Properties.Settings.Default.SteamCMDPath}\steamcmd.zip", $@"{Properties.Settings.Default.SteamCMDPath}\");
            RunSteamCMDClass.RunExeActions();
        }
        private void GetSteamCMDbutton_Click(object sender, EventArgs e)
        {
            //check if cmd path is valid
            //check that cmd has not been installed already
            try
            {
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(Downloadcomplete);
                    wc.DownloadFileAsync(new Uri("https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip"), $@"{Properties.Settings.Default.SteamCMDPath}\steamcmd.zip");
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Download SteamCMD Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoggerClass.WriteLine(" *** Error:" + ex.Message + " [MainForm] ***");
                return;
            }
        }
    }
}
