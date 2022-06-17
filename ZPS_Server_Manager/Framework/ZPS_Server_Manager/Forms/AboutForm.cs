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
        private int _handel;
        public AboutForm()
        {
            InitializeComponent();
            PlaySound();
        }
        private void PlaySound()
        {
            LoggerClass.WriteLine(" *** PlaySound [AboutForm] ***");
            try
            {
                BassClass.BASS_Init(-1, 44100, DeviceInitFlagsClass.DeviceInitFlags.Default, IntPtr.Zero);
                _handel = BassClass.BASS_StreamCreateFile(false, @"Music\menu.mp3", 0L, 0L, BassFlagsClass.BassFlags.Loop);
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
            DarkTitleBarClass.UseImmersiveDarkMode(Handle, true);
            pictureBox.Cursor = new Cursor(CustomCursorClass.LoadCursorFromFile(@"Cursor\Wo.ani"));
            IntPtr handle = CustomCursorClass.LoadCursorFromFile(@"Cursor\Hn.cur");
            Cursor = new Cursor(handle);
            label.Text = $"Version: {Application.ProductVersion}";
        }

        private void AboutForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopSound();
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Opens link to https://github.com/Cale-Torino
            System.Diagnostics.Process.Start("https://github.com/Cale-Torino");
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            IntPtr handle = CustomCursorClass.LoadCursorFromFile(@"Cursor\Hl.cur");
            Cursor = new Cursor(handle);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            IntPtr handle = CustomCursorClass.LoadCursorFromFile(@"Cursor\Hn.cur");
            Cursor = new Cursor(handle);
        }
    }
}
