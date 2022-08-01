using System.Drawing;
using System.Windows.Forms;

namespace Dentil.forms.admin
{
    partial class ScheduleInput : language.Translate, theme.ChangeTheme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleInput));
            this.p1 = new System.Windows.Forms.Panel();
            this.p3 = new System.Windows.Forms.Panel();
            this.b3 = new System.Windows.Forms.Button();
            this.lb3 = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.b2 = new System.Windows.Forms.Button();
            this.p2 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.ListBox();
            this.mc = new System.Windows.Forms.MonthCalendar();
            this.b1 = new System.Windows.Forms.Button();
            this.p1.SuspendLayout();
            this.p3.SuspendLayout();
            this.p2.SuspendLayout();
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.Indigo;
            this.p1.Controls.Add(this.p3);
            this.p1.Controls.Add(this.p2);
            this.p1.Controls.Add(this.b1);
            this.p1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p1.Location = new System.Drawing.Point(0, 0);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(854, 518);
            this.p1.TabIndex = 0;
            // 
            // p3
            // 
            this.p3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p3.BackColor = System.Drawing.Color.SlateBlue;
            this.p3.Controls.Add(this.b3);
            this.p3.Controls.Add(this.lb3);
            this.p3.Controls.Add(this.panel4);
            this.p3.Controls.Add(this.label4);
            this.p3.Controls.Add(this.b2);
            this.p3.Location = new System.Drawing.Point(576, 20);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(250, 351);
            this.p3.TabIndex = 6;
            // 
            // b3
            // 
            this.b3.BackgroundImage = global::Dentil.Properties.Resources.trash;
            this.b3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b3.Location = new System.Drawing.Point(209, 302);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(28, 28);
            this.b3.TabIndex = 10;
            this.b3.Text = "button1";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            this.b3.MouseHover += new System.EventHandler(this.b3_MouseHover);
            // 
            // lb3
            // 
            this.lb3.FormattingEnabled = true;
            this.lb3.HorizontalScrollbar = true;
            this.lb3.Location = new System.Drawing.Point(20, 66);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(174, 264);
            this.lb3.Sorted = true;
            this.lb3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Indigo;
            this.panel4.Location = new System.Drawing.Point(20, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(120, 3);
            this.panel4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Shift";
            this.label4.MouseEnter += new System.EventHandler(this.label4_MouseEnter);
            this.label4.MouseLeave += new System.EventHandler(this.label4_MouseLeave);
            // 
            // b2
            // 
            this.b2.BackgroundImage = global::Dentil.Properties.Resources.plus_sign;
            this.b2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b2.Location = new System.Drawing.Point(209, 264);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(28, 28);
            this.b2.TabIndex = 4;
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            this.b2.MouseHover += new System.EventHandler(this.b2_MouseHover);
            // 
            // p2
            // 
            this.p2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p2.BackColor = System.Drawing.Color.SlateBlue;
            this.p2.Controls.Add(this.panel2);
            this.p2.Controls.Add(this.panel3);
            this.p2.Controls.Add(this.panel1);
            this.p2.Controls.Add(this.label3);
            this.p2.Controls.Add(this.lb2);
            this.p2.Controls.Add(this.label2);
            this.p2.Controls.Add(this.label1);
            this.p2.Controls.Add(this.lb1);
            this.p2.Controls.Add(this.mc);
            this.p2.Location = new System.Drawing.Point(20, 20);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(528, 460);
            this.p2.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Location = new System.Drawing.Point(278, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 3);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Indigo;
            this.panel3.Location = new System.Drawing.Point(278, 295);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(120, 3);
            this.panel3.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Location = new System.Drawing.Point(24, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 3);
            this.panel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(274, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Selected Dates";
            this.label3.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            // 
            // lb2
            // 
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.FormattingEnabled = true;
            this.lb2.ItemHeight = 18;
            this.lb2.Location = new System.Drawing.Point(274, 321);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(227, 94);
            this.lb2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dates";
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Working Staff";
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // lb1
            // 
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.FormattingEnabled = true;
            this.lb1.HorizontalScrollbar = true;
            this.lb1.ItemHeight = 18;
            this.lb1.Items.AddRange(new object[] {
            "jedan",
            "dva",
            "tri",
            "cetiri",
            "pet",
            "sest",
            "sedam",
            "osam"});
            this.lb1.Location = new System.Drawing.Point(20, 65);
            this.lb1.Name = "lb1";
            this.lb1.ScrollAlwaysVisible = true;
            this.lb1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lb1.Size = new System.Drawing.Size(229, 364);
            this.lb1.TabIndex = 3;
            // 
            // mc
            // 
            this.mc.Location = new System.Drawing.Point(274, 65);
            this.mc.Name = "mc";
            this.mc.TabIndex = 2;
            this.mc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mc_MouseDown);
            // 
            // b1
            // 
            this.b1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b1.BackColor = System.Drawing.Color.SlateBlue;
            this.b1.FlatAppearance.BorderSize = 0;
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(576, 397);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(250, 83);
            this.b1.TabIndex = 0;
            this.b1.Text = "Input";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            this.b1.MouseEnter += new System.EventHandler(this.b1_MouseEnter);
            this.b1.MouseLeave += new System.EventHandler(this.b1_MouseLeave);
            // 
            // ScheduleInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 518);
            this.Controls.Add(this.p1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(870, 557);
            this.Name = "ScheduleInput";
            this.Text = "Dentil";
            this.p1.ResumeLayout(false);
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
            b1.Text = Program.lang.translate(b1.Text, curr, want);
            
        }

        public void changeTheme()
        {
            label1.Font = new System.Drawing.Font(Program.theme.Font, 12);
            label2.Font = new System.Drawing.Font(Program.theme.Font, 12);
            label3.Font = new System.Drawing.Font(Program.theme.Font, 12);
            label4.Font = new System.Drawing.Font(Program.theme.Font, 12);
            b1.Font = new System.Drawing.Font(Program.theme.Font, 12);
            lb3.Font = new System.Drawing.Font(Program.theme.Font, 12);
            lb2.Font = new System.Drawing.Font(Program.theme.Font, 12);
            lb1.Font = new System.Drawing.Font(Program.theme.Font, 12);

            label1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label2.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label3.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label4.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            b1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            lb3.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            lb2.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            lb1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);

            p1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            p2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            p3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            b1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            lb1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            lb2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            lb3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            panel1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel4.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
        }

        #endregion

        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.MonthCalendar mc;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.Panel p3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lb2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.ListBox lb3;
    }
}