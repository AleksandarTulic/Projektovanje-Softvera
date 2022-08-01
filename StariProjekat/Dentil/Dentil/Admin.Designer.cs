using Dentil.language;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Dentil
{
    partial class Admin : language.Translate, theme.ChangeTheme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.sStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ms1 = new System.Windows.Forms.MenuStrip();
            this.v2 = new System.Windows.Forms.ToolStripMenuItem();
            this.v21 = new System.Windows.Forms.ToolStripMenuItem();
            this.v3 = new System.Windows.Forms.ToolStripMenuItem();
            this.v31 = new System.Windows.Forms.ToolStripMenuItem();
            this.v32 = new System.Windows.Forms.ToolStripMenuItem();
            this.v4 = new System.Windows.Forms.ToolStripMenuItem();
            this.v5 = new System.Windows.Forms.ToolStripMenuItem();
            this.v51 = new System.Windows.Forms.ToolStripMenuItem();
            this.v52 = new System.Windows.Forms.ToolStripMenuItem();
            this.v53 = new System.Windows.Forms.ToolStripMenuItem();
            this.p1 = new System.Windows.Forms.Panel();
            this.sStrip1.SuspendLayout();
            this.ms1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sStrip1
            // 
            this.sStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tssl1});
            this.sStrip1.Location = new System.Drawing.Point(0, 507);
            this.sStrip1.Name = "sStrip1";
            this.sStrip1.Size = new System.Drawing.Size(1057, 22);
            this.sStrip1.TabIndex = 1;
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
            // ms1
            // 
            this.ms1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ms1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ms1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.v2,
            this.v3,
            this.v4,
            this.v5});
            this.ms1.Location = new System.Drawing.Point(0, 0);
            this.ms1.Name = "ms1";
            this.ms1.Size = new System.Drawing.Size(1057, 34);
            this.ms1.TabIndex = 0;
            this.ms1.Text = "ms1";
            // 
            // v2
            // 
            this.v2.AutoSize = false;
            this.v2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.v21});
            this.v2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.v2.ForeColor = System.Drawing.Color.White;
            this.v2.Name = "v2";
            this.v2.Size = new System.Drawing.Size(122, 30);
            this.v2.Text = "Employees";
            this.v2.Click += new System.EventHandler(this.v2_Click);
            // 
            // v21
            // 
            this.v21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.v21.Image = global::Dentil.Properties.Resources.plus_sign;
            this.v21.Name = "v21";
            this.v21.Size = new System.Drawing.Size(102, 22);
            this.v21.Text = "Add";
            this.v21.Click += new System.EventHandler(this.v21_Click);
            // 
            // v3
            // 
            this.v3.AutoSize = false;
            this.v3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.v31,
            this.v32});
            this.v3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.v3.ForeColor = System.Drawing.Color.White;
            this.v3.Name = "v3";
            this.v3.Size = new System.Drawing.Size(122, 30);
            this.v3.Text = "Schedule";
            // 
            // v31
            // 
            this.v31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.v31.Image = global::Dentil.Properties.Resources.plus_sign;
            this.v31.Name = "v31";
            this.v31.Size = new System.Drawing.Size(125, 24);
            this.v31.Text = "Add";
            this.v31.Click += new System.EventHandler(this.v31_Click);
            // 
            // v32
            // 
            this.v32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.v32.Image = global::Dentil.Properties.Resources.trash;
            this.v32.Name = "v32";
            this.v32.Size = new System.Drawing.Size(125, 24);
            this.v32.Text = "Delete";
            this.v32.Click += new System.EventHandler(this.v32_Click);
            // 
            // v4
            // 
            this.v4.AutoSize = false;
            this.v4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.v4.ForeColor = System.Drawing.Color.White;
            this.v4.Name = "v4";
            this.v4.Size = new System.Drawing.Size(100, 30);
            this.v4.Text = "Elements";
            this.v4.Click += new System.EventHandler(this.v4_Click);
            // 
            // v5
            // 
            this.v5.AutoSize = false;
            this.v5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.v51,
            this.v52,
            this.v53});
            this.v5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.v5.ForeColor = System.Drawing.Color.White;
            this.v5.Name = "v5";
            this.v5.Size = new System.Drawing.Size(122, 30);
            this.v5.Text = "Profile";
            // 
            // v51
            // 
            this.v51.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.v51.Image = global::Dentil.Properties.Resources.view;
            this.v51.Name = "v51";
            this.v51.Size = new System.Drawing.Size(180, 24);
            this.v51.Text = "View";
            this.v51.Click += new System.EventHandler(this.v51_Click);
            // 
            // v52
            // 
            this.v52.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.v52.Image = global::Dentil.Properties.Resources.settings;
            this.v52.Name = "v52";
            this.v52.Size = new System.Drawing.Size(180, 24);
            this.v52.Text = "Settings";
            this.v52.Click += new System.EventHandler(this.v52_Click);
            // 
            // v53
            // 
            this.v53.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.v53.Image = global::Dentil.Properties.Resources.next;
            this.v53.Name = "v53";
            this.v53.Size = new System.Drawing.Size(180, 24);
            this.v53.Text = "Log Out";
            this.v53.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // p1
            // 
            this.p1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p1.Location = new System.Drawing.Point(0, 34);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(1057, 473);
            this.p1.TabIndex = 2;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1057, 529);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.sStrip1);
            this.Controls.Add(this.ms1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ms1;
            this.MinimumSize = new System.Drawing.Size(600, 200);
            this.Name = "Admin";
            this.Text = "Dentil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            this.Resize += new System.EventHandler(this.Admin_Resize);
            this.sStrip1.ResumeLayout(false);
            this.sStrip1.PerformLayout();
            this.ms1.ResumeLayout(false);
            this.ms1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms1;
        private System.Windows.Forms.ToolStripMenuItem v2;
        private System.Windows.Forms.ToolStripMenuItem v21;
        private System.Windows.Forms.ToolStripMenuItem v3;
        private System.Windows.Forms.ToolStripMenuItem v4;
        private System.Windows.Forms.ToolStripMenuItem v31;
        private System.Windows.Forms.ToolStripMenuItem v32;
        private System.Windows.Forms.ToolStripMenuItem v5;
        private System.Windows.Forms.ToolStripMenuItem v51;
        private System.Windows.Forms.ToolStripMenuItem v53;
        private System.Windows.Forms.StatusStrip sStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssl1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem v52;

        public void translate(string curr, string want)
        {

            v2.Text = Program.lang.translate(v2.Text, curr, want);
            v21.Text = Program.lang.translate(v21.Text, curr, want);

            v3.Text = Program.lang.translate(v3.Text, curr, want);
            v31.Text = Program.lang.translate(v31.Text, curr, want);
            v32.Text = Program.lang.translate(v32.Text, curr, want);

            v4.Text = Program.lang.translate(v4.Text, curr, want);

            v5.Text = Program.lang.translate(v5.Text, curr, want);
            v51.Text = Program.lang.translate(v51.Text, curr, want);
            v52.Text = Program.lang.translate(v52.Text, curr, want);
            v53.Text = Program.lang.translate(v53.Text, curr, want);

            //Program.lang.CurrLang = Program.lang.translate(want, Program.lang.CurrLang, Program.defaultLang);
        }

        public void changeTheme()
        {
            ms1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            this.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            sStrip1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            sStrip1.Font = new Font(Program.theme.Font, 9, FontStyle.Bold);
            sStrip1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);

            v2.Font = new Font(Program.theme.Font, 12);
            v3.Font = new Font(Program.theme.Font, 12);
            v4.Font = new Font(Program.theme.Font, 12);
            v5.Font = new Font(Program.theme.Font, 12);

            v21.Font = new Font(Program.theme.Font, 10);

            v31.Font = new Font(Program.theme.Font, 10);
            v32.Font = new Font(Program.theme.Font, 10);
            
            v51.Font = new Font(Program.theme.Font, 10);
            v52.Font = new Font(Program.theme.Font, 10);
            v53.Font = new Font(Program.theme.Font, 10);

            
        }

        private Panel p1;
    }
}