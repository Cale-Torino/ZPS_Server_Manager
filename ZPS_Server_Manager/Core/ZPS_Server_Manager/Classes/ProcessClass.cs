using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPS_Server_Manager.Classes
{
    internal class ProcessClass
    {
        public static void RunProcess(string path)
        {
            using (Process p = new Process())
            {
                p.StartInfo = new ProcessStartInfo()
                {
                    UseShellExecute = true,
                    FileName = path
                };
                p.Start();
            }
        }
    }
}
