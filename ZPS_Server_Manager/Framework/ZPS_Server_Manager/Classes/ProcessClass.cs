using System.Diagnostics;

namespace ZPS_Server_Manager
{
    internal class ProcessClass
    {
        internal static void RunProcess(string path)
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
