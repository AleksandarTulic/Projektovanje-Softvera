using System;
using System.Collections.Generic;
using System.Drawing;

namespace Dentil.forms.dentist
{
    partial class ViewVisit : language.Translate, theme.ChangeTheme
    {
        List<List<problem.Problem> > pr = new List<List<problem.Problem>>();
        List<string> visit = new List<string> ();
        List<string> visitId = new List<string> ();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewVisit));
            this.p1 = new System.Windows.Forms.Panel();
            this.b2 = new System.Windows.Forms.Button();
            this.p5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.ListBox();
            this.b1 = new System.Windows.Forms.Button();
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
            this.p2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.ListBox();
            this.p1.SuspendLayout();
            this.p5.SuspendLayout();
            this.p4.SuspendLayout();
            this.p3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.p2.SuspendLayout();
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.Indigo;
            this.p1.Controls.Add(this.b2);
            this.p1.Controls.Add(this.p5);
            this.p1.Controls.Add(this.b1);
            this.p1.Controls.Add(this.p4);
            this.p1.Controls.Add(this.p3);
            this.p1.Controls.Add(this.p2);
            this.p1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p1.Location = new System.Drawing.Point(0, 0);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(988, 450);
            this.p1.TabIndex = 0;
            // 
            // b2
            // 
            this.b2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b2.BackColor = System.Drawing.Color.SlateBlue;
            this.b2.FlatAppearance.BorderSize = 0;
            this.b2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(837, 299);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(139, 62);
            this.b2.TabIndex = 0;
            this.b2.Text = "Last Seen";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            this.b2.MouseEnter += new System.EventHandler(this.b2_MouseEnter);
            this.b2.MouseLeave += new System.EventHandler(this.b2_MouseLeave);
            // 
            // p5
            // 
            this.p5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p5.BackColor = System.Drawing.Color.SlateBlue;
            this.p5.Controls.Add(this.panel6);
            this.p5.Controls.Add(this.label5);
            this.p5.Controls.Add(this.lb1);
            this.p5.Location = new System.Drawing.Point(12, 20);
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(243, 418);
            this.p5.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Indigo;
            this.panel6.Location = new System.Drawing.Point(22, 46);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(120, 3);
            this.panel6.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Visits";
            this.label5.MouseEnter += new System.EventHandler(this.label5_MouseEnter);
            this.label5.MouseLeave += new System.EventHandler(this.label5_MouseLeave);
            // 
            // lb1
            // 
            this.lb1.FormattingEnabled = true;
            this.lb1.Location = new System.Drawing.Point(22, 70);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(197, 329);
            this.lb1.TabIndex = 0;
            this.lb1.SelectedIndexChanged += new System.EventHandler(this.lb1_SelectedIndexChanged);
            // 
            // b1
            // 
            this.b1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b1.BackColor = System.Drawing.Color.SlateBlue;
            this.b1.FlatAppearance.BorderSize = 0;
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(837, 376);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(139, 62);
            this.b1.TabIndex = 6;
            this.b1.Text = "OK";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            this.b1.MouseEnter += new System.EventHandler(this.b1_MouseEnter);
            this.b1.MouseLeave += new System.EventHandler(this.b1_MouseLeave);
            // 
            // p4
            // 
            this.p4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p4.BackColor = System.Drawing.Color.SlateBlue;
            this.p4.Controls.Add(this.tb1);
            this.p4.Controls.Add(this.panel4);
            this.p4.Controls.Add(this.label4);
            this.p4.Location = new System.Drawing.Point(837, 20);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(139, 151);
            this.p4.TabIndex = 5;
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
            this.p3.Location = new System.Drawing.Point(524, 20);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(297, 418);
            this.p3.TabIndex = 4;
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
            this.tb.ReadOnly = true;
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
            // p2
            // 
            this.p2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p2.BackColor = System.Drawing.Color.SlateBlue;
            this.p2.Controls.Add(this.panel1);
            this.p2.Controls.Add(this.label1);
            this.p2.Controls.Add(this.lb2);
            this.p2.Location = new System.Drawing.Point(269, 20);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(243, 418);
            this.p2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Location = new System.Drawing.Point(22, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 3);
            this.panel1.TabIndex = 2;
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
            // lb2
            // 
            this.lb2.FormattingEnabled = true;
            this.lb2.Location = new System.Drawing.Point(22, 70);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(197, 329);
            this.lb2.TabIndex = 0;
            this.lb2.SelectedIndexChanged += new System.EventHandler(this.lb2_SelectedIndexChanged);
            // 
            // ViewVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 450);
            this.Controls.Add(this.p1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewVisit";
            this.Text = "Dentil";
            this.p1.ResumeLayout(false);
            this.p5.ResumeLayout(false);
            this.p5.PerformLayout();
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
            label1.Text = Program.lang.translate(label1.Text, curr, want);
            label2.Text = Program.lang.translate(label2.Text, curr, want);
            label3.Text = Program.lang.translate(label3.Text, curr, want);
            label4.Text = Program.lang.translate(label4.Text, curr, want);
            label5.Text = Program.lang.translate(label5.Text, curr, want);
            b1.Text = Program.lang.translate(b1.Text, curr, want);
            b2.Text = Program.lang.translate(b2.Text, curr, want);
        }

        public void changeTheme()
        {
            b1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            b2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            p1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            p2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            p3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            p4.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            p5.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            lb1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            lb2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            tb.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            tb1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            panel1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel4.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel6.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);

            label1.Font = new Font(Program.theme.Font, 12);
            label2.Font = new Font(Program.theme.Font, 12);
            label3.Font = new Font(Program.theme.Font, 12);
            label4.Font = new Font(Program.theme.Font, 12);
            label5.Font = new Font(Program.theme.Font, 12);
            b1.Font = new Font(Program.theme.Font, 14);
            b2.Font = new Font(Program.theme.Font, 14);
            lb1.Font = new Font(Program.theme.Font, 10);
            lb2.Font = new Font(Program.theme.Font, 10);
            tb.Font = new Font(Program.theme.Font, 10);
            tb1.Font = new Font(Program.theme.Font, 10);

            tb1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            tb.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            lb1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            lb2.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            b1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            b2.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label2.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label3.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label4.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label5.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
        }

        #endregion

        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb2;
        private System.Windows.Forms.Panel p3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel p4;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Panel p5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lb1;

        public void fill(string patientJmb)
        {
            visit.Clear();
            pr.Clear();
            lb1.Items.Clear();
            lb2.Items.Clear();
            tb.Text = "";
            tb1.Text = "";
            pictureBox1.Visible = false;
            
            List<List<string> > arrBuf = dbManagement.Query.query(dbManagement.Query.allVisits);
            List<List<string>> arr = new List<List<string>>();

            try
            {
                foreach (List<string> i in arrBuf)
                    if (patientJmb.Equals(i[6]))
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

            foreach (string i in visit)
                lb1.Items.Add(i);

            for (int i = 0; i < num; i++)
                pr.Add(new List<problem.Problem>());

            try
            {
                for (int i = 0; i < arr.Count; i++)
                {
                    List<string> prInfo = new List<string>();
                    //Console.WriteLine($"{arr[i][2]}, {arr[i][3]}, {arr[i][4]}, {arr[i][5]}");
                    prInfo.Add(arr[i][2]);
                    prInfo.Add(arr[i][3]);
                    prInfo.Add(arr[i][4]);
                    int teeth = int.Parse(arr[i][5]);

                    pr[flagVisit[arr[i][0]]].Add(new problem.Problem(teeth, prInfo));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
            }
        }

        private System.Windows.Forms.Button b2;
    }
}