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
        //private readonly Classes.Mp3Class _mp3player;
        private readonly int _handel;
        public AboutForm()
        {
            InitializeComponent();
            PlaySound();
/*            _mp3player = new Classes.Mp3Class(@"Music\menu.mp3");
            if (_mp3player != null)
            {
                _mp3player.Play();
            }*/
        }
        private void PlaySound()
        {
            try
            {
                BassClass.BASS_Init(-1, 44100, DeviceInitFlagsClass.DeviceInitFlags.Default, IntPtr.Zero);
                int _handel = BassClass.BASS_StreamCreateFile(false,"Music\\menu.mp3", 0L, 0L, BassFlagsClass.BassFlags.Loop);
                BassClass.BASS_ChannelPlay(_handel, true);
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
        private void AboutForm_Load(object sender, EventArgs e)
        {
            IntPtr handle = CustomCursorClass.LoadCursorFromFile("Normal.cur");
            Cursor = new Cursor(handle);
            label.Text = "Version: " + Application.ProductVersion;
        }

        private void AboutForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopSound();
/*            if (_mp3player != null)
            {
                _mp3player.Dispose();
            }*/
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Opens link to https://github.com/Cale-Torino
            System.Diagnostics.Process.Start("https://github.com/Cale-Torino");
        }

        private void linkLabel_Enter(object sender, EventArgs e)
        {
            IntPtr handle = CustomCursorClass.LoadCursorFromFile("Hl.cur");
            Cursor = new Cursor(handle);
        }

        private void linkLabel_Leave(object sender, EventArgs e)
        {
            IntPtr handle = CustomCursorClass.LoadCursorFromFile("Hn.cur");
            Cursor = new Cursor(handle);
        }
    }
}
