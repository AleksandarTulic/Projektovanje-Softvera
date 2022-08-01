using System;
using System.Collections.Generic;
using System.Drawing;

namespace Dentil.forms.dentist
{
    partial class BillInput : language.Translate, theme.ChangeTheme
    {
        List<bill.ISBill> arrBill2 = new List<bill.ISBill> ();
        List<bill.ISBill> arrBill1 = new List<bill.ISBill> ();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillInput));
            this.p1 = new System.Windows.Forms.Panel();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.p2 = new System.Windows.Forms.Panel();
            this.b4 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.ListBox();
            this.lb1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.p1.SuspendLayout();
            this.p2.SuspendLayout();
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.Indigo;
            this.p1.Controls.Add(this.b2);
            this.p1.Controls.Add(this.b1);
            this.p1.Controls.Add(this.p2);
            this.p1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p1.Location = new System.Drawing.Point(0, 0);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(838, 500);
            this.p1.TabIndex = 0;
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.SlateBlue;
            this.b2.FlatAppearance.BorderSize = 0;
            this.b2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(630, 357);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(196, 55);
            this.b2.TabIndex = 2;
            this.b2.Text = "More Info";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.SlateBlue;
            this.b1.FlatAppearance.BorderSize = 0;
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(630, 429);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(196, 55);
            this.b1.TabIndex = 1;
            this.b1.Text = "Save";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.Color.SlateBlue;
            this.p2.Controls.Add(this.b4);
            this.p2.Controls.Add(this.b3);
            this.p2.Controls.Add(this.panel2);
            this.p2.Controls.Add(this.label2);
            this.p2.Controls.Add(this.lb2);
            this.p2.Controls.Add(this.lb1);
            this.p2.Controls.Add(this.panel1);
            this.p2.Controls.Add(this.label1);
            this.p2.Location = new System.Drawing.Point(20, 20);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(591, 464);
            this.p2.TabIndex = 0;
            // 
            // b4
            // 
            this.b4.BackgroundImage = global::Dentil.Properties.Resources.next;
            this.b4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b4.Location = new System.Drawing.Point(283, 250);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(30, 30);
            this.b4.TabIndex = 7;
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b3
            // 
            this.b3.BackgroundImage = global::Dentil.Properties.Resources.left;
            this.b3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b3.Location = new System.Drawing.Point(283, 214);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(30, 30);
            this.b3.TabIndex = 6;
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Location = new System.Drawing.Point(334, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 3);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Items and Services";
            // 
            // lb2
            // 
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.FormattingEnabled = true;
            this.lb2.HorizontalScrollbar = true;
            this.lb2.ItemHeight = 16;
            this.lb2.Items.AddRange(new object[] {
            "jedan",
            "dva",
            "tri"});
            this.lb2.Location = new System.Drawing.Point(334, 62);
            this.lb2.Name = "lb2";
            this.lb2.ScrollAlwaysVisible = true;
            this.lb2.Size = new System.Drawing.Size(240, 388);
            this.lb2.TabIndex = 3;
            // 
            // lb1
            // 
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.FormattingEnabled = true;
            this.lb1.HorizontalScrollbar = true;
            this.lb1.ItemHeight = 16;
            this.lb1.Location = new System.Drawing.Point(20, 62);
            this.lb1.Name = "lb1";
            this.lb1.ScrollAlwaysVisible = true;
            this.lb1.Size = new System.Drawing.Size(240, 388);
            this.lb1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Location = new System.Drawing.Point(20, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 3);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bill Items or Services";
            // 
            // BillInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 500);
            this.Controls.Add(this.p1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BillInput";
            this.Text = "Dentil";
            this.p1.ResumeLayout(false);
            this.p2.ResumeLayout(false);
            this.p2.PerformLayout();
            this.ResumeLayout(false);

        }

        public void translate(string curr, string want)
        {
            label1.Text = Program.lang.translate(label1.Text, curr, want);
            label2.Text = Program.lang.translate(label2.Text, curr, want);
            b1.Text = Program.lang.translate(b1.Text, curr, want);
            b2.Text = Program.lang.translate(b2.Text, curr, want);
        }

        public void changeTheme()
        {
            p1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            p2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            b1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            b2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            lb1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            lb2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);

            label1.Font = new Font(Program.theme.Font, 12);
            label2.Font = new Font(Program.theme.Font, 12);
            lb1.Font = new Font(Program.theme.Font, 10);
            lb2.Font = new Font(Program.theme.Font, 10);
            b1.Font = new Font(Program.theme.Font, 14);
            b2.Font = new Font(Program.theme.Font, 14);

            b1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            b2.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            lb2.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            lb1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label2.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
        }

        #endregion

        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lb2;
        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;

        public void fill()
        {
            lb1.Items.Clear();
            lb2.Items.Clear();
            List<List<string>> arr = dbManagement.Query.query(dbManagement.Query.allItemAndServices);

            foreach (List<string> i in arr)
            {
                arrBill2.Add(new bill.ISBill(i));
                lb2.Items.Add(arrBill2[arrBill2.Count-1].Name);
            }
        }
    }
}