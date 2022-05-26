using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZPS_Server_Manager
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }
        [DllImport("winmm.dll")]
        public static extern uint mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, IntPtr hWndCallback);
        private void AboutForm_Load(object sender, EventArgs e)
        {
            PlayRepeat();
            label2.Text = "Version: " + Application.ProductVersion;
        }
        private void PlayRepeat()
        {
            //https://youtu.be/P_EROD1FKUA
            mciSendString(@"close temp_alias2", null, 0, IntPtr.Zero);
            mciSendString(@"open ""Music\zps.mp3"" alias temp_alias2", null, 0, IntPtr.Zero);
            mciSendString("play temp_alias2 repeat", null, 0, IntPtr.Zero);
        }

        private void AboutForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mciSendString(@"close temp_alias2", null, 0, IntPtr.Zero);
        }
    }
}
