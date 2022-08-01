using System.Drawing;

namespace Dentil
{
    partial class Dentist : language.Translate, theme.ChangeTheme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dentist));
            this.sStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssl1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ms1 = new System.Windows.Forms.MenuStrip();
            this.v1 = new System.Windows.Forms.ToolStripMenuItem();
            this.v2 = new System.Windows.Forms.ToolStripMenuItem();
            this.v3 = new System.Windows.Forms.ToolStripMenuItem();
            this.v32 = new System.Windows.Forms.ToolStripMenuItem();
            this.p1 = new System.Windows.Forms.Panel();
            this.v31 = new System.Windows.Forms.ToolStripMenuItem();
            this.v33 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sStrip1.SuspendLayout();
            this.ms1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sStrip1
            // 
            this.sStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tssl1});
            this.sStrip1.Location = new System.Drawing.Point(0, 525);
            this.sStrip1.Name = "sStrip1";
            this.sStrip1.Size = new System.Drawing.Size(926, 22);
            this.sStrip1.TabIndex = 2;
            this.sStrip1.Text = "statusStrip1";
            // 
            // tssl1
            // 
            this.tssl1.Name = "tssl1";
            this.tssl1.Size = new System.Drawing.Size(0, 17);
            // 
            // ms1
            // 
            this.ms1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ms1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ms1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.v1,
            this.v2,
            this.v3});
            this.ms1.Location = new System.Drawing.Point(0, 0);
            this.ms1.Name = "ms1";
            this.ms1.Size = new System.Drawing.Size(926, 34);
            this.ms1.TabIndex = 3;
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
            // v3
            // 
            this.v3.AutoSize = false;
            this.v3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.v31,
            this.v32,
            this.v33});
            this.v3.ForeColor = System.Drawing.Color.White;
            this.v3.Name = "v3";
            this.v3.Size = new System.Drawing.Size(120, 30);
            this.v3.Text = "Profile";
            // 
            // v32
            // 
            this.v32.Image = global::Dentil.Properties.Resources.settings;
            this.v32.Name = "v32";
            this.v32.Size = new System.Drawing.Size(180, 24);
            this.v32.Text = "Settings";
            this.v32.Click += new System.EventHandler(this.v32_Click);
            // 
            // p1
            // 
            this.p1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p1.Location = new System.Drawing.Point(0, 34);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(926, 491);
            this.p1.TabIndex = 4;
            // 
            // v31
            // 
            this.v31.Image = global::Dentil.Properties.Resources.view;
            this.v31.Name = "v31";
            this.v31.Size = new System.Drawing.Size(180, 24);
            this.v31.Text = "View";
            this.v31.Click += new System.EventHandler(this.v31_Click);
            // 
            // v33
            // 
            this.v33.Image = global::Dentil.Properties.Resources.next;
            this.v33.Name = "v33";
            this.v33.Size = new System.Drawing.Size(180, 24);
            this.v33.Text = "Log Out";
            this.v33.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Image = global::Dentil.Properties.Resources.resize;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(16, 16);
            // 
            // Dentist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 547);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.ms1);
            this.Controls.Add(this.sStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dentist";
            this.Text = "Dentist";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dentist_FormClosing);
            this.Resize += new System.EventHandler(this.Dentist_Resize);
            this.sStrip1.ResumeLayout(false);
            this.sStrip1.PerformLayout();
            this.ms1.ResumeLayout(false);
            this.ms1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void translate(string curr, string want)
        {
            v1.Text = Program.lang.translate(v1.Text, curr, want);
            v2.Text = Program.lang.translate(v2.Text, curr, want);
            v3.Text = Program.lang.translate(v3.Text, curr, want);
            v31.Text = Program.lang.translate(v31.Text, curr, want);
            v32.Text = Program.lang.translate(v32.Text, curr, want);
            v33.Text = Program.lang.translate(v33.Text, curr, want);
        }

        public void changeTheme()
        {
            p1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            ms1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            sStrip1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            ms1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            sStrip1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
        }

        #endregion

        private System.Windows.Forms.StatusStrip sStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tssl1;
        private System.Windows.Forms.MenuStrip ms1;
        private System.Windows.Forms.ToolStripMenuItem v1;
        private System.Windows.Forms.ToolStripMenuItem v2;
        private System.Windows.Forms.ToolStripMenuItem v3;
        private System.Windows.Forms.ToolStripMenuItem v31;
        private System.Windows.Forms.ToolStripMenuItem v32;
        private System.Windows.Forms.ToolStripMenuItem v33;
        private System.Windows.Forms.Panel p1;
    }
}