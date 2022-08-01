using System.Drawing;

namespace Dentil
{
    partial class Other : language.Translate, theme.ChangeTheme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Other));
            this.ms1 = new System.Windows.Forms.MenuStrip();
            this.v1 = new System.Windows.Forms.ToolStripMenuItem();
            this.v2 = new System.Windows.Forms.ToolStripMenuItem();
            this.v4 = new System.Windows.Forms.ToolStripMenuItem();
            this.v41 = new System.Windows.Forms.ToolStripMenuItem();
            this.v42 = new System.Windows.Forms.ToolStripMenuItem();
            this.v43 = new System.Windows.Forms.ToolStripMenuItem();
            this.sStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.p1 = new System.Windows.Forms.Panel();
            this.ms1.SuspendLayout();
            this.sStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms1
            // 
            this.ms1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ms1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ms1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.v1,
            this.v2,
            this.v4});
            this.ms1.Location = new System.Drawing.Point(0, 0);
            this.ms1.Name = "ms1";
            this.ms1.Size = new System.Drawing.Size(800, 34);
            this.ms1.TabIndex = 4;
            this.ms1.Text = "ms1";
            // 
            // v1
            // 
            this.v1.AutoSize = false;
            this.v1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.v1.ForeColor = System.Drawing.Color.White;
            this.v1.Name = "v1";
            this.v1.Size = new System.Drawing.Size(120, 30);
            this.v1.Text = "Patients";
            this.v1.Click += new System.EventHandler(this.v1_Click);
            // 
            // v2
            // 
            this.v2.AutoSize = false;
            this.v2.ForeColor = System.Drawing.Color.White;
            this.v2.Name = "v2";
            this.v2.Size = new System.Drawing.Size(120, 30);
            this.v2.Text = "Appointments";
            this.v2.Click += new System.EventHandler(this.v2_Click);
            // 
            // v4
            // 
            this.v4.AutoSize = false;
            this.v4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.v41,
            this.v42,
            this.v43});
            this.v4.ForeColor = System.Drawing.Color.White;
            this.v4.Name = "v4";
            this.v4.Size = new System.Drawing.Size(120, 30);
            this.v4.Text = "Profile";
            // 
            // v41
            // 
            this.v41.Image = global::Dentil.Properties.Resources.view;
            this.v41.Name = "v41";
            this.v41.Size = new System.Drawing.Size(180, 24);
            this.v41.Text = "View";
            this.v41.Click += new System.EventHandler(this.v41_Click);
            // 
            // v42
            // 
            this.v42.Image = global::Dentil.Properties.Resources.settings;
            this.v42.Name = "v42";
            this.v42.Size = new System.Drawing.Size(180, 24);
            this.v42.Text = "Settings";
            this.v42.Click += new System.EventHandler(this.v42_Click);
            // 
            // v43
            // 
            this.v43.Image = global::Dentil.Properties.Resources.next;
            this.v43.Name = "v43";
            this.v43.Size = new System.Drawing.Size(180, 24);
            this.v43.Text = "Log Out";
            this.v43.Click += new System.EventHandler(this.v43_Click);
            // 
            // sStrip1
            // 
            this.sStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tssl1});
            this.sStrip1.Location = new System.Drawing.Point(0, 428);
            this.sStrip1.Name = "sStrip1";
            this.sStrip1.Size = new System.Drawing.Size(800, 22);
            this.sStrip1.TabIndex = 5;
            this.sStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Image = global::Dentil.Properties.Resources.resize;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(16, 17);
            // 
            // tssl1
            // 
            this.tssl1.Name = "tssl1";
            this.tssl1.Size = new System.Drawing.Size(0, 17);
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.SystemColors.Control;
            this.p1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p1.Location = new System.Drawing.Point(0, 34);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(800, 394);
            this.p1.TabIndex = 6;
            // 
            // Other
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.sStrip1);
            this.Controls.Add(this.ms1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Other";
            this.Text = "Dentil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Other_FormClosing);
            this.Resize += new System.EventHandler(this.Other_Resize);
            this.ms1.ResumeLayout(false);
            this.ms1.PerformLayout();
            this.sStrip1.ResumeLayout(false);
            this.sStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void translate(string curr, string want)
        {
            v1.Text = Program.lang.translate(v1.Text, curr, want);
            v2.Text = Program.lang.translate(v2.Text, curr, want);
            v4.Text = Program.lang.translate(v4.Text, curr, want);
            v41.Text = Program.lang.translate(v41.Text, curr, want);
            v42.Text = Program.lang.translate(v42.Text, curr, want);
            v43.Text = Program.lang.translate(v43.Text, curr, want);
        }

        public void changeTheme()
        {
            p1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            sStrip1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            ms1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            ms1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            sStrip1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);

            ms1.Font = new Font(Program.theme.Font, 12);
            tssl1.Font = new Font(Program.theme.Font, 9);
        }

        #endregion

        private System.Windows.Forms.MenuStrip ms1;
        private System.Windows.Forms.ToolStripMenuItem v1;
        private System.Windows.Forms.ToolStripMenuItem v2;
        private System.Windows.Forms.ToolStripMenuItem v4;
        private System.Windows.Forms.ToolStripMenuItem v41;
        private System.Windows.Forms.ToolStripMenuItem v42;
        private System.Windows.Forms.ToolStripMenuItem v43;
        private System.Windows.Forms.StatusStrip sStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tssl1;
        private System.Windows.Forms.Panel p1;
    }
}