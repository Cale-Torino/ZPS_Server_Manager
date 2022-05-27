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
        //private readonly Classes.Mp3Class _mp3player;
        private readonly int _handel;
        public SplashForm()
        {
            InitializeComponent();
            PlaySound();
            //_mp3player = new Classes.Mp3Class(@"Music\theme.mp3");//MPEGVideo
            //if (_mp3player != null)
            //{
                //MessageBox.Show("hello");
                //_mp3player.Play();
            //}
        }
        Timer myTimer = new Timer();
        private void PlaySound()
        {
            try
            {
                BassClass.BASS_Init(-1, 44100, DeviceInitFlagsClass.DeviceInitFlags.Default, IntPtr.Zero);
              int _handel = ManagedBass.Bass.CreateStream("Music\\theme.mp3", 0L, 0L,ManagedBass.BassFlags.Default);
                BassClass.BASS_ChannelPlay(_handel, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        private void StopSound()
        {
            try
            {
                //BASSMODClass.BASSMOD_Free();
                // free the stream 
                BassClass.BASS_StreamFree(_handel);
                // free BASS 
                BassClass.BASS_Free();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }
        private void SplashForm_Load(object sender, EventArgs e)
        {
            label2.Text = "Version: " + Application.ProductVersion;//Get version from AssemblyInfo.cs [assembly: AssemblyFileVersion("1.0.1")]

            myTimer.Elapsed += new ElapsedEventHandler(TimeUp);
            myTimer.Interval = 6000;
            myTimer.Start();//start timer
        }

        public void TimeUp(object source, ElapsedEventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                // close the form on the forms thread
                //if (_mp3player != null)
                //{
                //_mp3player.Dispose();
                //}
                StopSound();
                Close();
                myTimer.Stop();
            });
        }
    }
}
