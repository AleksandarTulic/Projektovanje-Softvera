using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Dentil.forms.dentist
{
    partial class ViewLastSeen : language.Translate, theme.ChangeTheme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewLastSeen));
            this.p1 = new System.Windows.Forms.Panel();
            this.p2 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lv = new System.Windows.Forms.ListView();
            this.ch1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.p1.SuspendLayout();
            this.p2.SuspendLayout();
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.Indigo;
            this.p1.Controls.Add(this.p2);
            this.p1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p1.Location = new System.Drawing.Point(0, 0);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(485, 443);
            this.p1.TabIndex = 0;
            // 
            // p2
            // 
            this.p2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p2.BackColor = System.Drawing.Color.SlateBlue;
            this.p2.Controls.Add(this.panel2);
            this.p2.Controls.Add(this.label1);
            this.p2.Controls.Add(this.lv);
            this.p2.Location = new System.Drawing.Point(20, 20);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(443, 408);
            this.p2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Location = new System.Drawing.Point(20, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 3);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Last Seen";
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // lv
            // 
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch1,
            this.ch2,
            this.ch3,
            this.ch4});
            this.lv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(20, 65);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(404, 326);
            this.lv.TabIndex = 0;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            // 
            // ch1
            // 
            this.ch1.Text = "Name";
            this.ch1.Width = 100;
            // 
            // ch2
            // 
            this.ch2.Text = "Surname";
            this.ch2.Width = 100;
            // 
            // ch3
            // 
            this.ch3.Text = "Date";
            this.ch3.Width = 100;
            // 
            // ch4
            // 
            this.ch4.Text = "Time";
            this.ch4.Width = 100;
            // 
            // ViewLastSeen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 443);
            this.Controls.Add(this.p1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewLastSeen";
            this.Text = "Dentil";
            this.p1.ResumeLayout(false);
            this.p2.ResumeLayout(false);
            this.p2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader ch1;
        private System.Windows.Forms.ColumnHeader ch2;
        private System.Windows.Forms.ColumnHeader ch3;
        private System.Windows.Forms.ColumnHeader ch4;

        public void fill(int visitId)
        {
            List<List<string>> arr = dbManagement.Query.getLastSeen(visitId);

            try
            {
                arr.Sort(delegate (List<string> a, List<string> b) { return a[3].CompareTo(b[3]); });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
            }

            foreach (List<string> i in arr)
            {
                string[] buf = new string[i.Count];
                for (int j = 0; j < i.Count; j++)
                    buf[j] = i[j];

                //no need for try ... catch
                if (i.Count >= 3)
                    buf[2] = (new elements.helpElements.Date(buf[2])).ToString();

                ListViewItem l = new ListViewItem(buf);
                lv.Items.Add(l);
            }
        }

        public void translate(string curr, string want)
        {
            ch1.Text = Program.lang.translate(ch1.Text, curr, want);
            ch2.Text = Program.lang.translate(ch2.Text, curr, want);
            ch3.Text = Program.lang.translate(ch3.Text, curr, want);
            ch4.Text = Program.lang.translate(ch4.Text, curr, want);
            label1.Text = Program.lang.translate(label1.Text, curr, want);
        }

        public void changeTheme()
        {
            p1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            p2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            lv.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            panel2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);

            lv.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);

            lv.Font = new Font(Program.theme.Font, 10);
            label1.Font = new Font(Program.theme.Font, 12);
        }
    }
}