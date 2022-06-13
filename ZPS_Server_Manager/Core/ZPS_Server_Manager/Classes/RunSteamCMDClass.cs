using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPS_Server_Manager.Classes
{
    internal class RunSteamCMDClass
    {
        public static void RunExeActions()
        {
            string pathToFile = $@"{Properties.Settings.Default.SteamCMDPath}\steamcmd.exe";
            Process runProg = new();
            try
            {
                runProg.StartInfo.FileName = pathToFile;
                runProg.StartInfo.CreateNoWindow = false;
                runProg.StartInfo.WorkingDirectory = $@"{Properties.Settings.Default.SteamCMDPath}";
                //runProg.StartInfo.Verb = "runas";
                runProg.Start();
                runProg.WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Could Not Run: SteamCMD.exe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
