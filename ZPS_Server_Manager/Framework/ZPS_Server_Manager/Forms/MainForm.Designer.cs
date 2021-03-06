namespace ZPS_Server_Manager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLogFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCurrentLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GetSteamCMDbutton = new System.Windows.Forms.Button();
            this.SteamDirbutton = new System.Windows.Forms.Button();
            this.OpenPortForwardbutton = new System.Windows.Forms.Button();
            this.Servercfgbutton = new System.Windows.Forms.Button();
            this.Adminsbutton = new System.Windows.Forms.Button();
            this.Groupsbutton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(827, 33);
            this.menuStrip1.TabIndex = 0;
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
            this.logFilesToolStripMenuItem,
            this.checkToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // logFilesToolStripMenuItem
            // 
            this.logFilesToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.logFilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLogFilesToolStripMenuItem,
            this.viewCurrentLogToolStripMenuItem});
            this.logFilesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.logFilesToolStripMenuItem.Name = "logFilesToolStripMenuItem";
            this.logFilesToolStripMenuItem.Size = new System.Drawing.Size(263, 34);
            this.logFilesToolStripMenuItem.Text = "Log Files";
            // 
            // showLogFilesToolStripMenuItem
            // 
            this.showLogFilesToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.showLogFilesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showLogFilesToolStripMenuItem.Name = "showLogFilesToolStripMenuItem";
            this.showLogFilesToolStripMenuItem.Size = new System.Drawing.Size(256, 34);
            this.showLogFilesToolStripMenuItem.Text = "Open Logs Folder";
            this.showLogFilesToolStripMenuItem.Click += new System.EventHandler(this.showLogFilesToolStripMenuItem_Click);
            // 
            // viewCurrentLogToolStripMenuItem
            // 
            this.viewCurrentLogToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.viewCurrentLogToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.viewCurrentLogToolStripMenuItem.Name = "viewCurrentLogToolStripMenuItem";
            this.viewCurrentLogToolStripMenuItem.Size = new System.Drawing.Size(256, 34);
            this.viewCurrentLogToolStripMenuItem.Text = "View Current Log";
            this.viewCurrentLogToolStripMenuItem.Click += new System.EventHandler(this.viewCurrentLogToolStripMenuItem_Click);
            // 
            // checkToolStripMenuItem
            // 
            this.checkToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.checkToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.checkToolStripMenuItem.Name = "checkToolStripMenuItem";
            this.checkToolStripMenuItem.Size = new System.Drawing.Size(263, 34);
            this.checkToolStripMenuItem.Text = "Check For Updates";
            this.checkToolStripMenuItem.Click += new System.EventHandler(this.checkToolStripMenuItem_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.Groupsbutton);
            this.groupBox.Controls.Add(this.SteamDirbutton);
            this.groupBox.Controls.Add(this.Adminsbutton);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.Servercfgbutton);
            this.groupBox.Controls.Add(this.GetSteamCMDbutton);
            this.groupBox.Controls.Add(this.OpenPortForwardbutton);
            this.groupBox.ForeColor = System.Drawing.Color.White;
            this.groupBox.Location = new System.Drawing.Point(12, 36);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(804, 222);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Controls";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "SteamCMD Location";
            // 
            // GetSteamCMDbutton
            // 
            this.GetSteamCMDbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.GetSteamCMDbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetSteamCMDbutton.ForeColor = System.Drawing.Color.White;
            this.GetSteamCMDbutton.Location = new System.Drawing.Point(6, 25);
            this.GetSteamCMDbutton.Name = "GetSteamCMDbutton";
            this.GetSteamCMDbutton.Size = new System.Drawing.Size(153, 40);
            this.GetSteamCMDbutton.TabIndex = 4;
            this.GetSteamCMDbutton.Text = "Get SteamCMD";
            this.GetSteamCMDbutton.UseVisualStyleBackColor = true;
            this.GetSteamCMDbutton.Click += new System.EventHandler(this.GetSteamCMDbutton_Click);
            // 
            // SteamDirbutton
            // 
            this.SteamDirbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.SteamDirbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SteamDirbutton.ForeColor = System.Drawing.Color.White;
            this.SteamDirbutton.Location = new System.Drawing.Point(6, 99);
            this.SteamDirbutton.Name = "SteamDirbutton";
            this.SteamDirbutton.Size = new System.Drawing.Size(370, 40);
            this.SteamDirbutton.TabIndex = 5;
            this.SteamDirbutton.Text = "Click here to select SteamCMD location";
            this.SteamDirbutton.UseVisualStyleBackColor = true;
            this.SteamDirbutton.Click += new System.EventHandler(this.SteamDirbutton_Click);
            // 
            // OpenPortForwardbutton
            // 
            this.OpenPortForwardbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.OpenPortForwardbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenPortForwardbutton.ForeColor = System.Drawing.Color.White;
            this.OpenPortForwardbutton.Location = new System.Drawing.Point(165, 25);
            this.OpenPortForwardbutton.Name = "OpenPortForwardbutton";
            this.OpenPortForwardbutton.Size = new System.Drawing.Size(153, 40);
            this.OpenPortForwardbutton.TabIndex = 6;
            this.OpenPortForwardbutton.Text = "Open Port Forward";
            this.OpenPortForwardbutton.UseVisualStyleBackColor = true;
            this.OpenPortForwardbutton.Click += new System.EventHandler(this.OpenPortForwardbutton_Click);
            // 
            // Servercfgbutton
            // 
            this.Servercfgbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.Servercfgbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Servercfgbutton.ForeColor = System.Drawing.Color.White;
            this.Servercfgbutton.Location = new System.Drawing.Point(324, 25);
            this.Servercfgbutton.Name = "Servercfgbutton";
            this.Servercfgbutton.Size = new System.Drawing.Size(153, 40);
            this.Servercfgbutton.TabIndex = 7;
            this.Servercfgbutton.Text = "Open server.cfg";
            this.Servercfgbutton.UseVisualStyleBackColor = true;
            this.Servercfgbutton.Click += new System.EventHandler(this.Servercfgbutton_Click);
            // 
            // Adminsbutton
            // 
            this.Adminsbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.Adminsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Adminsbutton.ForeColor = System.Drawing.Color.White;
            this.Adminsbutton.Location = new System.Drawing.Point(483, 25);
            this.Adminsbutton.Name = "Adminsbutton";
            this.Adminsbutton.Size = new System.Drawing.Size(153, 40);
            this.Adminsbutton.TabIndex = 8;
            this.Adminsbutton.Text = "Open admins.txt";
            this.Adminsbutton.UseVisualStyleBackColor = true;
            this.Adminsbutton.Click += new System.EventHandler(this.Adminsbutton_Click);
            // 
            // Groupsbutton
            // 
            this.Groupsbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.Groupsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Groupsbutton.ForeColor = System.Drawing.Color.White;
            this.Groupsbutton.Location = new System.Drawing.Point(642, 25);
            this.Groupsbutton.Name = "Groupsbutton";
            this.Groupsbutton.Size = new System.Drawing.Size(153, 40);
            this.Groupsbutton.TabIndex = 9;
            this.Groupsbutton.Text = "Open groups.txt";
            this.Groupsbutton.UseVisualStyleBackColor = true;
            this.Groupsbutton.Click += new System.EventHandler(this.Groupsbutton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(827, 274);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZPS Server Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GetSteamCMDbutton;
        private System.Windows.Forms.Button SteamDirbutton;
        private System.Windows.Forms.Button OpenPortForwardbutton;
        private System.Windows.Forms.Button Servercfgbutton;
        private System.Windows.Forms.Button Adminsbutton;
        private System.Windows.Forms.Button Groupsbutton;
        private System.Windows.Forms.ToolStripMenuItem readMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLogFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCurrentLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

