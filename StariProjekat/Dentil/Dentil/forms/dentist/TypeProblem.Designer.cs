using System.Drawing;

namespace Dentil.forms.dentist
{
    partial class TypeProblem : language.Translate, theme.ChangeTheme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TypeProblem));
            this.p1 = new System.Windows.Forms.Panel();
            this.b1 = new System.Windows.Forms.Button();
            this.p3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.b2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.p2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.p1.SuspendLayout();
            this.p3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.p2.SuspendLayout();
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
            this.p1.Size = new System.Drawing.Size(700, 401);
            this.p1.TabIndex = 0;
            // 
            // b1
            // 
            this.b1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b1.BackColor = System.Drawing.Color.SlateBlue;
            this.b1.FlatAppearance.BorderSize = 0;
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(437, 314);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(239, 67);
            this.b1.TabIndex = 1;
            this.b1.Text = "Input";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            this.b1.MouseEnter += new System.EventHandler(this.b1_MouseEnter);
            this.b1.MouseLeave += new System.EventHandler(this.b1_MouseLeave);
            // 
            // p3
            // 
            this.p3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p3.BackColor = System.Drawing.Color.SlateBlue;
            this.p3.Controls.Add(this.panel4);
            this.p3.Controls.Add(this.b2);
            this.p3.Controls.Add(this.label4);
            this.p3.Controls.Add(this.pictureBox1);
            this.p3.Location = new System.Drawing.Point(437, 22);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(239, 236);
            this.p3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Indigo;
            this.panel4.Location = new System.Drawing.Point(30, 44);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(120, 3);
            this.panel4.TabIndex = 10;
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.SlateBlue;
            this.b2.BackgroundImage = global::Dentil.Properties.Resources.plus_sign;
            this.b2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b2.FlatAppearance.BorderSize = 0;
            this.b2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b2.Location = new System.Drawing.Point(197, 192);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(25, 25);
            this.b2.TabIndex = 3;
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Picture";
            this.label4.MouseEnter += new System.EventHandler(this.label4_MouseEnter);
            this.label4.MouseLeave += new System.EventHandler(this.label4_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(30, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // p2
            // 
            this.p2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p2.BackColor = System.Drawing.Color.SlateBlue;
            this.p2.Controls.Add(this.panel3);
            this.p2.Controls.Add(this.panel2);
            this.p2.Controls.Add(this.panel1);
            this.p2.Controls.Add(this.label1);
            this.p2.Controls.Add(this.label3);
            this.p2.Controls.Add(this.textBox2);
            this.p2.Controls.Add(this.label2);
            this.p2.Controls.Add(this.textBox1);
            this.p2.Location = new System.Drawing.Point(20, 20);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(396, 361);
            this.p2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Indigo;
            this.panel3.Location = new System.Drawing.Point(15, 187);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(160, 3);
            this.panel3.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Location = new System.Drawing.Point(15, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 3);
            this.panel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Location = new System.Drawing.Point(15, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 3);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Type of Problem";
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            this.label3.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(15, 204);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(366, 137);
            this.textBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(15, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(366, 23);
            this.textBox1.TabIndex = 0;
            // 
            // TypeProblem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 401);
            this.Controls.Add(this.p1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TypeProblem";
            this.Text = "Dentil";
            this.p1.ResumeLayout(false);
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
            b1.Text = Program.lang.translate(b1.Text, curr, want);
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
            b1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            b2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            textBox1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            textBox2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);

            b1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label4.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label3.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label2.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            textBox1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            textBox2.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);

            b1.Font = new Font(Program.theme.Font, 14);
            label4.Font = new Font(Program.theme.Font, 12);
            label3.Font = new Font(Program.theme.Font, 11);
            label2.Font = new Font(Program.theme.Font, 11);
            label1.Font = new Font(Program.theme.Font, 12);
            textBox1.Font = new Font(Program.theme.Font, 10);
            textBox2.Font = new Font(Program.theme.Font, 10);
            
        }

        #endregion

        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.Panel p3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}