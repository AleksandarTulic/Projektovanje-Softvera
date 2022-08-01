using System;
using System.Collections.Generic;
using System.Drawing;

namespace Dentil.forms.dentist
{
    partial class ViewAppointment : language.Translate, theme.ChangeTheme
    {
        List<appointment.Appointment> app = new List<appointment.Appointment>();
        List <string> dentistJmb = new List<string> ();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAppointment));
            this.p1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.p3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.ListBox();
            this.p2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.ListBox();
            this.mc = new System.Windows.Forms.MonthCalendar();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.p1.SuspendLayout();
            this.p3.SuspendLayout();
            this.p2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.Indigo;
            this.p1.Controls.Add(this.button3);
            this.p1.Controls.Add(this.button2);
            this.p1.Controls.Add(this.button1);
            this.p1.Controls.Add(this.p3);
            this.p1.Controls.Add(this.p2);
            this.p1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p1.Location = new System.Drawing.Point(0, 0);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(750, 497);
            this.p1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.SlateBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(455, 389);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 90);
            this.button3.TabIndex = 4;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.SlateBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(553, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 90);
            this.button2.TabIndex = 3;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.SlateBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(648, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 90);
            this.button1.TabIndex = 2;
            this.button1.Text = "Input";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // p3
            // 
            this.p3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p3.BackColor = System.Drawing.Color.SlateBlue;
            this.p3.Controls.Add(this.panel5);
            this.p3.Controls.Add(this.label5);
            this.p3.Controls.Add(this.lb2);
            this.p3.Location = new System.Drawing.Point(455, 20);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(283, 356);
            this.p3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Indigo;
            this.panel5.Location = new System.Drawing.Point(20, 40);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(120, 3);
            this.panel5.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Appointments";
            this.label5.MouseEnter += new System.EventHandler(this.label5_MouseEnter);
            this.label5.MouseLeave += new System.EventHandler(this.label5_MouseLeave);
            // 
            // lb2
            // 
            this.lb2.FormattingEnabled = true;
            this.lb2.HorizontalScrollbar = true;
            this.lb2.Location = new System.Drawing.Point(20, 62);
            this.lb2.Name = "lb2";
            this.lb2.ScrollAlwaysVisible = true;
            this.lb2.Size = new System.Drawing.Size(243, 277);
            this.lb2.TabIndex = 0;
            // 
            // p2
            // 
            this.p2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p2.BackColor = System.Drawing.Color.SlateBlue;
            this.p2.Controls.Add(this.panel4);
            this.p2.Controls.Add(this.panel3);
            this.p2.Controls.Add(this.panel2);
            this.p2.Controls.Add(this.panel1);
            this.p2.Controls.Add(this.tableLayoutPanel1);
            this.p2.Controls.Add(this.label4);
            this.p2.Controls.Add(this.label3);
            this.p2.Controls.Add(this.label2);
            this.p2.Controls.Add(this.label1);
            this.p2.Controls.Add(this.lb1);
            this.p2.Controls.Add(this.mc);
            this.p2.Controls.Add(this.cb1);
            this.p2.Location = new System.Drawing.Point(20, 20);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(415, 459);
            this.p2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Indigo;
            this.panel4.Location = new System.Drawing.Point(167, 290);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(120, 3);
            this.panel4.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Indigo;
            this.panel3.Location = new System.Drawing.Point(20, 290);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(120, 3);
            this.panel3.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Location = new System.Drawing.Point(260, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 3);
            this.panel2.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Location = new System.Drawing.Point(20, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 3);
            this.panel1.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(167, 317);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(236, 120);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Surname";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(97, 88);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(136, 23);
            this.textBox3.TabIndex = 9;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "ID";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(97, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 23);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(97, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 23);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(166, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Search By";
            this.label4.MouseEnter += new System.EventHandler(this.label4_MouseEnter);
            this.label4.MouseLeave += new System.EventHandler(this.label4_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dentist";
            this.label3.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selected Date";
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date";
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // lb1
            // 
            this.lb1.FormattingEnabled = true;
            this.lb1.Location = new System.Drawing.Point(260, 62);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(136, 173);
            this.lb1.TabIndex = 1;
            this.lb1.SelectedIndexChanged += new System.EventHandler(this.lb1_SelectedIndexChanged);
            // 
            // mc
            // 
            this.mc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mc.Location = new System.Drawing.Point(20, 62);
            this.mc.Name = "mc";
            this.mc.TabIndex = 2;
            this.mc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mc_MouseDown);
            // 
            // cb1
            // 
            this.cb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb1.FormattingEnabled = true;
            this.cb1.Location = new System.Drawing.Point(20, 320);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(112, 24);
            this.cb1.TabIndex = 1;
            this.cb1.SelectedIndexChanged += new System.EventHandler(this.cb1_SelectedIndexChanged);
            // 
            // ViewAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 497);
            this.Controls.Add(this.p1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewAppointment";
            this.Text = "Dentil";
            this.p1.ResumeLayout(false);
            this.p1.PerformLayout();
            this.p3.ResumeLayout(false);
            this.p3.PerformLayout();
            this.p2.ResumeLayout(false);
            this.p2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
            label8.Text = Program.lang.translate(label8.Text, curr, want);
            button1.Text = Program.lang.translate(button1.Text, curr, want);
            button2.Text = Program.lang.translate(button2.Text, curr, want);
            button3.Text = Program.lang.translate(button3.Text, curr, want);
        }

        public void changeTheme()
        {
            p1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            p2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            p3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            panel1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel4.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel5.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            mc.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            lb1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            lb2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            button1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            button2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            button3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);

            label1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label2.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label3.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label4.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label5.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label6.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label7.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label8.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            cb1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            textBox1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            textBox2.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            textBox3.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            button3.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            button2.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            button1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            lb1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            lb2.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);

            lb2.Font = new Font(Program.theme.Font, 10);
            lb1.Font = new Font(Program.theme.Font, 10);
            button1.Font = new Font(Program.theme.Font, 14);
            button2.Font = new Font(Program.theme.Font, 14);
            button3.Font = new Font(Program.theme.Font, 14);
            textBox3.Font = new Font(Program.theme.Font, 10);
            textBox2.Font = new Font(Program.theme.Font, 10);
            textBox1.Font = new Font(Program.theme.Font, 10);
            cb1.Font = new Font(Program.theme.Font, 10);
            label1.Font = new Font(Program.theme.Font, 12);
            label2.Font = new Font(Program.theme.Font, 12);
            label3.Font = new Font(Program.theme.Font, 12);
            label4.Font = new Font(Program.theme.Font, 12);
            label5.Font = new Font(Program.theme.Font, 12);
            label6.Font = new Font(Program.theme.Font, 11);
            label7.Font = new Font(Program.theme.Font, 11);
            label8.Font = new Font(Program.theme.Font, 11);
        }

        public void fill()
        {
            cb1.Items.Clear();

            List<List<string> > arr = dbManagement.Query.query(dbManagement.Query.allDentist);
        
            foreach (List <string> i in arr)
            {
                dentistJmb.Add(i[0]);
                cb1.Items.Add($"{i[1]}, {i[2]}");
            }
        }

        
        public void fillWhenChanged()
        {
            lb2.Items.Clear();
            //Console.WriteLine(lb1.SelectedIndex);
            //Console.WriteLine((new elements.helpElements.Date(lb1.SelectedItem.ToString())).getWithZero());
            app = dbManagement.Query.getAppointments(lb1.SelectedIndex < 0 ? null : (new elements.helpElements.Date(lb1.SelectedItem.ToString())).getWithZero(), cb1.SelectedIndex < 0 ? "" : dentistJmb[cb1.SelectedIndex], textBox1.Text, textBox2.Text, textBox3.Text);

            foreach (appointment.Appointment i in app)
                lb2.Items.Add(i.ToString());
        }

        #endregion

        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel p3;
        private System.Windows.Forms.ListBox lb2;
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.MonthCalendar mc;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}