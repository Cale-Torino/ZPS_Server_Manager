﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZPS_Server_Manager
{
    public class LoggerClass
    {

        //Create logfile log. file
        private static readonly string LogFile = AppDomain.CurrentDomain.BaseDirectory + @"Logs\" + AppDomain.CurrentDomain.FriendlyName + "_" + DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".log";

        public static void WriteLine(string txt)
        {
            try
            {
                //Write to the logfile
                File.AppendAllText(LogFile, "[" + DateTime.Now.ToString() + "] : " + txt + "\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Could Not Append Text To Log File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public static void DeleteLog()
        {
            try
            {
                //Delete the log file
                File.Delete(LogFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Could Not Delete Log File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

    }
}
