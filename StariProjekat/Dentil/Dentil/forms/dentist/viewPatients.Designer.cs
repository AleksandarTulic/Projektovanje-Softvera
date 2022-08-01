using System.Collections.Generic;
using System.Drawing;

namespace Dentil.forms.dentist
{
    partial class viewPatients : language.Translate, theme.ChangeTheme
    {
        List<user.Patient> users = new List<user.Patient>();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewPatients));
            this.p1 = new System.Windows.Forms.Panel();
            this.p3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tlp1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tb9 = new System.Windows.Forms.TextBox();
            this.tb8 = new System.Windows.Forms.TextBox();
            this.l8 = new System.Windows.Forms.Label();
            this.tb7 = new System.Windows.Forms.TextBox();
            this.tb6 = new System.Windows.Forms.TextBox();
            this.l1 = new System.Windows.Forms.Label();
            this.tb5 = new System.Windows.Forms.TextBox();
            this.l9 = new System.Windows.Forms.Label();
            this.l7 = new System.Windows.Forms.Label();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.l2 = new System.Windows.Forms.Label();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.l6 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.l5 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.p2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.b1 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.ListBox();
            this.p1.SuspendLayout();
            this.p3.SuspendLayout();
            this.tlp1.SuspendLayout();
            this.p2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.Indigo;
            this.p1.Controls.Add(this.p3);
            this.p1.Controls.Add(this.p2);
            this.p1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p1.Location = new System.Drawing.Point(0, 0);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(1028, 473);
            this.p1.TabIndex = 0;
            // 
            // p3
            // 
            this.p3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p3.BackColor = System.Drawing.Color.SlateBlue;
            this.p3.Controls.Add(this.panel6);
            this.p3.Controls.Add(this.label6);
            this.p3.Controls.Add(this.tlp1);
            this.p3.Location = new System.Drawing.Point(576, 22);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(431, 434);
            this.p3.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Indigo;
            this.panel6.Location = new System.Drawing.Point(27, 41);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(120, 3);
            this.panel6.TabIndex = 11;
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.Color.Indigo;
            this.b4.FlatAppearance.BorderSize = 0;
            this.b4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4.Location = new System.Drawing.Point(281, 217);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(236, 46);
            this.b4.TabIndex = 13;
            this.b4.Text = "View Visits";
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            this.b4.MouseEnter += new System.EventHandler(this.b4_MouseEnter);
            this.b4.MouseLeave += new System.EventHandler(this.b4_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Info";
            this.label6.MouseEnter += new System.EventHandler(this.label6_MouseEnter);
            this.label6.MouseLeave += new System.EventHandler(this.label6_MouseLeave);
            // 
            // tlp1
            // 
            this.tlp1.ColumnCount = 2;
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp1.Controls.Add(this.comboBox1, 1, 3);
            this.tlp1.Controls.Add(this.tb9, 1, 8);
            this.tlp1.Controls.Add(this.tb8, 1, 7);
            this.tlp1.Controls.Add(this.l8, 0, 7);
            this.tlp1.Controls.Add(this.tb7, 1, 6);
            this.tlp1.Controls.Add(this.tb6, 1, 5);
            this.tlp1.Controls.Add(this.l1, 0, 0);
            this.tlp1.Controls.Add(this.tb5, 1, 4);
            this.tlp1.Controls.Add(this.l9, 0, 8);
            this.tlp1.Controls.Add(this.l7, 0, 6);
            this.tlp1.Controls.Add(this.tb3, 1, 2);
            this.tlp1.Controls.Add(this.l2, 0, 1);
            this.tlp1.Controls.Add(this.tb2, 1, 1);
            this.tlp1.Controls.Add(this.l6, 0, 5);
            this.tlp1.Controls.Add(this.l3, 0, 2);
            this.tlp1.Controls.Add(this.tb1, 1, 0);
            this.tlp1.Controls.Add(this.l5, 0, 4);
            this.tlp1.Controls.Add(this.l4, 0, 3);
            this.tlp1.Location = new System.Drawing.Point(23, 58);
            this.tlp1.Name = "tlp1";
            this.tlp1.RowCount = 9;
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp1.Size = new System.Drawing.Size(384, 360);
            this.tlp1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox1.Location = new System.Drawing.Point(202, 129);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // tb9
            // 
            this.tb9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb9.Location = new System.Drawing.Point(202, 328);
            this.tb9.Name = "tb9";
            this.tb9.Size = new System.Drawing.Size(171, 23);
            this.tb9.TabIndex = 8;
            this.tb9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb9_KeyPress);
            // 
            // tb8
            // 
            this.tb8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb8.Location = new System.Drawing.Point(202, 288);
            this.tb8.Name = "tb8";
            this.tb8.Size = new System.Drawing.Size(171, 23);
            this.tb8.TabIndex = 7;
            // 
            // l8
            // 
            this.l8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l8.AutoSize = true;
            this.l8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l8.Location = new System.Drawing.Point(73, 291);
            this.l8.Name = "l8";
            this.l8.Size = new System.Drawing.Size(45, 18);
            this.l8.TabIndex = 9;
            this.l8.Text = "Email";
            // 
            // tb7
            // 
            this.tb7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb7.Location = new System.Drawing.Point(202, 248);
            this.tb7.Name = "tb7";
            this.tb7.Size = new System.Drawing.Size(171, 23);
            this.tb7.TabIndex = 6;
            this.tb7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb7_KeyPress);
            // 
            // tb6
            // 
            this.tb6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb6.Location = new System.Drawing.Point(202, 208);
            this.tb6.Name = "tb6";
            this.tb6.Size = new System.Drawing.Size(171, 23);
            this.tb6.TabIndex = 5;
            // 
            // l1
            // 
            this.l1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.Location = new System.Drawing.Point(85, 11);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(22, 18);
            this.l1.TabIndex = 2;
            this.l1.Text = "ID";
            // 
            // tb5
            // 
            this.tb5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb5.Location = new System.Drawing.Point(202, 168);
            this.tb5.Name = "tb5";
            this.tb5.Size = new System.Drawing.Size(171, 23);
            this.tb5.TabIndex = 4;
            // 
            // l9
            // 
            this.l9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l9.AutoSize = true;
            this.l9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l9.Location = new System.Drawing.Point(70, 331);
            this.l9.Name = "l9";
            this.l9.Size = new System.Drawing.Size(51, 18);
            this.l9.TabIndex = 2;
            this.l9.Text = "Phone";
            // 
            // l7
            // 
            this.l7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l7.AutoSize = true;
            this.l7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l7.Location = new System.Drawing.Point(45, 251);
            this.l7.Name = "l7";
            this.l7.Size = new System.Drawing.Size(101, 18);
            this.l7.TabIndex = 8;
            this.l7.Text = "Street number";
            // 
            // tb3
            // 
            this.tb3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb3.Location = new System.Drawing.Point(202, 88);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(171, 23);
            this.tb3.TabIndex = 2;
            // 
            // l2
            // 
            this.l2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.Location = new System.Drawing.Point(72, 51);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(48, 18);
            this.l2.TabIndex = 2;
            this.l2.Text = "Name";
            // 
            // tb2
            // 
            this.tb2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb2.Location = new System.Drawing.Point(202, 48);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(171, 23);
            this.tb2.TabIndex = 1;
            // 
            // l6
            // 
            this.l6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l6.AutoSize = true;
            this.l6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l6.Location = new System.Drawing.Point(72, 211);
            this.l6.Name = "l6";
            this.l6.Size = new System.Drawing.Size(47, 18);
            this.l6.TabIndex = 7;
            this.l6.Text = "Street";
            // 
            // l3
            // 
            this.l3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l3.AutoSize = true;
            this.l3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3.Location = new System.Drawing.Point(62, 91);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(68, 18);
            this.l3.TabIndex = 3;
            this.l3.Text = "Surname";
            // 
            // tb1
            // 
            this.tb1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb1.Location = new System.Drawing.Point(202, 8);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(171, 23);
            this.tb1.TabIndex = 0;
            // 
            // l5
            // 
            this.l5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l5.AutoSize = true;
            this.l5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l5.Location = new System.Drawing.Point(79, 171);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(33, 18);
            this.l5.TabIndex = 6;
            this.l5.Text = "City";
            // 
            // l4
            // 
            this.l4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l4.AutoSize = true;
            this.l4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l4.Location = new System.Drawing.Point(67, 131);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(57, 18);
            this.l4.TabIndex = 5;
            this.l4.Text = "Gender";
            // 
            // p2
            // 
            this.p2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p2.BackColor = System.Drawing.Color.SlateBlue;
            this.p2.Controls.Add(this.button3);
            this.p2.Controls.Add(this.button1);
            this.p2.Controls.Add(this.button2);
            this.p2.Controls.Add(this.b2);
            this.p2.Controls.Add(this.tableLayoutPanel1);
            this.p2.Controls.Add(this.panel2);
            this.p2.Controls.Add(this.label2);
            this.p2.Controls.Add(this.b1);
            this.p2.Controls.Add(this.b3);
            this.p2.Controls.Add(this.b4);
            this.p2.Controls.Add(this.panel1);
            this.p2.Controls.Add(this.label1);
            this.p2.Controls.Add(this.lb);
            this.p2.Location = new System.Drawing.Point(20, 20);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(538, 436);
            this.p2.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.AutoEllipsis = true;
            this.button3.BackColor = System.Drawing.Color.Indigo;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(281, 217);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 46);
            this.button3.TabIndex = 15;
            this.button3.Text = "View Visits";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.BackColor = System.Drawing.Color.Indigo;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(407, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 46);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add Visit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Indigo;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(281, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 46);
            this.button2.TabIndex = 13;
            this.button2.Text = "Add Appointment";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.Transparent;
            this.b2.BackgroundImage = global::Dentil.Properties.Resources.editing;
            this.b2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b2.FlatAppearance.BorderSize = 0;
            this.b2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(380, 375);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(45, 45);
            this.b2.TabIndex = 12;
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            this.b2.MouseEnter += new System.EventHandler(this.b2_MouseEnter);
            this.b2.MouseLeave += new System.EventHandler(this.b2_MouseLeave);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox4, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(281, 65);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(236, 120);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Surname";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox5.Location = new System.Drawing.Point(99, 90);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(126, 20);
            this.textBox5.TabIndex = 5;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.Location = new System.Drawing.Point(99, 10);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(126, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.Location = new System.Drawing.Point(99, 50);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(126, 20);
            this.textBox4.TabIndex = 4;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Location = new System.Drawing.Point(281, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 3);
            this.panel2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(277, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search By";
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.Transparent;
            this.b1.BackgroundImage = global::Dentil.Properties.Resources.plus_sign;
            this.b1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.b1.FlatAppearance.BorderSize = 0;
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(472, 375);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(45, 45);
            this.b1.TabIndex = 1;
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            this.b1.MouseEnter += new System.EventHandler(this.b1_MouseEnter);
            this.b1.MouseLeave += new System.EventHandler(this.b1_MouseLeave);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.Transparent;
            this.b3.BackgroundImage = global::Dentil.Properties.Resources.trash;
            this.b3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b3.FlatAppearance.BorderSize = 0;
            this.b3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(281, 375);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(45, 45);
            this.b3.TabIndex = 2;
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            this.b3.MouseEnter += new System.EventHandler(this.b3_MouseEnter);
            this.b3.MouseLeave += new System.EventHandler(this.b3_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Location = new System.Drawing.Point(20, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 3);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patients";
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // lb
            // 
            this.lb.FormattingEnabled = true;
            this.lb.HorizontalScrollbar = true;
            this.lb.Location = new System.Drawing.Point(20, 65);
            this.lb.Name = "lb";
            this.lb.ScrollAlwaysVisible = true;
            this.lb.Size = new System.Drawing.Size(242, 355);
            this.lb.TabIndex = 0;
            this.lb.SelectedIndexChanged += new System.EventHandler(this.lb_SelectedIndexChanged);
            // 
            // viewPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 473);
            this.Controls.Add(this.p1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "viewPatients";
            this.Text = "Dentil";
            this.p1.ResumeLayout(false);
            this.p3.ResumeLayout(false);
            this.p3.PerformLayout();
            this.tlp1.ResumeLayout(false);
            this.tlp1.PerformLayout();
            this.p2.ResumeLayout(false);
            this.p2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4; //this is for OTHER type of users
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb;
        private System.Windows.Forms.TableLayoutPanel tlp1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tb9;
        private System.Windows.Forms.TextBox tb8;
        private System.Windows.Forms.Label l8;
        private System.Windows.Forms.TextBox tb7;
        private System.Windows.Forms.TextBox tb6;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.TextBox tb5;
        private System.Windows.Forms.Label l9;
        private System.Windows.Forms.Label l7;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Label l6;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label l5;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.Panel p3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button b2;

        public void fill()
        {
            button1.Visible = flagButton;
            button3.Visible = flagButton;
            b4.Visible = !flagButton;
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Male");
            comboBox1.Items.Add("Female");
            comboBox1.SelectedIndex = 0;


            findFill("", "", "");
        }

        public void findFill(string id, string name, string surname)
        {
            lb.Items.Clear();
            users.Clear();

            users = dbManagement.Query.getPatients(id, name, surname);

            foreach (user.Patient i in users)
                lb.Items.Add(i);
        }

        public void translate(string curr, string want)
        {
            label1.Text = Program.lang.translate(label1.Text, curr, want);
            label2.Text = Program.lang.translate(label2.Text, curr, want);
            label3.Text = Program.lang.translate(label3.Text, curr, want);
            label4.Text = Program.lang.translate(label4.Text, curr, want);
            label5.Text = Program.lang.translate(label5.Text, curr, want);
            label6.Text = Program.lang.translate(label6.Text, curr, want);
            button1.Text = Program.lang.translate(button1.Text, curr, want);
            button2.Text = Program.lang.translate(button2.Text, curr, want);
            button3.Text = Program.lang.translate(button3.Text, curr, want);
            b4.Text = Program.lang.translate(b4.Text, curr, want);
            l1.Text = Program.lang.translate(l1.Text, curr, want);
            l2.Text = Program.lang.translate(l2.Text, curr, want);
            l3.Text = Program.lang.translate(l3.Text, curr, want);
            l4.Text = Program.lang.translate(l4.Text, curr, want);
            l5.Text = Program.lang.translate(l5.Text, curr, want);
            l6.Text = Program.lang.translate(l6.Text, curr, want);
            l7.Text = Program.lang.translate(l7.Text, curr, want);
            l8.Text = Program.lang.translate(l8.Text, curr, want);
            l9.Text = Program.lang.translate(l9.Text, curr, want);
        }

        public void changeTheme()
        {
            button1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            button2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            button3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            b4.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            p1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel6.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);

            p2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            p3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            
            comboBox1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            textBox3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            textBox4.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            textBox5.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            tb1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            tb2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            tb3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            tb5.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            tb6.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            tb7.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            tb8.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            tb9.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            lb.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);

            b1.BackColor = Color.Transparent;
            b2.BackColor = Color.Transparent;
            b3.BackColor = Color.Transparent;

            button1.Font = new Font(Program.theme.Font, 12);
            button2.Font = new Font(Program.theme.Font, 12);
            button3.Font = new Font(Program.theme.Font, 12);
            label1.Font = new Font(Program.theme.Font, 12);
            label2.Font = new Font(Program.theme.Font, 12);
            label6.Font = new Font(Program.theme.Font, 12);
            label3.Font = new Font(Program.theme.Font, 12);
            textBox3.Font = new Font(Program.theme.Font, 10);
            label4.Font = new Font(Program.theme.Font, 12);
            textBox4.Font = new Font(Program.theme.Font, 10);
            label5.Font = new Font(Program.theme.Font, 12);
            textBox5.Font = new Font(Program.theme.Font, 10);
            lb.Font = new Font(Program.theme.Font, 10);
            l1.Font = new Font(Program.theme.Font, 11);
            l2.Font = new Font(Program.theme.Font, 11);
            l3.Font = new Font(Program.theme.Font, 11);
            l4.Font = new Font(Program.theme.Font, 11);
            l5.Font = new Font(Program.theme.Font, 11);
            l6.Font = new Font(Program.theme.Font, 11);
            l7.Font = new Font(Program.theme.Font, 11);
            l8.Font = new Font(Program.theme.Font, 11);
            l9.Font = new Font(Program.theme.Font, 11);
            tb1.Font = new Font(Program.theme.Font, 11);
            tb2.Font = new Font(Program.theme.Font, 11);
            tb3.Font = new Font(Program.theme.Font, 11);
            tb5.Font = new Font(Program.theme.Font, 11);
            tb6.Font = new Font(Program.theme.Font, 11);
            tb7.Font = new Font(Program.theme.Font, 11);
            tb8.Font = new Font(Program.theme.Font, 11);
            tb9.Font = new Font(Program.theme.Font, 11);
            b4.Font = new Font(Program.theme.Font, 14);
            comboBox1.Font = new Font(Program.theme.Font, 11);

            button1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            button2.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            button3.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            b4.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            lb.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label2.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label6.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label3.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label4.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label5.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            l1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            l2.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            l3.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            l4.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            l5.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            l6.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            l7.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            l8.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            l9.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            textBox3.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            textBox4.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            textBox5.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            tb1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            tb2.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            tb3.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            tb5.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            tb6.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            tb7.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            tb8.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            tb9.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            comboBox1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);    
        }

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}