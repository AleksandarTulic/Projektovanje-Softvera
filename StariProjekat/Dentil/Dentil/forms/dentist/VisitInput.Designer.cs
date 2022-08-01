using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace Dentil.forms.dentist
{
    partial class VisitInput : language.Translate, theme.ChangeTheme
    {
        public static List<problem.Problem> arr = new List<problem.Problem>();
        public static bill.Bill bill = null;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitInput));
            this.p1 = new System.Windows.Forms.Panel();
            this.b4 = new System.Windows.Forms.Button();
            this.p4 = new System.Windows.Forms.Panel();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.p3 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.b1 = new System.Windows.Forms.Button();
            this.p2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.ListBox();
            this.p1.SuspendLayout();
            this.p4.SuspendLayout();
            this.p3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.p2.SuspendLayout();
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.Indigo;
            this.p1.Controls.Add(this.b4);
            this.p1.Controls.Add(this.p4);
            this.p1.Controls.Add(this.p3);
            this.p1.Controls.Add(this.b1);
            this.p1.Controls.Add(this.p2);
            this.p1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p1.Location = new System.Drawing.Point(0, 0);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(793, 450);
            this.p1.TabIndex = 0;
            // 
            // b4
            // 
            this.b4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b4.BackColor = System.Drawing.Color.SlateBlue;
            this.b4.FlatAppearance.BorderSize = 0;
            this.b4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4.Location = new System.Drawing.Point(642, 304);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(139, 56);
            this.b4.TabIndex = 5;
            this.b4.Text = "Add Bill";
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            this.b4.MouseEnter += new System.EventHandler(this.b4_MouseEnter);
            this.b4.MouseLeave += new System.EventHandler(this.b4_MouseLeave);
            // 
            // p4
            // 
            this.p4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p4.BackColor = System.Drawing.Color.SlateBlue;
            this.p4.Controls.Add(this.tb1);
            this.p4.Controls.Add(this.panel4);
            this.p4.Controls.Add(this.label4);
            this.p4.Location = new System.Drawing.Point(642, 20);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(139, 151);
            this.p4.TabIndex = 4;
            // 
            // tb1
            // 
            this.tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb1.Location = new System.Drawing.Point(7, 70);
            this.tb1.Name = "tb1";
            this.tb1.ReadOnly = true;
            this.tb1.Size = new System.Drawing.Size(120, 23);
            this.tb1.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Indigo;
            this.panel4.Location = new System.Drawing.Point(7, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(120, 3);
            this.panel4.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Teeth";
            this.label4.MouseEnter += new System.EventHandler(this.label4_MouseEnter);
            this.label4.MouseLeave += new System.EventHandler(this.label4_MouseLeave);
            // 
            // p3
            // 
            this.p3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p3.BackColor = System.Drawing.Color.SlateBlue;
            this.p3.Controls.Add(this.panel3);
            this.p3.Controls.Add(this.label3);
            this.p3.Controls.Add(this.panel2);
            this.p3.Controls.Add(this.label2);
            this.p3.Controls.Add(this.tb);
            this.p3.Controls.Add(this.pictureBox1);
            this.p3.Location = new System.Drawing.Point(324, 20);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(297, 418);
            this.p3.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Indigo;
            this.panel3.Location = new System.Drawing.Point(30, 223);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(140, 3);
            this.panel3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            this.label3.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Location = new System.Drawing.Point(30, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 3);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Picture";
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // tb
            // 
            this.tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb.Location = new System.Drawing.Point(30, 242);
            this.tb.Multiline = true;
            this.tb.Name = "tb";
            this.tb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb.Size = new System.Drawing.Size(236, 157);
            this.tb.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(80, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // b1
            // 
            this.b1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b1.BackColor = System.Drawing.Color.SlateBlue;
            this.b1.FlatAppearance.BorderSize = 0;
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(642, 376);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(139, 62);
            this.b1.TabIndex = 2;
            this.b1.Text = "Save";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            this.b1.MouseEnter += new System.EventHandler(this.b1_MouseEnter);
            this.b1.MouseLeave += new System.EventHandler(this.b1_MouseLeave);
            // 
            // p2
            // 
            this.p2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p2.BackColor = System.Drawing.Color.SlateBlue;
            this.p2.Controls.Add(this.panel1);
            this.p2.Controls.Add(this.b3);
            this.p2.Controls.Add(this.b2);
            this.p2.Controls.Add(this.label1);
            this.p2.Controls.Add(this.lb);
            this.p2.Location = new System.Drawing.Point(20, 20);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(286, 418);
            this.p2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Location = new System.Drawing.Point(22, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 3);
            this.panel1.TabIndex = 2;
            // 
            // b3
            // 
            this.b3.BackgroundImage = global::Dentil.Properties.Resources.trash;
            this.b3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b3.Location = new System.Drawing.Point(239, 333);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(30, 30);
            this.b3.TabIndex = 5;
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b2
            // 
            this.b2.BackgroundImage = global::Dentil.Properties.Resources.plus_sign;
            this.b2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b2.Location = new System.Drawing.Point(239, 369);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(30, 30);
            this.b2.TabIndex = 4;
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Problems";
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // lb
            // 
            this.lb.FormattingEnabled = true;
            this.lb.Location = new System.Drawing.Point(22, 70);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(197, 329);
            this.lb.TabIndex = 0;
            this.lb.SelectedIndexChanged += new System.EventHandler(this.lb_SelectedIndexChanged);
            // 
            // VisitInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 450);
            this.Controls.Add(this.p1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VisitInput";
            this.Text = "Dentil";
            this.p1.ResumeLayout(false);
            this.p4.ResumeLayout(false);
            this.p4.PerformLayout();
            this.p3.ResumeLayout(false);
            this.p3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.p2.ResumeLayout(false);
            this.p2.PerformLayout();
            this.ResumeLayout(false);

        }

        public void translate(string curr, string want)
        {
            b1.Text = Program.lang.translate(b1.Text, curr, want);
            b4.Text = Program.lang.translate(b4.Text, curr, want);
            label1.Text = Program.lang.translate(label1.Text, curr, want);
            label2.Text = Program.lang.translate(label2.Text, curr, want);
            label3.Text = Program.lang.translate(label3.Text, curr, want);
        }

        public void changeTheme()
        {
            p1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            p2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            p3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            p4.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            lb.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            tb.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            tb1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            b1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            b4.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            panel1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel4.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);

            label1.Font = new Font(Program.theme.Font, 12);
            label2.Font = new Font(Program.theme.Font, 12);
            label3.Font = new Font(Program.theme.Font, 12);
            tb.Font = new Font(Program.theme.Font, 10);
            lb.Font = new Font(Program.theme.Font, 10);
            b1.Font = new Font(Program.theme.Font, 14);
            tb1.Font = new Font(Program.theme.Font, 10);

            b1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            b4.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            tb.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            lb.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label2.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label3.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label4.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            tb1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
        }

        #endregion

        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Panel p3;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Panel p4;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;

        public void fill()
        {
            lb.Items.Clear();
            tb.Text = "";
            tb1.Text = "";

            foreach (problem.Problem i in arr)
                lb.Items.Add(i.Name);

            pictureBox1.Visible = false;
        }

        public void fillSpecific(int i)
        {
            if ( i >= 0 && i < arr.Count)
            {
                tb.Text = "";
                tb1.Text = "";
                
                if (File.Exists(arr[i].FilePath))
                {
                    pictureBox1.Image = Image.FromFile(arr[i].FilePath);
                    pictureBox1.Visible = true;
                }
                else
                {
                    pictureBox1.Visible = false;
                }

                tb.Text = "0".Equals(arr[i].Description) ? "" : arr[i].Description;
                tb1.Text = arr[i].Teeth < 0 ? "" : $"{arr[i].Teeth}";
            }
        }

        private System.Windows.Forms.Button b4;
    }
}