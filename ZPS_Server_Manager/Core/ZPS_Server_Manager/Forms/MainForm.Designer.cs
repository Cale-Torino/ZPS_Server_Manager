namespace ZPS_Server_Manager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SteamDirbutton = new System.Windows.Forms.Button();
            this.GetSteamCMDbutton = new System.Windows.Forms.Button();
            this.OpenPortForwardbutton = new System.Windows.Forms.Button();
            this.Servercfgbutton = new System.Windows.Forms.Button();
            this.Adminsbutton = new System.Windows.Forms.Button();
            this.Groupsbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLogsFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCurrentLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(78, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // SteamDirbutton
            // 
            this.SteamDirbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.SteamDirbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SteamDirbutton.Location = new System.Drawing.Point(390, 176);
            this.SteamDirbutton.Name = "SteamDirbutton";
            this.SteamDirbutton.Size = new System.Drawing.Size(370, 34);
            this.SteamDirbutton.TabIndex = 1;
            this.SteamDirbutton.Text = "Click here to select SteamCMD location";
            this.SteamDirbutton.UseVisualStyleBackColor = true;
            this.SteamDirbutton.Click += new System.EventHandler(this.SteamDirbutton_Click);
            // 
            // GetSteamCMDbutton
            // 
            this.GetSteamCMDbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.GetSteamCMDbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetSteamCMDbutton.Location = new System.Drawing.Point(78, 261);
            this.GetSteamCMDbutton.Name = "GetSteamCMDbutton";
            this.GetSteamCMDbutton.Size = new System.Drawing.Size(175, 34);
            this.GetSteamCMDbutton.TabIndex = 2;
            this.GetSteamCMDbutton.Text = "Get SteamCMD";
            this.GetSteamCMDbutton.UseVisualStyleBackColor = true;
            this.GetSteamCMDbutton.Click += new System.EventHandler(this.GetSteamCMDbutton_Click);
            // 
            // OpenPortForwardbutton
            // 
            this.OpenPortForwardbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.OpenPortForwardbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenPortForwardbutton.Location = new System.Drawing.Point(78, 301);
            this.OpenPortForwardbutton.Name = "OpenPortForwardbutton";
            this.OpenPortForwardbutton.Size = new System.Drawing.Size(175, 34);
            this.OpenPortForwardbutton.TabIndex = 3;
            this.OpenPortForwardbutton.Text = "Open Port Forward";
            this.OpenPortForwardbutton.UseVisualStyleBackColor = true;
            this.OpenPortForwardbutton.Click += new System.EventHandler(this.OpenPortForwardbutton_Click);
            // 
            // Servercfgbutton
            // 
            this.Servercfgbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.Servercfgbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Servercfgbutton.Location = new System.Drawing.Point(259, 261);
            this.Servercfgbutton.Name = "Servercfgbutton";
            this.Servercfgbutton.Size = new System.Drawing.Size(175, 34);
            this.Servercfgbutton.TabIndex = 4;
            this.Servercfgbutton.Text = "Open server.cfg";
            this.Servercfgbutton.UseVisualStyleBackColor = true;
            this.Servercfgbutton.Click += new System.EventHandler(this.Servercfgbutton_Click);
            // 
            // Adminsbutton
            // 
            this.Adminsbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.Adminsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Adminsbutton.Location = new System.Drawing.Point(78, 341);
            this.Adminsbutton.Name = "Adminsbutton";
            this.Adminsbutton.Size = new System.Drawing.Size(175, 34);
            this.Adminsbutton.TabIndex = 5;
            this.Adminsbutton.Text = "Open admins.txt";
            this.Adminsbutton.UseVisualStyleBackColor = true;
            this.Adminsbutton.Click += new System.EventHandler(this.Adminsbutton_Click);
            // 
            // Groupsbutton
            // 
            this.Groupsbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.Groupsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Groupsbutton.Location = new System.Drawing.Point(259, 301);
            this.Groupsbutton.Name = "Groupsbutton";
            this.Groupsbutton.Size = new System.Drawing.Size(175, 34);
            this.Groupsbutton.TabIndex = 6;
            this.Groupsbutton.Text = "Open groups.txt";
            this.Groupsbutton.UseVisualStyleBackColor = true;
            this.Groupsbutton.Click += new System.EventHandler(this.Groupsbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "SteamCMD Location";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.readMeToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // readMeToolStripMenuItem
            // 
            this.readMeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.readMeToolStripMenuItem.Name = "readMeToolStripMenuItem";
            this.readMeToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.readMeToolStripMenuItem.Text = "ReadMe";
            this.readMeToolStripMenuItem.Click += new System.EventHandler(this.readMeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logFilesToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // logFilesToolStripMenuItem
            // 
            this.logFilesToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.logFilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openLogsFolderToolStripMenuItem,
            this.viewCurrentLogToolStripMenuItem});
            this.logFilesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.logFilesToolStripMenuItem.Name = "logFilesToolStripMenuItem";
            this.logFilesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.logFilesToolStripMenuItem.Text = "Log Files";
            // 
            // openLogsFolderToolStripMenuItem
            // 
            this.openLogsFolderToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.openLogsFolderToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.openLogsFolderToolStripMenuItem.Name = "openLogsFolderToolStripMenuItem";
            this.openLogsFolderToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.openLogsFolderToolStripMenuItem.Text = "Open Logs Folder";
            this.openLogsFolderToolStripMenuItem.Click += new System.EventHandler(this.openLogsFolderToolStripMenuItem_Click);
            // 
            // viewCurrentLogToolStripMenuItem
            // 
            this.viewCurrentLogToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.viewCurrentLogToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.viewCurrentLogToolStripMenuItem.Name = "viewCurrentLogToolStripMenuItem";
            this.viewCurrentLogToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.viewCurrentLogToolStripMenuItem.Text = "View Current Log";
            this.viewCurrentLogToolStripMenuItem.Click += new System.EventHandler(this.viewCurrentLogToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Groupsbutton);
            this.Controls.Add(this.Adminsbutton);
            this.Controls.Add(this.Servercfgbutton);
            this.Controls.Add(this.OpenPortForwardbutton);
            this.Controls.Add(this.GetSteamCMDbutton);
            this.Controls.Add(this.SteamDirbutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Button SteamDirbutton;
        private Button GetSteamCMDbutton;
        private Button OpenPortForwardbutton;
        private Button Servercfgbutton;
        private Button Adminsbutton;
        private Button Groupsbutton;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem readMeToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem logFilesToolStripMenuItem;
        private ToolStripMenuItem openLogsFolderToolStripMenuItem;
        private ToolStripMenuItem viewCurrentLogToolStripMenuItem;
    }
}