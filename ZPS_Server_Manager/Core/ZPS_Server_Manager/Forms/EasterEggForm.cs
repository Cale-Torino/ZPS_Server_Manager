using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZPS_Server_Manager.Classes.Bass;
using ZPS_Server_Manager.Classes.Logs;

namespace ZPS_Server_Manager
{
    public partial class EasterEggForm : Form
    {
        private int _handel;
        public EasterEggForm()
        {
            InitializeComponent();
        }

        private void EasterEggForm_Load(object sender, EventArgs e)
        {
            PlaySound();
        }
        private void PlaySound()
        {
            LoggerClass.WriteLine(" *** PlaySound [EasterEggForm] ***");
            try
            {
                BassClass.BASS_Init(-1, 44100, DeviceInitFlagsClass.DeviceInitFlags.Default, IntPtr.Zero);
                _handel = BassClass.BASS_StreamCreateFile(false, @"Music\espcornholio.mp3", 0L, 0L, BassFlagsClass.BassFlags.Loop);
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
            LoggerClass.WriteLine(" *** StopSound [EasterEggForm] ***");
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
        private int count = 0;

        private void pictureBox_Click(object sender, EventArgs e)
        {
            LoggerClass.WriteLine(" *** Close_easter_egg [EasterEggForm] ***");
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Left)
            {
                count++;
                if (count == 2)
                {
                    Close();
                }
            }
        }

        private void EasterEggForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopSound();
        }
    }
}
