using System;
using System.Drawing;
using System.Windows.Forms;

namespace ZPS_Server_Manager
{
    public partial class AboutForm : Form
    {
        private int _handel;
        public AboutForm()
        {
            InitializeComponent();          
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
            PlaySound();
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

        private void label1_Click(object sender, EventArgs e)
        {
            //Opens link to https://github.com/Cale-Torino
            System.Diagnostics.Process.Start("https://github.com/Cale-Torino");
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            IntPtr handle = CustomCursorClass.LoadCursorFromFile(@"Cursor\Hl.cur");
            Cursor = new Cursor(handle);
            label1.ForeColor = Color.DodgerBlue;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            IntPtr handle = CustomCursorClass.LoadCursorFromFile(@"Cursor\Hn.cur");
            Cursor = new Cursor(handle);
            label1.ForeColor = Color.RoyalBlue;
        }
        private int count = 0;
        private void label_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Left)
            {
                count++;
                if (count == 5)
                {
                    //Easter egg
                    count = 0;
                    StopSound();
                    LoggerClass.WriteLine(" *** EasterEgg_Activated [AboutForm] ***");
                    //Open the about form
                    using (Form f = new EasterEggForm())
                    {
                        f.ShowDialog();
                    }
                }
            }
        }

        private void label_MouseEnter(object sender, EventArgs e)
        {
            label.ForeColor = Color.DodgerBlue;
            IntPtr handle = CustomCursorClass.LoadCursorFromFile(@"Cursor\Hl.cur");
            Cursor = new Cursor(handle);
        }

        private void label_MouseLeave(object sender, EventArgs e)
        {
            label.ForeColor = Color.White;
            IntPtr handle = CustomCursorClass.LoadCursorFromFile(@"Cursor\Hn.cur");
            Cursor = new Cursor(handle);
        }
    }
}
