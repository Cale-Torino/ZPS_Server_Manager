using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZPS_Server_Manager.Classes;
using ZPS_Server_Manager.Classes.DarkMode;
using ZPS_Server_Manager.Classes.Logs;

namespace ZPS_Server_Manager
{
    public partial class ShowLogsForm : Form
    {
        public ShowLogsForm()
        {
            InitializeComponent();
        }

        private void OpenFilebutton_Click(object sender, EventArgs e)
        {
            LoggerClass.WriteLine(" *** OpenFilebutton_Click [ShowLogsForm] *** ");
            ProcessClass.RunProcess(LoggerClass.LogFile);
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            LoggerClass.WriteLine(" *** Closebutton_Click [ShowLogsForm] *** ");
            Close();
        }

        private void ShowLogsForm_Load(object sender, EventArgs e)
        {
            LoggerClass.WriteLine(" *** ShowLogsForm_Load [ShowLogsForm] *** ");
            DarkTitleBarClass.UseImmersiveDarkMode(Handle, true);
            //Clear Richtextbox and add the content of ReadMe.txt

            richTextBox.Clear();
            // Open the text file using a stream reader.
            using (StreamReader sr = new(LoggerClass.LogFile))
            {
                richTextBox.Text = sr.ReadToEnd();
            }
            CompositionAttributeClass.EnableBlur(Handle);
            int settheme = DarkTitleBarClass.SetWindowTheme(richTextBox.Handle, "DarkMode_Explorer", null);
            MessageBox.Show(settheme.ToString());
        }
    }
}
