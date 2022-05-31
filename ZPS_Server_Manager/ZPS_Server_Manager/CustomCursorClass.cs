using System;
using System.Runtime.InteropServices;

namespace ZPS_Server_Manager
{
    public class CustomCursorClass
    {
        [DllImport("user32.dll")]
        public static extern IntPtr LoadCursorFromFile(string fileName);
    }
}
