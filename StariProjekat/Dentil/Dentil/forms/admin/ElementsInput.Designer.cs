using System;
using System.Drawing;
using System.Windows.Forms;

namespace Dentil.forms.admin
{
    partial class ElementsInput : language.Translate, theme.ChangeTheme
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
        private void InitializeComponent(bool flagForm)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElementsInput));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.b2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 471);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.SlateBlue;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.tb3);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(21, 230);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(283, 225);
            this.panel4.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.Location = new System.Drawing.Point(18, 47);
            this.panel5.BackColor = System.Drawing.Color.Indigo;
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(120, 3);
            this.panel5.TabIndex = 17;
            // 
            // tb3
            // 
            this.tb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb3.Location = new System.Drawing.Point(15, 77);
            this.tb3.Multiline = true;
            this.tb3.Name = "tb3";
            this.tb3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb3.Size = new System.Drawing.Size(250, 136);
            this.tb3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Description";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.SlateBlue;
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.b2);
            this.panel3.Location = new System.Drawing.Point(359, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(263, 220);
            this.panel3.TabIndex = 15;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.textBox4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(17, 23);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(230, 27);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(122, 0);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Picture Path";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(17, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(188, 169);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(50, 36);
            this.b2.TabIndex = 4;
            this.b2.Text = "...";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.SlateBlue;
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Controls.Add(this.cb);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(21, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 182);
            this.panel2.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(252, 100);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cost";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(139, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 2;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(139, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 1;
            // 
            // cb
            // 
            this.cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb.FormattingEnabled = true;
            this.cb.Location = new System.Drawing.Point(144, 147);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(121, 24);
            this.cb.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Type of Element";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(469, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "Input";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ElementsInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(645, 471);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(661, 506);
            this.Name = "ElementsInput";
            this.Text = "Dentil";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

            if (!flagForm)
                button1.Text = "Modify";

            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;

            changeTheme();

            button1.MouseEnter += new EventHandler(this.button1_MouseEnter);
            button1.MouseLeave += new EventHandler(this.button1_MouseLeave);
            b2.MouseEnter += new EventHandler(this.button2_MouseEnter);
            b2.MouseLeave += new EventHandler(this.button2_MouseLeave);
            label3.MouseEnter += new EventHandler(this.label3_MouseEnter);
            label3.MouseLeave += new EventHandler(this.label3_MouseLeave);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            b2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            b2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            panel5.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

        private void fill(elements.Elements element, bool flagForm)
        {
            cb.Items.Clear();
            cb.Items.Add(Program.lang.translate(global::Dentil.elements.TypeELement.item.ToString(), Program.defaultLang, Program.lang.CurrLang));
            cb.Items.Add(Program.lang.translate(global::Dentil.elements.TypeELement.service.ToString(), Program.defaultLang, Program.lang.CurrLang));
            cb.SelectedIndex = 0;

            textBox1.Text = "";
            textBox2.Text = "";
            tb3.Text = "";
            textBox4.Text = "";
            if ( flagForm )
                pictureBox1.Visible = false;

            if (!flagForm)
            {
                textBox1.Text = element.Name;
                textBox2.Text = element.Cost.ToString();
                tb3.Text = element.Description;
                textBox4.Text = element.Path;

                if (global::Dentil.elements.TypeELement.service == element.Type)
                    cb.SelectedIndex = 1;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1) )
                e.Handled = true;
        }

        public void translate(string curr, string want)
        {
            label1.Text = Program.lang.translate(label1.Text, curr, want);
            label2.Text = Program.lang.translate(label2.Text, curr, want);
            label3.Text = Program.lang.translate(label3.Text, curr, want);
            label4.Text = Program.lang.translate(label4.Text, curr, want);
            button1.Text = Program.lang.translate(button1.Text, curr, want);
        }

        public void changeTheme()
        {
            panel1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel5.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);

            panel2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            panel3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            panel4.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            button1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            textBox1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            textBox2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            textBox4.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            tb3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            cb.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            b2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);

            b2.Font = new Font(Program.theme.Font, 12);
            button1.Font = new Font(Program.theme.Font, 14);
            label1.Font = new Font(Program.theme.Font, 11);
            label2.Font = new Font(Program.theme.Font, 11);
            label3.Font = new Font(Program.theme.Font, 11);
            label4.Font = new Font(Program.theme.Font, 11);
            label5.Font = new Font(Program.theme.Font, 10);
            cb.Font = new Font(Program.theme.Font, 10);
            textBox1.Font = new Font(Program.theme.Font, 10);
            textBox2.Font = new Font(Program.theme.Font, 10);
            textBox4.Font = new Font(Program.theme.Font, 10);
            tb3.Font = new Font(Program.theme.Font, 10);

            b2.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            button1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label2.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label3.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label4.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label5.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            cb.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            textBox1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            textBox2.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            textBox4.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            tb3.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);

        }
    }
}