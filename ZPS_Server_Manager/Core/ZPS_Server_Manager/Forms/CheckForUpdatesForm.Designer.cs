namespace ZPS_Server_Manager
{
    partial class CheckForUpdatesForm
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
            this.label = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.Closebutton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(12, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(198, 25);
            this.label.TabIndex = 0;
            this.label.Text = "Checking For Updates...";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.progressBar);
            this.groupBox.Location = new System.Drawing.Point(12, 37);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(574, 84);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            // 
            // Closebutton
            // 
            this.Closebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.Closebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closebutton.ForeColor = System.Drawing.Color.White;
            this.Closebutton.Location = new System.Drawing.Point(411, 138);
            this.Closebutton.Name = "Closebutton";
            this.Closebutton.Size = new System.Drawing.Size(175, 42);
            this.Closebutton.TabIndex = 3;
            this.Closebutton.Text = "Close";
            this.Closebutton.UseVisualStyleBackColor = true;
            this.Closebutton.Click += new System.EventHandler(this.Closebutton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(6, 30);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(562, 34);
            this.progressBar.TabIndex = 0;
            // 
            // CheckForUpdatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(598, 192);
            this.Controls.Add(this.Closebutton);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckForUpdatesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Check";
            this.Load += new System.EventHandler(this.CheckForUpdatesForm_Load);
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label;
        private GroupBox groupBox;
        private ProgressBar progressBar;
        private Button Closebutton;
    }
}