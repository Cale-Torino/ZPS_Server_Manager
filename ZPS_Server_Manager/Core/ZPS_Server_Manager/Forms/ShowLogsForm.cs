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
            ProcessClass.RunProcess(LoggerClass.LogFile);
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowLogsForm_Load(object sender, EventArgs e)
        {
            DarkTitleBarClass.UseImmersiveDarkMode(Handle, true);
            //Clear Richtextbox and add the content of ReadMe.txt

            richTextBox.Clear();
            // Open the text file using a stream reader.
            using (StreamReader sr = new StreamReader(LoggerClass.LogFile))
            {
                richTextBox.Text = sr.ReadToEnd();
            }
            DarkTitleBarClass.UseImmersiveDarkMode(richTextBox.Handle, true);
        }
    }
}
