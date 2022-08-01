using System.Collections.Generic;
using System.Drawing;

namespace Dentil.forms.dentist
{
    partial class AppointmentInput : language.Translate, theme.ChangeTheme
    {
        List<string> users = new List<string>();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentInput));
            this.p1 = new System.Windows.Forms.Panel();
            this.p4 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.p3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb2 = new System.Windows.Forms.ComboBox();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.b1 = new System.Windows.Forms.Button();
            this.p2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.TextBox();
            this.mc = new System.Windows.Forms.MonthCalendar();
            this.p1.SuspendLayout();
            this.p4.SuspendLayout();
            this.p3.SuspendLayout();
            this.p2.SuspendLayout();
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.Indigo;
            this.p1.Controls.Add(this.p4);
            this.p1.Controls.Add(this.p3);
            this.p1.Controls.Add(this.b1);
            this.p1.Controls.Add(this.p2);
            this.p1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p1.Location = new System.Drawing.Point(0, 0);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(731, 456);
            this.p1.TabIndex = 0;
            // 
            // p4
            // 
            this.p4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p4.BackColor = System.Drawing.Color.SlateBlue;
            this.p4.Controls.Add(this.textBox1);
            this.p4.Controls.Add(this.panel6);
            this.p4.Controls.Add(this.label6);
            this.p4.Location = new System.Drawing.Point(483, 229);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(227, 114);
            this.p4.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(34, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 23);
            this.textBox1.TabIndex = 14;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.MouseHover += new System.EventHandler(this.textBox1_MouseHover);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Indigo;
            this.panel6.Location = new System.Drawing.Point(34, 38);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(120, 3);
            this.panel6.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "How Long";
            this.label6.MouseEnter += new System.EventHandler(this.label6_MouseEnter);
            this.label6.MouseLeave += new System.EventHandler(this.label6_MouseLeave);
            // 
            // p3
            // 
            this.p3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p3.BackColor = System.Drawing.Color.SlateBlue;
            this.p3.Controls.Add(this.panel5);
            this.p3.Controls.Add(this.panel4);
            this.p3.Controls.Add(this.label5);
            this.p3.Controls.Add(this.label4);
            this.p3.Controls.Add(this.cb2);
            this.p3.Controls.Add(this.cb1);
            this.p3.Location = new System.Drawing.Point(483, 20);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(227, 194);
            this.p3.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Indigo;
            this.panel5.Location = new System.Drawing.Point(34, 130);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(120, 3);
            this.panel5.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Indigo;
            this.panel4.Location = new System.Drawing.Point(34, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(120, 3);
            this.panel4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Minutes";
            this.label5.MouseEnter += new System.EventHandler(this.label5_MouseEnter);
            this.label5.MouseLeave += new System.EventHandler(this.label5_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hours";
            this.label4.MouseEnter += new System.EventHandler(this.label4_MouseEnter);
            this.label4.MouseLeave += new System.EventHandler(this.label4_MouseLeave);
            // 
            // cb2
            // 
            this.cb2.FormattingEnabled = true;
            this.cb2.Location = new System.Drawing.Point(34, 146);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(166, 21);
            this.cb2.TabIndex = 1;
            // 
            // cb1
            // 
            this.cb1.FormattingEnabled = true;
            this.cb1.Location = new System.Drawing.Point(34, 60);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(166, 21);
            this.cb1.TabIndex = 0;
            // 
            // b1
            // 
            this.b1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b1.BackColor = System.Drawing.Color.SlateBlue;
            this.b1.FlatAppearance.BorderSize = 0;
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(483, 362);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(227, 76);
            this.b1.TabIndex = 1;
            this.b1.Text = "Input";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.button1_Click);
            this.b1.MouseEnter += new System.EventHandler(this.b1_MouseEnter);
            this.b1.MouseLeave += new System.EventHandler(this.b1_MouseLeave);
            // 
            // p2
            // 
            this.p2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p2.BackColor = System.Drawing.Color.SlateBlue;
            this.p2.Controls.Add(this.panel7);
            this.p2.Controls.Add(this.label7);
            this.p2.Controls.Add(this.comboBox1);
            this.p2.Controls.Add(this.panel3);
            this.p2.Controls.Add(this.label3);
            this.p2.Controls.Add(this.panel2);
            this.p2.Controls.Add(this.label2);
            this.p2.Controls.Add(this.lb);
            this.p2.Controls.Add(this.panel1);
            this.p2.Controls.Add(this.label1);
            this.p2.Controls.Add(this.tb);
            this.p2.Controls.Add(this.mc);
            this.p2.Location = new System.Drawing.Point(20, 20);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(439, 418);
            this.p2.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Indigo;
            this.panel7.Location = new System.Drawing.Point(267, 170);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(140, 3);
            this.panel7.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(267, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Select Dentist";
            this.label7.MouseEnter += new System.EventHandler(this.label7_MouseEnter);
            this.label7.MouseLeave += new System.EventHandler(this.label7_MouseLeave);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(266, 189);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Indigo;
            this.panel3.Location = new System.Drawing.Point(20, 270);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(120, 3);
            this.panel3.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Note";
            this.label3.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Location = new System.Drawing.Point(267, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 3);
            this.panel2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(267, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Selected Date";
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // lb
            // 
            this.lb.FormattingEnabled = true;
            this.lb.Location = new System.Drawing.Point(267, 60);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(151, 69);
            this.lb.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Location = new System.Drawing.Point(20, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 3);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date";
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(20, 289);
            this.tb.Multiline = true;
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(398, 116);
            this.tb.TabIndex = 2;
            // 
            // mc
            // 
            this.mc.Location = new System.Drawing.Point(20, 60);
            this.mc.Name = "mc";
            this.mc.TabIndex = 0;
            this.mc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mc_MouseDown);
            // 
            // AppointmentInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 456);
            this.Controls.Add(this.p1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppointmentInput";
            this.Text = "Dentil";
            this.p1.ResumeLayout(false);
            this.p4.ResumeLayout(false);
            this.p4.PerformLayout();
            this.p3.ResumeLayout(false);
            this.p3.PerformLayout();
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
            label6.Text = Program.lang.translate(label6.Text, curr, want);
            label7.Text = Program.lang.translate(label7.Text, curr, want);
            b1.Text = Program.lang.translate(b1.Text, curr, want);
        }

        public void changeTheme()
        {
            p1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            p2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            p3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            p4.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            cb1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            cb2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            textBox1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            lb.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            tb.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            panel1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel4.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel5.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel6.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel7.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            b1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);

            label1.Font = new Font(Program.theme.Font, 12);
            label2.Font = new Font(Program.theme.Font, 12);
            label3.Font = new Font(Program.theme.Font, 12);
            label4.Font = new Font(Program.theme.Font, 12);
            label5.Font = new Font(Program.theme.Font, 12);
            label6.Font = new Font(Program.theme.Font, 12);
            label7.Font = new Font(Program.theme.Font, 12);
            tb.Font = new Font(Program.theme.Font, 10);
            lb.Font = new Font(Program.theme.Font, 10);
            b1.Font = new Font(Program.theme.Font, 14);
            cb1.Font = new Font(Program.theme.Font, 10);
            cb2.Font = new Font(Program.theme.Font, 10);
            textBox1.Font = new Font(Program.theme.Font, 10);

            b1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            tb.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            lb.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            cb1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            cb2.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            textBox1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label2.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label3.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label4.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label5.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label6.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label7.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
        }

        #endregion

        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.MonthCalendar mc;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel p3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb2;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.Panel p4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;

        public void fill()
        {
            cb1.Items.Clear();
            cb2.Items.Clear();
        
            for (int i = 0; i < 24; i++)
                cb1.Items.Add(i.ToString());
            
            for(int i = 0; i < 60; i++)
                cb2.Items.Add(i.ToString());

            List<List<string>> arr = dbManagement.Query.query(dbManagement.Query.allDentist);
            users.Clear();

            comboBox1.Items.Clear();
            foreach (List<string> i in arr)
            {
                comboBox1.Items.Add($"{i[1]}, {i[2]}");
                users.Add(i[0]);
            }
        }

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}