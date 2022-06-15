using System.Diagnostics;

namespace ZPS_Server_Manager.Classes
{
    internal class ProcessClass
    {
        public static void RunProcess(string path)
        {
            using Process p = new();
            p.StartInfo = new ProcessStartInfo()
            {
                UseShellExecute = true,
                FileName = path
            };
            p.Start();
        }
    }
}
