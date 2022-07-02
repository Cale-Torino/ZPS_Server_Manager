using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZPS_Server_Manager
{
    public partial class CheckForUpdatesForm : Form
    {
        public CheckForUpdatesForm()
        {
            InitializeComponent();
        }

        private void CheckForUpdatesForm_Load(object sender, EventArgs e)
        {
            CheckApp();
        }

        private void CheckApp()
        {
            try
            {
                UpdateCheckerClass oCheckClient = new UpdateCheckerClass("https://raw.githubusercontent.com/Cale-Torino/ZPS_Server_Manager/main/ZPS_Server_Manager/Framework/ZPS_Server_Manager/UpdateChecker/CurrentVersion.xml");
                int nMajor = oCheckClient.GetVersion(enVerion.EMajor);
                int nMinor = oCheckClient.GetVersion(enVerion.EMinor);
                int nBuild = oCheckClient.GetVersion(enVerion.EBuild);

                string strPath = oCheckClient.GetNewVersionPath();

                // Get my own version's numbers
                Assembly assembly = Assembly.GetExecutingAssembly();
                FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);

                int nAppMajor = fileVersionInfo.FileMajorPart;
                int nAppMinor = fileVersionInfo.FileMinorPart;
                int nAppBuild = fileVersionInfo.FileBuildPart;

                if (nMajor >= nAppMajor)
                {
                    //|| nMinor > nAppMinor
                    DialogResult result = MessageBox.Show($"Found update:\nversion: {nMajor}.{nMinor}.{nBuild}\nWould you like to download the update?" ,"Update Checker", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        //code for Yes
                        UpdateApp(strPath);
                    }
                    else if (result == DialogResult.No)
                    {
                        //code for No
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void UpdateApp(string strPath)
        {
            try
            {
                WebClient wc = new WebClient();
                wc.DownloadFileAsync(new Uri(strPath), @"Updates\ZPS_Server_Manager.zip");
                ZipFile.ExtractToDirectory($@"{AppDomain.CurrentDomain.BaseDirectory}Updates\ZPS_Server_Manager.zip", $@"{AppDomain.CurrentDomain.BaseDirectory}");
                ProcessClass.RunProcess("ZPS_Server_Manager.exe");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
