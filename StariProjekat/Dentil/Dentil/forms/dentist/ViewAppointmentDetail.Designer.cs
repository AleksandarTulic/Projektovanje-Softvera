using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Dentil.forms.dentist
{
    partial class ViewAppointmentDetail : language.Translate, theme.ChangeTheme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAppointmentDetail));
            this.p1 = new System.Windows.Forms.Panel();
            this.p2 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.l3 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.p1.SuspendLayout();
            this.p2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.Indigo;
            this.p1.Controls.Add(this.p2);
            this.p1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p1.Location = new System.Drawing.Point(0, 0);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(386, 450);
            this.p1.TabIndex = 0;
            // 
            // p2
            // 
            this.p2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p2.BackColor = System.Drawing.Color.SlateBlue;
            this.p2.Controls.Add(this.panel2);
            this.p2.Controls.Add(this.panel1);
            this.p2.Controls.Add(this.label2);
            this.p2.Controls.Add(this.label1);
            this.p2.Controls.Add(this.tableLayoutPanel1);
            this.p2.Controls.Add(this.tb4);
            this.p2.Location = new System.Drawing.Point(20, 20);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(340, 418);
            this.p2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Location = new System.Drawing.Point(20, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 3);
            this.panel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Location = new System.Drawing.Point(20, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 3);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Note";
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Other Information";
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.l3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.l2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.l1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb3, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 51);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 120);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // l3
            // 
            this.l3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l3.AutoSize = true;
            this.l3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3.Location = new System.Drawing.Point(30, 90);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(59, 20);
            this.l3.TabIndex = 6;
            this.l3.Text = "Patient";
            // 
            // l2
            // 
            this.l2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.Location = new System.Drawing.Point(30, 50);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(60, 20);
            this.l2.TabIndex = 6;
            this.l2.Text = "Dentist";
            // 
            // l1
            // 
            this.l1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.Location = new System.Drawing.Point(25, 10);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(70, 20);
            this.l1.TabIndex = 5;
            this.l1.Text = "Duration";
            // 
            // tb1
            // 
            this.tb1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb1.Location = new System.Drawing.Point(123, 8);
            this.tb1.Name = "tb1";
            this.tb1.ReadOnly = true;
            this.tb1.Size = new System.Drawing.Size(174, 23);
            this.tb1.TabIndex = 0;
            // 
            // tb2
            // 
            this.tb2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb2.Location = new System.Drawing.Point(123, 48);
            this.tb2.Name = "tb2";
            this.tb2.ReadOnly = true;
            this.tb2.Size = new System.Drawing.Size(174, 23);
            this.tb2.TabIndex = 1;
            // 
            // tb3
            // 
            this.tb3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb3.Location = new System.Drawing.Point(123, 88);
            this.tb3.Name = "tb3";
            this.tb3.ReadOnly = true;
            this.tb3.Size = new System.Drawing.Size(174, 23);
            this.tb3.TabIndex = 2;
            // 
            // tb4
            // 
            this.tb4.Location = new System.Drawing.Point(20, 251);
            this.tb4.Multiline = true;
            this.tb4.Name = "tb4";
            this.tb4.ReadOnly = true;
            this.tb4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb4.Size = new System.Drawing.Size(297, 148);
            this.tb4.TabIndex = 3;
            // 
            // ViewAppointmentDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 450);
            this.Controls.Add(this.p1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewAppointmentDetail";
            this.Text = "Dentil";
            this.p1.ResumeLayout(false);
            this.p2.ResumeLayout(false);
            this.p2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        public void translate(string curr, string want)
        {
            l1.Text = Program.lang.translate(l1.Text, curr, want);
            l2.Text = Program.lang.translate(l2.Text, curr, want);
            l3.Text = Program.lang.translate(l3.Text, curr, want);
            label1.Text = Program.lang.translate(label1.Text, curr, want);
            label2.Text = Program.lang.translate(label2.Text, curr, want);
        }

        public void changeTheme()
        {
            p1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            p2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);

            tb1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            tb2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            tb3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            tb4.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
        }

        #endregion

        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

        public void fill(appointment.Appointment app)
        {
            ToolTip tt = new ToolTip();
            tb1.Text = $"{app.HowLong}";
            tt.SetToolTip(tb1, Program.lang.translate("Number of Minutes", Program.defaultLang, Program.lang.CurrLang));
            List<user.Patient> arr1 = dbManagement.Query.getPatients(app.PatientJmb,"","");
            //Console.WriteLine(app.PatientJmb + " " + app.DentistJmb);
            user.User arr2 = dbManagement.Query.getUser(app.DentistJmb);
            tb2.Text = $"{arr1[0].Name}, {arr1[0].Surname}";
            tb3.Text = $"{arr2.Name}, {arr2.Surname}";
            tb4.Text = "0".Equals(app.Note) ? "" : app.Note;
        }
    }
}