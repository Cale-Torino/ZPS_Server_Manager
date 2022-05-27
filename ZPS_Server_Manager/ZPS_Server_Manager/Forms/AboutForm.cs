﻿using System;
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
                int _handel = ManagedBass.Bass.CreateStream("Music\\theme.mp3", 0L, 0L, ManagedBass.BassFlags.Default);
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
                // free the stream 
                ManagedBass.Bass.StreamFree(_handel);
                // free BASS 
                ManagedBass.Bass.Free();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }
        private void AboutForm_Load(object sender, EventArgs e)
        {
            label2.Text = "Version: " + Application.ProductVersion;
        }

        private void AboutForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopSound();
/*            if (_mp3player != null)
            {
                _mp3player.Dispose();
            }*/
        }
    }
}
