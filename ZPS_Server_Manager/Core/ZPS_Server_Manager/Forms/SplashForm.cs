using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using ZPS_Server_Manager.Classes;
using ZPS_Server_Manager.Classes.Bass;
using ZPS_Server_Manager.Classes.Cursor;
using ZPS_Server_Manager.Classes.FirewallRules;
using ZPS_Server_Manager.Classes.Logs;
using Timer = System.Timers.Timer;

namespace ZPS_Server_Manager
{
    public partial class SplashForm : Form
    {
        private int _handel;
        public SplashForm()
        {
            InitializeComponent();
        }
        Timer myTimer = new();
        private void PlaySound()
        {
            LoggerClass.WriteLine(" *** PlaySound [SplashForm] ***");
            try
            {
                BassClass.BASS_Init(-1, 44100, DeviceInitFlagsClass.DeviceInitFlags.Default, IntPtr.Zero);
                _handel = BassClass.BASS_StreamCreateFile(false, @"Music\theme.mp3", 0L, 0L, BassFlagsClass.BassFlags.Default);
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
            Console.Beep();
            CreateFolder();
            PlaySound();
            Checkfirewalrules();
            LoggerClass.WriteLine(GetSpecsClass.GetSpecs());
            pictureBox.Cursor = new Cursor(CustomCursorClass.LoadCursorFromFile(@"Cursor\Wo.ani"));
            label2.Text = $"Version: {Application.ProductVersion}";//Get version from AssemblyInfo.cs [assembly: AssemblyFileVersion("1.0.1")]

            myTimer.Elapsed += new ElapsedEventHandler(TimeUp);
            myTimer.Interval = 6000;
            myTimer.Start();//start timer
        }
        private static void Checkfirewalrules()
        {
            bool tcp = PortFirewallClass.GetIsRuleActiveAsync("ZPS_TCP_Firewall_Rule");
            bool udp = PortFirewallClass.GetIsRuleActiveAsync("ZPS_UDP_Firewall_Rule");
            LoggerClass.WriteLine(" *** Checkfirewalrules TCP is Active?: {tcp} [MainForm] ***");
            LoggerClass.WriteLine(" *** Checkfirewalrules UDP is Active?: {udp} [MainForm] ***");
        }
        private static void CreateFolder()
        {
            try
            {
                //Create the folders used by the app
                string path = Application.StartupPath;
                Directory.CreateDirectory(path + @"\Logs");
                LoggerClass.WriteLine(" *** Application Start [SplashForm] ***");
                LoggerClass.WriteLine(" *** CreateDirectory Success [SplashForm] ***");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Create Folder Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoggerClass.WriteLine($" *** Error:{ex.Message} [SplashForm] ***");
                return;
            }
        }
        public void TimeUp(object? sender, ElapsedEventArgs e)
        {
            LoggerClass.WriteLine(" *** TimeUp [SplashForm] ***");
            StopSound();
            myTimer.Stop();
            Invoke((MethodInvoker)delegate
            {
                Hide();
                using Form f = new MainForm("test");
                f.ShowDialog();
                f.Activate();
                Close();
            });
        }
    }
}
