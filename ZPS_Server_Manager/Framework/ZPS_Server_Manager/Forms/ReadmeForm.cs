using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZPS_Server_Manager
{
    public partial class ReadmeForm : Form
    {
        public ReadmeForm()
        {
            InitializeComponent();
        }

        private void ReadmeForm_Load(object sender, EventArgs e)
        {
            DarkTitleBarClass.UseImmersiveDarkMode(Handle, true);
            Cursor = new Cursor(CustomCursorClass.LoadCursorFromFile(@"Cursor\Hn.cur"));
            LoggerClass.WriteLine(" *** Readme Form Show Success [ReadmeForm] *** ");
            try
            {
                //Clear Richtextbox and add the content of ReadMe.txt
                richTextBox.Clear();
                using (var sr = new StreamReader(@"TextFiles\Readme.txt"))
                {
                    richTextBox.Text = sr.ReadToEnd();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Read Me Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
