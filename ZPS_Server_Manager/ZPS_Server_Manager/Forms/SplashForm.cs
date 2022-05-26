using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace ZPS_Server_Manager
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        Timer myTimer = new Timer();

        [DllImport("winmm.dll")]
        public static extern uint mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, IntPtr hWndCallback);
        private void SplashForm_Load(object sender, EventArgs e)
        {
            PlayOnce();
            label2.Text = "Version: " + Application.ProductVersion;//Get version from AssemblyInfo.cs [assembly: AssemblyFileVersion("1.0.1")]

            myTimer.Elapsed += new ElapsedEventHandler(TimeUp);
            myTimer.Interval = 6000;
            myTimer.Start();//start timer
        }
        private void PlayOnce()
        {
            //zp_themesong.mp3
            //theme.wav
            mciSendString(@"close temp_alias", null, 0, IntPtr.Zero);
            mciSendString(@"open ""Music\theme.wav"" alias temp_alias", null, 0, IntPtr.Zero);
            mciSendString("play temp_alias", null, 0, IntPtr.Zero);
        }
        public void TimeUp(object source, ElapsedEventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                // close the form on the forms thread
                Close();
                myTimer.Stop();
            });
        }
    }
}
