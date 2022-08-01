using System;
using System.Collections.Generic;
using System.Drawing;

namespace Dentil.forms.dentist
{
    partial class ProblemInput : language.Translate, theme.ChangeTheme
    {
        List<List<string> > typeProblem = new List<List<string>> ();
        List<int> teeth = new List<int> ();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProblemInput));
            this.p1 = new System.Windows.Forms.Panel();
            this.b1 = new System.Windows.Forms.Button();
            this.p3 = new System.Windows.Forms.Panel();
            this.cb = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.p2 = new System.Windows.Forms.Panel();
            this.b2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pb = new System.Windows.Forms.PictureBox();
            this.p1.SuspendLayout();
            this.p3.SuspendLayout();
            this.p2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.Indigo;
            this.p1.Controls.Add(this.b1);
            this.p1.Controls.Add(this.p3);
            this.p1.Controls.Add(this.p2);
            this.p1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p1.Location = new System.Drawing.Point(0, 0);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(800, 429);
            this.p1.TabIndex = 0;
            // 
            // b1
            // 
            this.b1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b1.BackColor = System.Drawing.Color.SlateBlue;
            this.b1.FlatAppearance.BorderSize = 0;
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(517, 341);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(271, 70);
            this.b1.TabIndex = 2;
            this.b1.Text = "Select";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            this.b1.MouseEnter += new System.EventHandler(this.b1_MouseEnter);
            this.b1.MouseLeave += new System.EventHandler(this.b1_MouseLeave);
            // 
            // p3
            // 
            this.p3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p3.BackColor = System.Drawing.Color.SlateBlue;
            this.p3.Controls.Add(this.cb);
            this.p3.Controls.Add(this.panel4);
            this.p3.Controls.Add(this.label4);
            this.p3.Controls.Add(this.cb1);
            this.p3.Location = new System.Drawing.Point(517, 20);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(271, 140);
            this.p3.TabIndex = 1;
            // 
            // cb
            // 
            this.cb.AutoSize = true;
            this.cb.Location = new System.Drawing.Point(240, 111);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(15, 14);
            this.cb.TabIndex = 8;
            this.cb.UseVisualStyleBackColor = true;
            this.cb.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Indigo;
            this.panel4.Location = new System.Drawing.Point(38, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(120, 3);
            this.panel4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Teeth Number";
            this.label4.MouseEnter += new System.EventHandler(this.label4_MouseEnter);
            this.label4.MouseLeave += new System.EventHandler(this.label4_MouseLeave);
            // 
            // cb1
            // 
            this.cb1.FormattingEnabled = true;
            this.cb1.Location = new System.Drawing.Point(38, 81);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(121, 21);
            this.cb1.TabIndex = 0;
            // 
            // p2
            // 
            this.p2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p2.BackColor = System.Drawing.Color.SlateBlue;
            this.p2.Controls.Add(this.b2);
            this.p2.Controls.Add(this.panel3);
            this.p2.Controls.Add(this.panel1);
            this.p2.Controls.Add(this.label3);
            this.p2.Controls.Add(this.label1);
            this.p2.Controls.Add(this.lb);
            this.p2.Controls.Add(this.panel2);
            this.p2.Controls.Add(this.tb);
            this.p2.Controls.Add(this.label2);
            this.p2.Controls.Add(this.pb);
            this.p2.Location = new System.Drawing.Point(20, 20);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(481, 391);
            this.p2.TabIndex = 0;
            // 
            // b2
            // 
            this.b2.BackgroundImage = global::Dentil.Properties.Resources.plus_sign;
            this.b2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b2.Location = new System.Drawing.Point(434, 15);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(30, 30);
            this.b2.TabIndex = 3;
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Indigo;
            this.panel3.Location = new System.Drawing.Point(239, 225);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(140, 3);
            this.panel3.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Location = new System.Drawing.Point(17, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 3);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Description";
            this.label3.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // lb
            // 
            this.lb.FormattingEnabled = true;
            this.lb.HorizontalScrollbar = true;
            this.lb.Location = new System.Drawing.Point(13, 68);
            this.lb.Name = "lb";
            this.lb.ScrollAlwaysVisible = true;
            this.lb.Size = new System.Drawing.Size(200, 303);
            this.lb.TabIndex = 0;
            this.lb.SelectedIndexChanged += new System.EventHandler(this.lb_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Location = new System.Drawing.Point(285, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 3);
            this.panel2.TabIndex = 5;
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(239, 246);
            this.tb.Multiline = true;
            this.tb.Name = "tb";
            this.tb.ReadOnly = true;
            this.tb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb.Size = new System.Drawing.Size(225, 125);
            this.tb.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Picture";
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(285, 62);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(125, 125);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb.TabIndex = 0;
            this.pb.TabStop = false;
            // 
            // ProblemInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 429);
            this.Controls.Add(this.p1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProblemInput";
            this.Text = "Dentil";
            this.p1.ResumeLayout(false);
            this.p3.ResumeLayout(false);
            this.p3.PerformLayout();
            this.p2.ResumeLayout(false);
            this.p2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);

        }

        public void translate(string curr, string want)
        {
            b1.Text = Program.lang.translate(b1.Text, curr, want);
            label1.Text = Program.lang.translate(label1.Text, curr, want);
            label2.Text = Program.lang.translate(label2.Text, curr, want);
            label3.Text = Program.lang.translate(label3.Text, curr, want);
            label4.Text = Program.lang.translate(label4.Text, curr, want);
        }

        public void changeTheme()
        {
            p1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel4.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            p2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            p3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            lb.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            tb.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            cb.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            cb1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            b1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);

            b1.Font = new Font(Program.theme.Font, 14);
            label1.Font = new Font(Program.theme.Font, 12);
            label2.Font = new Font(Program.theme.Font, 12);
            label3.Font = new Font(Program.theme.Font, 12);
            label4.Font = new Font(Program.theme.Font, 12);
            lb.Font = new Font(Program.theme.Font, 10);
            tb.Font = new Font(Program.theme.Font, 10);
            cb1.Font = new Font(Program.theme.Font, 10);

            b1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label2.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label3.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label4.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            lb.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            tb.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            cb1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
        }

        #endregion

        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Panel p3;
        private System.Windows.Forms.CheckBox cb;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;

        public void fill()
        {
            teeth.Clear();
            typeProblem.Clear();
            lb.Items.Clear();
            cb1.Items.Clear();

            List<List<string>> arr1 = dbManagement.Query.query(dbManagement.Query.allTeeth);
            List<List<string>> arr2 = dbManagement.Query.query(dbManagement.Query.allTypeProblem);

            foreach (List<string> i in arr1)
            {
                cb1.Items.Add(i[0]);

                try {
                    teeth.Add(int.Parse(i[0]));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
                }
            }

            if (arr1.Count > 0)
                cb1.SelectedIndex = 0;

            foreach (List<string> i in arr2)
            {
                lb.Items.Add(i[0]);
                typeProblem.Add(i);
            }
        }
    }
}