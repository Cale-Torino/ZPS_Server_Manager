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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GetSteamCMDbutton = new System.Windows.Forms.Button();
            this.SteamDirbutton = new System.Windows.Forms.Button();
            this.OpenPortForwardbutton = new System.Windows.Forms.Button();
            this.Servercfgbutton = new System.Windows.Forms.Button();
            this.Adminsbutton = new System.Windows.Forms.Button();
            this.Groupsbutton = new System.Windows.Forms.Button();
            this.readMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.readMeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
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
            // groupBox1
            // 
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(305, 169);
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
            this.GetSteamCMDbutton.Location = new System.Drawing.Point(12, 209);
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
            this.SteamDirbutton.Location = new System.Drawing.Point(309, 192);
            this.SteamDirbutton.Name = "SteamDirbutton";
            this.SteamDirbutton.Size = new System.Drawing.Size(370, 29);
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
            this.OpenPortForwardbutton.Location = new System.Drawing.Point(12, 255);
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
            this.Servercfgbutton.Location = new System.Drawing.Point(171, 255);
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
            this.Adminsbutton.Location = new System.Drawing.Point(12, 301);
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
            this.Groupsbutton.Location = new System.Drawing.Point(171, 301);
            this.Groupsbutton.Name = "Groupsbutton";
            this.Groupsbutton.Size = new System.Drawing.Size(153, 40);
            this.Groupsbutton.TabIndex = 9;
            this.Groupsbutton.Text = "Open groups.txt";
            this.Groupsbutton.UseVisualStyleBackColor = true;
            this.Groupsbutton.Click += new System.EventHandler(this.Groupsbutton_Click);
            // 
            // readMeToolStripMenuItem
            // 
            this.readMeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.readMeToolStripMenuItem.Name = "readMeToolStripMenuItem";
            this.readMeToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.readMeToolStripMenuItem.Text = "ReadMe";
            this.readMeToolStripMenuItem.Click += new System.EventHandler(this.readMeToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Groupsbutton);
            this.Controls.Add(this.Adminsbutton);
            this.Controls.Add(this.Servercfgbutton);
            this.Controls.Add(this.OpenPortForwardbutton);
            this.Controls.Add(this.SteamDirbutton);
            this.Controls.Add(this.GetSteamCMDbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZPS Server Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GetSteamCMDbutton;
        private System.Windows.Forms.Button SteamDirbutton;
        private System.Windows.Forms.Button OpenPortForwardbutton;
        private System.Windows.Forms.Button Servercfgbutton;
        private System.Windows.Forms.Button Adminsbutton;
        private System.Windows.Forms.Button Groupsbutton;
        private System.Windows.Forms.ToolStripMenuItem readMeToolStripMenuItem;
    }
}

