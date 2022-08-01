using System;
using System.Collections.Generic;
using System.Drawing;

namespace Dentil.forms.other
{
    partial class ViewVisits : language.Translate, theme.ChangeTheme
    {
        List<string> visit = new List<string>();
        List<string> visitId = new List<string>();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewVisits));
            this.p1 = new System.Windows.Forms.Panel();
            this.b1 = new System.Windows.Forms.Button();
            this.p2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.ListBox();
            this.p1.SuspendLayout();
            this.p2.SuspendLayout();
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.Indigo;
            this.p1.Controls.Add(this.b1);
            this.p1.Controls.Add(this.p2);
            this.p1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p1.Location = new System.Drawing.Point(0, 0);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(454, 443);
            this.p1.TabIndex = 0;
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.SlateBlue;
            this.b1.FlatAppearance.BorderSize = 0;
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(278, 371);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(152, 56);
            this.b1.TabIndex = 1;
            this.b1.Text = "Add Bill";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            this.b1.MouseEnter += new System.EventHandler(this.b1_MouseEnter);
            this.b1.MouseLeave += new System.EventHandler(this.b1_MouseLeave);
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.Color.SlateBlue;
            this.p2.Controls.Add(this.panel1);
            this.p2.Controls.Add(this.label1);
            this.p2.Controls.Add(this.lb1);
            this.p2.Location = new System.Drawing.Point(20, 20);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(240, 407);
            this.p2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Location = new System.Drawing.Point(20, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 3);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Visits";
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // lb1
            // 
            this.lb1.FormattingEnabled = true;
            this.lb1.HorizontalScrollbar = true;
            this.lb1.Location = new System.Drawing.Point(20, 62);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(197, 329);
            this.lb1.TabIndex = 1;
            // 
            // ViewVisits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 443);
            this.Controls.Add(this.p1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewVisits";
            this.Text = "Dentil";
            this.p1.ResumeLayout(false);
            this.p2.ResumeLayout(false);
            this.p2.PerformLayout();
            this.ResumeLayout(false);

        }

        public void fill()
        {
            visit.Clear();
            visitId.Clear();
            List<List<string>> arrBuf = dbManagement.Query.query(dbManagement.Query.allVisits);
            List<List<string>> arr = new List<List<string>>();

            try
            {
                foreach (List<string> i in arrBuf)
                    if (id.Equals(i[6]))
                        arr.Add(i);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
            }

            Dictionary<string, int> flagVisit = new Dictionary<string, int>();
            int num = 0;
 
            foreach (List<string> i in arr)
            {
                if (!flagVisit.ContainsKey(i[0]))
                {
                    visit.Add((new elements.helpElements.Date(i[1])).ToString());
                    flagVisit[i[0]] = num++;
                    visitId.Add(i[0]);
                }
            }

            for (int i=0;i<visit.Count;i++)
                lb1.Items.Add($"{Program.lang.translate("ID Visit", Program.defaultLang, Program.lang.CurrLang)}: " + visitId[i] + $", {Program.lang.translate("Date", Program.defaultLang, Program.lang.CurrLang)}: " + visit[i]);
        }

        public void translate(string curr, string want)
        {
            label1.Text = Program.lang.translate(label1.Text, curr, want);
            b1.Text = Program.lang.translate(b1.Text, curr, want);
        }

        public void changeTheme()
        {
            p1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            p2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            b1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            lb1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);

            label1.Font = new Font(Program.theme.Font, 12);
            b1.Font = new Font(Program.theme.Font, 14);
            lb1.Font = new Font(Program.theme.Font, 10);

            lb1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            b1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
        }

        #endregion

        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b1;
    }
}