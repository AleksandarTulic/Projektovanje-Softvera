using System.Drawing;

namespace Dentil.forms.admin
{
    partial class ShiftInput : language.Translate, theme.ChangeTheme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShiftInput));
            this.p1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.p2_copy = new System.Windows.Forms.Panel();
            this.p4_copy = new System.Windows.Forms.Panel();
            this.p3_copy = new System.Windows.Forms.Panel();
            this.cb2_copy = new System.Windows.Forms.ComboBox();
            this.l1_copy = new System.Windows.Forms.Label();
            this.cb1_copy = new System.Windows.Forms.ComboBox();
            this.l2_copy = new System.Windows.Forms.Label();
            this.p2 = new System.Windows.Forms.Panel();
            this.p4 = new System.Windows.Forms.Panel();
            this.p3 = new System.Windows.Forms.Panel();
            this.cb2 = new System.Windows.Forms.ComboBox();
            this.l2 = new System.Windows.Forms.Label();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.l1 = new System.Windows.Forms.Label();
            this.b1 = new System.Windows.Forms.Button();
            this.p1.SuspendLayout();
            this.p2_copy.SuspendLayout();
            this.p2.SuspendLayout();
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.Indigo;
            this.p1.Controls.Add(this.panel1);
            this.p1.Controls.Add(this.panel2);
            this.p1.Controls.Add(this.label2);
            this.p1.Controls.Add(this.label1);
            this.p1.Controls.Add(this.p2_copy);
            this.p1.Controls.Add(this.p2);
            this.p1.Controls.Add(this.b1);
            this.p1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p1.Location = new System.Drawing.Point(0, 0);
            this.p1.MinimumSize = new System.Drawing.Size(398, 428);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(398, 428);
            this.p1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Location = new System.Drawing.Point(28, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 3);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.SlateBlue;
            this.panel2.Location = new System.Drawing.Point(28, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 3);
            this.panel2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "End";
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Start";
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // p2_copy
            // 
            this.p2_copy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p2_copy.BackColor = System.Drawing.Color.SlateBlue;
            this.p2_copy.Controls.Add(this.p4_copy);
            this.p2_copy.Controls.Add(this.p3_copy);
            this.p2_copy.Controls.Add(this.cb2_copy);
            this.p2_copy.Controls.Add(this.l1_copy);
            this.p2_copy.Controls.Add(this.cb1_copy);
            this.p2_copy.Controls.Add(this.l2_copy);
            this.p2_copy.Location = new System.Drawing.Point(24, 229);
            this.p2_copy.Name = "p2_copy";
            this.p2_copy.Size = new System.Drawing.Size(350, 108);
            this.p2_copy.TabIndex = 5;
            // 
            // p4_copy
            // 
            this.p4_copy.BackColor = System.Drawing.Color.Indigo;
            this.p4_copy.Location = new System.Drawing.Point(199, 36);
            this.p4_copy.Name = "p4_copy";
            this.p4_copy.Size = new System.Drawing.Size(120, 3);
            this.p4_copy.TabIndex = 5;
            // 
            // p3_copy
            // 
            this.p3_copy.BackColor = System.Drawing.Color.Indigo;
            this.p3_copy.Location = new System.Drawing.Point(21, 36);
            this.p3_copy.Name = "p3_copy";
            this.p3_copy.Size = new System.Drawing.Size(120, 3);
            this.p3_copy.TabIndex = 4;
            // 
            // cb2_copy
            // 
            this.cb2_copy.FormattingEnabled = true;
            this.cb2_copy.Location = new System.Drawing.Point(199, 52);
            this.cb2_copy.Name = "cb2_copy";
            this.cb2_copy.Size = new System.Drawing.Size(121, 21);
            this.cb2_copy.TabIndex = 3;
            this.cb2_copy.MouseHover += new System.EventHandler(this.cb2_copy_MouseHover);
            // 
            // l1_copy
            // 
            this.l1_copy.AutoSize = true;
            this.l1_copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1_copy.Location = new System.Drawing.Point(195, 13);
            this.l1_copy.Name = "l1_copy";
            this.l1_copy.Size = new System.Drawing.Size(65, 20);
            this.l1_copy.TabIndex = 3;
            this.l1_copy.Text = "Minutes";
            this.l1_copy.MouseEnter += new System.EventHandler(this.l1_copy_MouseEnter);
            this.l1_copy.MouseLeave += new System.EventHandler(this.l1_copy_MouseLeave);
            // 
            // cb1_copy
            // 
            this.cb1_copy.FormattingEnabled = true;
            this.cb1_copy.Location = new System.Drawing.Point(21, 52);
            this.cb1_copy.Name = "cb1_copy";
            this.cb1_copy.Size = new System.Drawing.Size(121, 21);
            this.cb1_copy.TabIndex = 1;
            this.cb1_copy.MouseHover += new System.EventHandler(this.cb1_copy_MouseHover);
            // 
            // l2_copy
            // 
            this.l2_copy.AutoSize = true;
            this.l2_copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2_copy.Location = new System.Drawing.Point(17, 13);
            this.l2_copy.Name = "l2_copy";
            this.l2_copy.Size = new System.Drawing.Size(52, 20);
            this.l2_copy.TabIndex = 2;
            this.l2_copy.Text = "Hours";
            this.l2_copy.MouseEnter += new System.EventHandler(this.l2_copy_MouseEnter);
            this.l2_copy.MouseLeave += new System.EventHandler(this.l2_copy_MouseLeave);
            // 
            // p2
            // 
            this.p2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p2.BackColor = System.Drawing.Color.SlateBlue;
            this.p2.Controls.Add(this.p4);
            this.p2.Controls.Add(this.p3);
            this.p2.Controls.Add(this.cb2);
            this.p2.Controls.Add(this.l2);
            this.p2.Controls.Add(this.cb1);
            this.p2.Controls.Add(this.l1);
            this.p2.Location = new System.Drawing.Point(24, 63);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(350, 108);
            this.p2.TabIndex = 4;
            // 
            // p4
            // 
            this.p4.BackColor = System.Drawing.Color.Indigo;
            this.p4.Location = new System.Drawing.Point(199, 36);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(120, 3);
            this.p4.TabIndex = 5;
            // 
            // p3
            // 
            this.p3.BackColor = System.Drawing.Color.Indigo;
            this.p3.Location = new System.Drawing.Point(21, 36);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(120, 3);
            this.p3.TabIndex = 4;
            // 
            // cb2
            // 
            this.cb2.FormattingEnabled = true;
            this.cb2.Location = new System.Drawing.Point(199, 52);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(121, 21);
            this.cb2.TabIndex = 3;
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.Location = new System.Drawing.Point(195, 13);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(65, 20);
            this.l2.TabIndex = 3;
            this.l2.Text = "Minutes";
            this.l2.MouseEnter += new System.EventHandler(this.l2_MouseEnter);
            this.l2.MouseLeave += new System.EventHandler(this.l2_MouseLeave);
            // 
            // cb1
            // 
            this.cb1.FormattingEnabled = true;
            this.cb1.Location = new System.Drawing.Point(21, 52);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(121, 21);
            this.cb1.TabIndex = 1;
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.Location = new System.Drawing.Point(17, 13);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(52, 20);
            this.l1.TabIndex = 2;
            this.l1.Text = "Hours";
            this.l1.MouseEnter += new System.EventHandler(this.l1_MouseEnter);
            this.l1.MouseLeave += new System.EventHandler(this.l1_MouseLeave);
            // 
            // b1
            // 
            this.b1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b1.BackColor = System.Drawing.Color.SlateBlue;
            this.b1.FlatAppearance.BorderSize = 0;
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(240, 355);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(134, 57);
            this.b1.TabIndex = 0;
            this.b1.Text = "Input";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            this.b1.MouseEnter += new System.EventHandler(this.b1_MouseEnter);
            this.b1.MouseLeave += new System.EventHandler(this.b1_MouseLeave);
            // 
            // ShiftInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 428);
            this.Controls.Add(this.p1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShiftInput";
            this.Text = "Dentil";
            this.p1.ResumeLayout(false);
            this.p1.PerformLayout();
            this.p2_copy.ResumeLayout(false);
            this.p2_copy.PerformLayout();
            this.p2.ResumeLayout(false);
            this.p2.PerformLayout();
            this.ResumeLayout(false);

        }

        public void translate(string curr, string want)
        {
            b1.Text = Program.lang.translate(b1.Text, curr, want);
            l1.Text = Program.lang.translate(l1.Text, curr, want);
            l2.Text = Program.lang.translate(l2.Text, curr, want);
        }

        public void changeTheme()
        {
            b1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            p2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            p1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            p3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            p4.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            p2_copy.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            p3_copy.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            p4_copy.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            panel2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);

            b1.Font = new Font(Program.theme.Font, 14);
            l1.Font = new Font(Program.theme.Font, 12);
            l2.Font = new Font(Program.theme.Font, 12);
            cb1.Font = new Font(Program.theme.Font, 10);
            cb2.Font = new Font(Program.theme.Font, 10);
            label1.Font = new Font(Program.theme.Font, 10);
            label2.Font = new Font(Program.theme.Font, 10);
            cb1_copy.Font = new Font(Program.theme.Font, 10);
            cb2_copy.Font = new Font(Program.theme.Font, 10);
            l1_copy.Font = new Font(Program.theme.Font, 10);
            l2_copy.Font = new Font(Program.theme.Font, 10);
            
        }

        #endregion

        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.ComboBox cb2;
        private System.Windows.Forms.Panel p4;
        private System.Windows.Forms.Panel p3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel p2_copy;
        private System.Windows.Forms.Panel p4_copy;
        private System.Windows.Forms.Panel p3_copy;
        private System.Windows.Forms.ComboBox cb2_copy;
        private System.Windows.Forms.Label l1_copy;
        private System.Windows.Forms.ComboBox cb1_copy;
        private System.Windows.Forms.Label l2_copy;
    }
}