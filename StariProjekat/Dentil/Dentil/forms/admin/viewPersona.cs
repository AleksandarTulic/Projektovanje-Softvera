using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dentil.language;
using Dentil.theme;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing;

namespace Dentil.forms.admin
{
    public class viewPersona : common.Common, Translate, ChangeTheme
    {
        List<user.SpecificUser> users1 = new List<user.SpecificUser>();
        List<user.SpecificUser> users2 = new List<user.SpecificUser>();

        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.Panel p3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tlp1;
        private System.Windows.Forms.TextBox tb12;
        private System.Windows.Forms.TextBox tb10;
        private System.Windows.Forms.TextBox tb11;
        private System.Windows.Forms.Label l12;
        private System.Windows.Forms.TextBox tb9;
        private System.Windows.Forms.Label l9;
        private System.Windows.Forms.TextBox tb8;
        private System.Windows.Forms.Label l11;
        private System.Windows.Forms.TextBox tb7;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.TextBox tb6;
        private System.Windows.Forms.Label l10;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.Label l8;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Label l7;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label l6;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.Label l5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel p5;
        private System.Windows.Forms.TableLayoutPanel tlp3;
        private System.Windows.Forms.Panel p4;
        private System.Windows.Forms.TableLayoutPanel tlp2;
        private System.Windows.Forms.Label l16;
        private System.Windows.Forms.TextBox tb16;
        private System.Windows.Forms.Label l15;
        private System.Windows.Forms.TextBox tb14;
        private System.Windows.Forms.Label l14;
        private System.Windows.Forms.TextBox tb15;
        private System.Windows.Forms.Label l13;
        private System.Windows.Forms.TextBox tb13;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;

        public viewPersona(System.Windows.Forms.Form a)
        {
            this.p5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tlp3 = new System.Windows.Forms.TableLayoutPanel();
            this.l16 = new System.Windows.Forms.Label();
            this.tb16 = new System.Windows.Forms.TextBox();
            this.l15 = new System.Windows.Forms.Label();
            this.tb14 = new System.Windows.Forms.TextBox();
            this.l14 = new System.Windows.Forms.Label();
            this.tb15 = new System.Windows.Forms.TextBox();
            this.l13 = new System.Windows.Forms.Label();
            this.tb13 = new System.Windows.Forms.TextBox();
            this.p4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tlp2 = new System.Windows.Forms.TableLayoutPanel();
            this.tb12 = new System.Windows.Forms.TextBox();
            this.l12 = new System.Windows.Forms.Label();
            this.tb11 = new System.Windows.Forms.TextBox();
            this.l11 = new System.Windows.Forms.Label();
            this.p3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tlp1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tb10 = new System.Windows.Forms.TextBox();
            this.tb9 = new System.Windows.Forms.TextBox();
            this.l9 = new System.Windows.Forms.Label();
            this.tb8 = new System.Windows.Forms.TextBox();
            this.tb7 = new System.Windows.Forms.TextBox();
            this.l1 = new System.Windows.Forms.Label();
            this.tb6 = new System.Windows.Forms.TextBox();
            this.l10 = new System.Windows.Forms.Label();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.l8 = new System.Windows.Forms.Label();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.l2 = new System.Windows.Forms.Label();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.l7 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.l6 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.l5 = new System.Windows.Forms.Label();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.p2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.b3 = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.ListBox();
            this.p.SuspendLayout();
            this.p5.SuspendLayout();
            this.tlp3.SuspendLayout();
            this.p4.SuspendLayout();
            this.tlp2.SuspendLayout();
            this.p3.SuspendLayout();
            this.tlp1.SuspendLayout();
            this.p2.SuspendLayout();
            a.SuspendLayout();
            // 
            // p1
            // 
            this.p.BackColor = System.Drawing.Color.Indigo;
            this.p.Controls.Add(this.p5);
            this.p.Controls.Add(this.p4);
            this.p.Controls.Add(this.p3);
            this.p.Controls.Add(this.b2);
            this.p.Controls.Add(this.b1);
            this.p.Controls.Add(this.p2);
            this.p.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p.Location = new System.Drawing.Point(0, 0);
            this.p.Name = "p1";
            this.p.Size = new System.Drawing.Size(1127, 536);
            this.p.TabIndex = 0;
            // 
            // p5
            // 
            this.p5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p5.BackColor = System.Drawing.Color.SlateBlue;
            this.p5.Controls.Add(this.panel4);
            this.p5.Controls.Add(this.label4);
            this.p5.Controls.Add(this.tlp3);
            this.p5.Location = new System.Drawing.Point(797, 238);
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(309, 202);
            this.p5.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Indigo;
            this.panel4.Location = new System.Drawing.Point(19, 47);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(160, 3);
            this.panel4.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Work Info";
            this.label4.MouseEnter += new System.EventHandler(this.label4_MouseEnter);
            this.label4.MouseLeave += new System.EventHandler(this.label4_MouseLeave);
            // 
            // tlp3
            // 
            this.tlp3.AutoSize = true;
            this.tlp3.ColumnCount = 2;
            this.tlp3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp3.Controls.Add(this.l16, 0, 3);
            this.tlp3.Controls.Add(this.tb16, 1, 3);
            this.tlp3.Controls.Add(this.l15, 0, 2);
            this.tlp3.Controls.Add(this.tb14, 1, 1);
            this.tlp3.Controls.Add(this.l14, 0, 1);
            this.tlp3.Controls.Add(this.tb15, 1, 2);
            this.tlp3.Controls.Add(this.l13, 0, 0);
            this.tlp3.Controls.Add(this.tb13, 1, 0);
            this.tlp3.Location = new System.Drawing.Point(19, 64);
            this.tlp3.Name = "tlp3";
            this.tlp3.RowCount = 4;
            this.tlp3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp3.Size = new System.Drawing.Size(272, 120);
            this.tlp3.TabIndex = 0;
            // 
            // l16
            // 
            this.l16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l16.AutoSize = true;
            this.l16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l16.Location = new System.Drawing.Point(11, 96);
            this.l16.Name = "l16";
            this.l16.Size = new System.Drawing.Size(113, 18);
            this.l16.TabIndex = 7;
            this.l16.Text = "Education place";
            // 
            // tb16
            // 
            this.tb16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb16.Location = new System.Drawing.Point(139, 93);
            this.tb16.Name = "tb16";
            this.tb16.Size = new System.Drawing.Size(130, 23);
            this.tb16.TabIndex = 4;
            // 
            // l15
            // 
            this.l15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l15.AutoSize = true;
            this.l15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l15.Location = new System.Drawing.Point(38, 66);
            this.l15.Name = "l15";
            this.l15.Size = new System.Drawing.Size(59, 18);
            this.l15.TabIndex = 6;
            this.l15.Text = "Job title";
            // 
            // tb14
            // 
            this.tb14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb14.Location = new System.Drawing.Point(139, 33);
            this.tb14.Name = "tb14";
            this.tb14.ReadOnly = true;
            this.tb14.Size = new System.Drawing.Size(130, 23);
            this.tb14.TabIndex = 5;
            // 
            // l14
            // 
            this.l14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l14.AutoSize = true;
            this.l14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l14.Location = new System.Drawing.Point(33, 36);
            this.l14.Name = "l14";
            this.l14.Size = new System.Drawing.Size(69, 18);
            this.l14.TabIndex = 5;
            this.l14.Text = "End Date";
            // 
            // tb15
            // 
            this.tb15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb15.Location = new System.Drawing.Point(139, 63);
            this.tb15.Name = "tb15";
            this.tb15.Size = new System.Drawing.Size(130, 23);
            this.tb15.TabIndex = 4;
            // 
            // l13
            // 
            this.l13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l13.AutoSize = true;
            this.l13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l13.Location = new System.Drawing.Point(31, 6);
            this.l13.Name = "l13";
            this.l13.Size = new System.Drawing.Size(74, 18);
            this.l13.TabIndex = 4;
            this.l13.Text = "Start Date";
            // 
            // tb13
            // 
            this.tb13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb13.Location = new System.Drawing.Point(139, 3);
            this.tb13.Name = "tb13";
            this.tb13.ReadOnly = true;
            this.tb13.Size = new System.Drawing.Size(130, 23);
            this.tb13.TabIndex = 4;
            // 
            // p4
            // 
            this.p4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p4.BackColor = System.Drawing.Color.SlateBlue;
            this.p4.Controls.Add(this.panel3);
            this.p4.Controls.Add(this.label3);
            this.p4.Controls.Add(this.tlp2);
            this.p4.Location = new System.Drawing.Point(797, 20);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(309, 190);
            this.p4.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Indigo;
            this.panel3.Location = new System.Drawing.Point(19, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(120, 3);
            this.panel3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bank Info";
            this.label3.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            // 
            // tlp2
            // 
            this.tlp2.ColumnCount = 2;
            this.tlp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp2.Controls.Add(this.tb12, 1, 1);
            this.tlp2.Controls.Add(this.l12, 0, 1);
            this.tlp2.Controls.Add(this.tb11, 1, 0);
            this.tlp2.Controls.Add(this.l11, 0, 0);
            this.tlp2.Location = new System.Drawing.Point(19, 65);
            this.tlp2.Name = "tlp2";
            this.tlp2.RowCount = 2;
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp2.Size = new System.Drawing.Size(274, 102);
            this.tlp2.TabIndex = 0;
            // 
            // tb12
            // 
            this.tb12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb12.Location = new System.Drawing.Point(140, 65);
            this.tb12.Name = "tb12";
            this.tb12.Size = new System.Drawing.Size(131, 23);
            this.tb12.TabIndex = 12;
            this.tb12.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb12_KeyPress);
            // 
            // l12
            // 
            this.l12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l12.AutoSize = true;
            this.l12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l12.Location = new System.Drawing.Point(19, 67);
            this.l12.Name = "l12";
            this.l12.Size = new System.Drawing.Size(99, 18);
            this.l12.TabIndex = 4;
            this.l12.Text = "Bank account";
            // 
            // tb11
            // 
            this.tb11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb11.Location = new System.Drawing.Point(140, 14);
            this.tb11.Name = "tb11";
            this.tb11.Size = new System.Drawing.Size(131, 23);
            this.tb11.TabIndex = 11;
            // 
            // l11
            // 
            this.l11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l11.AutoSize = true;
            this.l11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l11.Location = new System.Drawing.Point(47, 16);
            this.l11.Name = "l11";
            this.l11.Size = new System.Drawing.Size(42, 18);
            this.l11.TabIndex = 3;
            this.l11.Text = "Bank";
            // 
            // p3
            // 
            this.p3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p3.BackColor = System.Drawing.Color.SlateBlue;
            this.p3.Controls.Add(this.panel2);
            this.p3.Controls.Add(this.label2);
            this.p3.Controls.Add(this.tlp1);
            this.p3.Location = new System.Drawing.Point(353, 20);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(424, 500);
            this.p3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Location = new System.Drawing.Point(20, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 3);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Information";
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // tlp1
            // 
            this.tlp1.ColumnCount = 2;
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp1.Controls.Add(this.comboBox1, 1, 4);
            this.tlp1.Controls.Add(this.tb10, 1, 9);
            this.tlp1.Controls.Add(this.tb9, 1, 8);
            this.tlp1.Controls.Add(this.l9, 0, 8);
            this.tlp1.Controls.Add(this.tb8, 1, 7);
            this.tlp1.Controls.Add(this.tb7, 1, 6);
            this.tlp1.Controls.Add(this.l1, 0, 0);
            this.tlp1.Controls.Add(this.tb6, 1, 5);
            this.tlp1.Controls.Add(this.l10, 0, 9);
            this.tlp1.Controls.Add(this.tb4, 1, 3);
            this.tlp1.Controls.Add(this.l8, 0, 7);
            this.tlp1.Controls.Add(this.tb3, 1, 2);
            this.tlp1.Controls.Add(this.l2, 0, 1);
            this.tlp1.Controls.Add(this.tb2, 1, 1);
            this.tlp1.Controls.Add(this.l7, 0, 6);
            this.tlp1.Controls.Add(this.l3, 0, 2);
            this.tlp1.Controls.Add(this.tb1, 1, 0);
            this.tlp1.Controls.Add(this.l6, 0, 5);
            this.tlp1.Controls.Add(this.l4, 0, 3);
            this.tlp1.Controls.Add(this.l5, 0, 4);
            this.tlp1.Location = new System.Drawing.Point(20, 71);
            this.tlp1.Name = "tlp1";
            this.tlp1.RowCount = 10;
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp1.Size = new System.Drawing.Size(384, 400);
            this.tlp1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(202, 167);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // tb10
            // 
            this.tb10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb10.Location = new System.Drawing.Point(202, 368);
            this.tb10.Name = "tb10";
            this.tb10.Size = new System.Drawing.Size(171, 23);
            this.tb10.TabIndex = 13;
            this.tb10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb10_KeyPress);
            // 
            // tb9
            // 
            this.tb9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb9.Location = new System.Drawing.Point(202, 328);
            this.tb9.Name = "tb9";
            this.tb9.Size = new System.Drawing.Size(171, 23);
            this.tb9.TabIndex = 10;
            // 
            // l9
            // 
            this.l9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l9.AutoSize = true;
            this.l9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l9.Location = new System.Drawing.Point(73, 331);
            this.l9.Name = "l9";
            this.l9.Size = new System.Drawing.Size(45, 18);
            this.l9.TabIndex = 9;
            this.l9.Text = "Email";
            // 
            // tb8
            // 
            this.tb8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb8.Location = new System.Drawing.Point(202, 288);
            this.tb8.Name = "tb8";
            this.tb8.Size = new System.Drawing.Size(171, 23);
            this.tb8.TabIndex = 9;
            this.tb8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb8_KeyPress);
            // 
            // tb7
            // 
            this.tb7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb7.Location = new System.Drawing.Point(202, 248);
            this.tb7.Name = "tb7";
            this.tb7.Size = new System.Drawing.Size(171, 23);
            this.tb7.TabIndex = 8;
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
            // tb6
            // 
            this.tb6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb6.Location = new System.Drawing.Point(202, 208);
            this.tb6.Name = "tb6";
            this.tb6.Size = new System.Drawing.Size(171, 23);
            this.tb6.TabIndex = 7;
            // 
            // l10
            // 
            this.l10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l10.AutoSize = true;
            this.l10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l10.Location = new System.Drawing.Point(70, 371);
            this.l10.Name = "l10";
            this.l10.Size = new System.Drawing.Size(51, 18);
            this.l10.TabIndex = 2;
            this.l10.Text = "Phone";
            // 
            // tb4
            // 
            this.tb4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb4.Location = new System.Drawing.Point(202, 128);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(171, 23);
            this.tb4.TabIndex = 6;
            // 
            // l8
            // 
            this.l8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l8.AutoSize = true;
            this.l8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l8.Location = new System.Drawing.Point(45, 291);
            this.l8.Name = "l8";
            this.l8.Size = new System.Drawing.Size(101, 18);
            this.l8.TabIndex = 8;
            this.l8.Text = "Street number";
            // 
            // tb3
            // 
            this.tb3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb3.Location = new System.Drawing.Point(202, 88);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(171, 23);
            this.tb3.TabIndex = 5;
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
            this.tb2.TabIndex = 4;
            // 
            // l7
            // 
            this.l7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l7.AutoSize = true;
            this.l7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l7.Location = new System.Drawing.Point(72, 251);
            this.l7.Name = "l7";
            this.l7.Size = new System.Drawing.Size(47, 18);
            this.l7.TabIndex = 7;
            this.l7.Text = "Street";
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
            this.tb1.TabIndex = 2;
            // 
            // l6
            // 
            this.l6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l6.AutoSize = true;
            this.l6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l6.Location = new System.Drawing.Point(79, 211);
            this.l6.Name = "l6";
            this.l6.Size = new System.Drawing.Size(33, 18);
            this.l6.TabIndex = 6;
            this.l6.Text = "City";
            // 
            // l4
            // 
            this.l4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l4.AutoSize = true;
            this.l4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l4.Location = new System.Drawing.Point(57, 131);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(77, 18);
            this.l4.TabIndex = 4;
            this.l4.Text = "Username";
            // 
            // l5
            // 
            this.l5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l5.AutoSize = true;
            this.l5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l5.Location = new System.Drawing.Point(67, 171);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(57, 18);
            this.l5.TabIndex = 5;
            this.l5.Text = "Gender";
            // 
            // b2
            // 
            this.b2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b2.BackColor = System.Drawing.Color.SlateBlue;
            this.b2.FlatAppearance.BorderSize = 0;
            this.b2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(978, 459);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(128, 60);
            this.b2.TabIndex = 2;
            this.b2.Text = "Modify";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            this.b2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.b2_MouseClick);
            this.b2.MouseEnter += new System.EventHandler(this.b2_MouseEnter);
            this.b2.MouseLeave += new System.EventHandler(this.b2_MouseLeave);
            // 
            // b1
            // 
            this.b1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b1.BackColor = System.Drawing.Color.SlateBlue;
            this.b1.FlatAppearance.BorderSize = 0;
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(797, 460);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(128, 60);
            this.b1.TabIndex = 4;
            this.b1.Text = "Input";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.b1_MouseClick);
            this.b1.MouseEnter += new System.EventHandler(this.b1_MouseEnter);
            this.b1.MouseLeave += new System.EventHandler(this.b1_MouseLeave);
            // 
            // p2
            // 
            this.p2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p2.BackColor = System.Drawing.Color.SlateBlue;
            this.p2.Controls.Add(this.panel5);
            this.p2.Controls.Add(this.label5);
            this.p2.Controls.Add(this.lb2);
            this.p2.Controls.Add(this.panel1);
            this.p2.Controls.Add(this.label1);
            this.p2.Controls.Add(this.b3);
            this.p2.Controls.Add(this.lb1);
            this.p2.Location = new System.Drawing.Point(20, 20);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(315, 500);
            this.p2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Indigo;
            this.panel5.Location = new System.Drawing.Point(20, 288);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(170, 3);
            this.panel5.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Former Working Staff";
            this.label5.MouseEnter += new System.EventHandler(this.label5_MouseEnter);
            this.label5.MouseLeave += new System.EventHandler(this.label5_MouseLeave);
            // 
            // lb2
            // 
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.FormattingEnabled = true;
            this.lb2.HorizontalScrollbar = true;
            this.lb2.ItemHeight = 16;
            this.lb2.Location = new System.Drawing.Point(20, 315);
            this.lb2.Name = "lb2";
            this.lb2.ScrollAlwaysVisible = true;
            this.lb2.Size = new System.Drawing.Size(275, 164);
            this.lb2.TabIndex = 4;
            this.lb2.SelectedIndexChanged += new System.EventHandler(this.lb2_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Location = new System.Drawing.Point(20, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 3);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Working Staff";
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.SlateBlue;
            this.b3.BackgroundImage = global::Dentil.Properties.Resources.trash;
            this.b3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b3.FlatAppearance.BorderSize = 0;
            this.b3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(255, 25);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(40, 40);
            this.b3.TabIndex = 3;
            this.b3.Text = "Delete";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.b3_MouseClick);
            this.b3.MouseHover += new System.EventHandler(this.b3_MouseHover);
            // 
            // lb1
            // 
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.FormattingEnabled = true;
            this.lb1.HorizontalScrollbar = true;
            this.lb1.ItemHeight = 16;
            this.lb1.Location = new System.Drawing.Point(20, 71);
            this.lb1.Name = "lb1";
            this.lb1.ScrollAlwaysVisible = true;
            this.lb1.Size = new System.Drawing.Size(275, 164);
            this.lb1.TabIndex = 0;
            this.lb1.SelectedIndexChanged += new System.EventHandler(this.lb1_SelectedIndexChanged);
            // 
            // ViewPersonal
            // 
            a.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            a.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            a.ClientSize = new System.Drawing.Size(1127, 536);
            a.Controls.Add(this.p);
            this.p.ResumeLayout(false);
            this.p5.ResumeLayout(false);
            this.p5.PerformLayout();
            this.tlp3.ResumeLayout(false);
            this.tlp3.PerformLayout();
            this.p4.ResumeLayout(false);
            this.p4.PerformLayout();
            this.tlp2.ResumeLayout(false);
            this.tlp2.PerformLayout();
            this.p3.ResumeLayout(false);
            this.p3.PerformLayout();
            this.tlp1.ResumeLayout(false);
            this.tlp1.PerformLayout();
            this.p2.ResumeLayout(false);
            this.p2.PerformLayout();
            a.ResumeLayout(false);
            p.BringToFront();

            fill();
            changeTheme();
            translate(Program.defaultLang, Program.lang.CurrLang);
        }

        //insert
        private void b1_MouseClick(object sender, MouseEventArgs e)
        {
            PersonalInput pi = new PersonalInput();
            pi.ShowDialog();
            fill();
        }

        private void b1_MouseEnter(object sender, EventArgs e)
        {
            b1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void b1_MouseLeave(object sender, EventArgs e)
        {
            b1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
        }

        //modify
        private void b2_MouseClick(object sender, MouseEventArgs e)
        {
            b1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void b2_MouseEnter(object sender, EventArgs e)
        {
            b2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
        }

        private void b2_MouseLeave(object sender, EventArgs e)
        {
            b1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
        }

        //delete
        private void b3_MouseClick(object sender, MouseEventArgs e)
        {
            if (lb1.SelectedIndex < 0)
            {
                MessageBox.Show(Program.lang.translate("Operation not possible", Program.defaultLang, Program.lang.CurrLang), Program.lang.translate("Delete staff member", Program.defaultLang, Program.lang.CurrLang),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool flag = dbManagement.Delete.deletePersonal(users1[lb1.SelectedIndex].Id);

            if (!flag)
                MessageBox.Show(Program.lang.translate("Operation not possible", Program.defaultLang, Program.lang.CurrLang), Program.lang.translate("Delete staff member", Program.defaultLang, Program.lang.CurrLang),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show(Program.lang.translate("Operation successful", Program.defaultLang, Program.lang.CurrLang), Program.lang.translate("Delete staff member", Program.defaultLang, Program.lang.CurrLang),
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                fill();
            }
        }

        private void b3_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.AutoPopDelay = 5000;
            tt.InitialDelay = 1000;
            tt.ReshowDelay = 500;
            tt.ShowAlways = true;
            tt.SetToolTip(b3, Program.lang.translate("Delete staff member", Program.defaultLang, Program.lang.CurrLang));
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            panel3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            panel4.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
        }

        private void lb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb1.SelectedIndex < 0)
                return;

            lb2.ClearSelected();
            b3.Visible = true;
            fillPanels(users1[lb1.SelectedIndex]);
        }

        private void lb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb2.SelectedIndex < 0)
                return;

            lb1.ClearSelected();
            b3.Visible = false;

            fillPanels(users2[lb2.SelectedIndex]);
        }

        private void fillPanels(user.SpecificUser user)
        {
            reset();
            tb1.Text = user.Id;
            tb2.Text = user.Name;
            tb3.Text = user.Surname;
            tb4.Text = user.UserName;
            if ("Male".Equals(user.Gender))
                comboBox1.SelectedIndex = 0;
            else
                comboBox1.SelectedIndex = 1;

            tb6.Text = "null".Equals(user.City) ? "" : user.City;
            tb7.Text = "null".Equals(user.Street) ? "" : user.Street;
            tb8.Text = "null".Equals(user.StreetNum.ToString()) ? "" : user.StreetNum.ToString();
            tb9.Text = "null".Equals(user.Email) ? "" : user.Email;
            tb10.Text = "null".Equals(user.Phone) ? "" : user.Phone;
            tb11.Text = user.Bank;
            tb12.Text = user.NumAccount;
            tb13.Text = user.DateBegin.ToString();
            tb14.Text = user.DateEnd == null ? "" : user.DateEnd.ToString();
            tb15.Text = "null".Equals(user.Title) ? "" : user.Title;
            tb16.Text = "null".Equals(user.EducationPlace) ? "" : user.EducationPlace;
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            panel5.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if ((b3.Visible && lb1.SelectedIndex < 0) || (!b3.Visible && lb2.SelectedIndex < 0) || !checkRegex(new Regex(user.User.regexEmail), tb9.Text) || 
                !checkRegex(new Regex(user.User.regexCity), tb6.Text) || !checkRegex(new Regex(user.User.regexPhone), tb10.Text))
            {
                MessageBox.Show(Program.lang.translate("Operation not successful", Program.defaultLang, Program.lang.CurrLang), Program.lang.translate("Modify staff member info", Program.defaultLang, Program.lang.CurrLang),
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                bool flag = dbManagement.Modify.modifyPersonal(
                    b3.Visible ? users1[lb1.SelectedIndex].Id : users2[lb2.SelectedIndex].Id,
                    tb1.Text,
                    tb2.Text,
                    tb3.Text,
                    comboBox1.SelectedItem.ToString(),
                    tb6.Text,
                    tb7.Text,
                    int.Parse(tb8.Text),
                    tb9.Text,
                    tb10.Text,
                    tb11.Text,
                    tb12.Text,
                    tb15.Text,
                    tb16.Text,
                    tb4.Text
                );

                if (flag)
                    MessageBox.Show(Program.lang.translate("Operation successful", Program.defaultLang, Program.lang.CurrLang), Program.lang.translate("Modify staff member info", Program.defaultLang, Program.lang.CurrLang),
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(Program.lang.translate("Operation not successful", Program.defaultLang, Program.lang.CurrLang), Program.lang.translate("Modify staff member info", Program.defaultLang, Program.lang.CurrLang),
                   MessageBoxButtons.OK, MessageBoxIcon.Error);

                fill();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
            }
        }

        private void tb8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void tb10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void tb12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private bool checkRegex(Regex regex, string text)
        {
            return regex.IsMatch(text);
        }

        private void fill()
        {
            reset();
            lb1.Items.Clear();
            lb2.Items.Clear();
            users1.Clear();
            users2.Clear();
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Male");
            comboBox1.Items.Add("Female");
            List<List<string>> arrUser = dbManagement.Query.query(dbManagement.Query.allUserSpecificInfo);

            for (int i = 0; i < arrUser.Count; i++)
            {
                user.SpecificUser user = new user.SpecificUser(arrUser[i]);

                if (user.DateEnd == null)
                {
                    users1.Add(user);
                    lb1.Items.Add(users1[users1.Count - 1]);
                }
                else
                {
                    users2.Add(user);
                    lb2.Items.Add(users2[users2.Count - 1]);
                }
            }
        }

        private void reset()
        {
            tb1.Text = "";
            tb2.Text = "";
            tb3.Text = "";
            tb4.Text = "";
            tb6.Text = "";
            tb7.Text = "";
            tb8.Text = "";
            tb9.Text = "";
            tb10.Text = "";
            tb11.Text = "";
            tb12.Text = "";
            tb13.Text = "";
            tb14.Text = "";
            tb15.Text = "";
            tb16.Text = "";
        }

        private Panel panel5;
        private Label label5;
        private ListBox lb2;
        private ComboBox comboBox1;

        public void translate(string curr, string want)
        {
            label1.Text = Program.lang.translate(label1.Text, curr, want);
            label2.Text = Program.lang.translate(label2.Text, curr, want);
            label3.Text = Program.lang.translate(label3.Text, curr, want);
            label4.Text = Program.lang.translate(label4.Text, curr, want);
            label5.Text = Program.lang.translate(label5.Text, curr, want);
            b1.Text = Program.lang.translate(b1.Text, curr, want);
            b2.Text = Program.lang.translate(b2.Text, curr, want);
            l1.Text = Program.lang.translate(l1.Text, curr, want);
            l2.Text = Program.lang.translate(l2.Text, curr, want);
            l3.Text = Program.lang.translate(l3.Text, curr, want);
            l4.Text = Program.lang.translate(l4.Text, curr, want);
            l5.Text = Program.lang.translate(l5.Text, curr, want);
            l6.Text = Program.lang.translate(l6.Text, curr, want);
            l7.Text = Program.lang.translate(l7.Text, curr, want);
            l8.Text = Program.lang.translate(l8.Text, curr, want);
            l9.Text = Program.lang.translate(l9.Text, curr, want);
            l10.Text = Program.lang.translate(l10.Text, curr, want);
            l11.Text = Program.lang.translate(l11.Text, curr, want);
            l12.Text = Program.lang.translate(l12.Text, curr, want);
            l13.Text = Program.lang.translate(l13.Text, curr, want);
            l14.Text = Program.lang.translate(l14.Text, curr, want);
            l15.Text = Program.lang.translate(l15.Text, curr, want);
            l16.Text = Program.lang.translate(l16.Text, curr, want);
        }

        public void changeTheme()
        {
            p.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel4.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel5.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            b1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            b2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            b3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            p2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            p3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            p4.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            p5.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);

            lb1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            lb2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            tb1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            tb2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            tb3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            tb4.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            comboBox1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            tb6.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            tb7.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            tb8.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            tb9.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            tb10.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            tb11.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            tb12.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            tb13.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            tb14.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            tb15.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            tb16.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);

            tb1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            tb2.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            tb3.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            tb4.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            comboBox1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            tb6.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            tb7.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            tb8.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            tb9.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            tb10.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            tb11.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            tb12.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            tb13.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            tb14.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            tb15.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            tb16.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);

            label1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label2.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
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
            l10.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            l11.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            l12.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            l13.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            l14.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            l15.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            l16.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            b1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            b2.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);

            tb1.Font = new Font(Program.theme.Font, 10);
            tb2.Font = new Font(Program.theme.Font, 10);
            tb3.Font = new Font(Program.theme.Font, 10);
            tb4.Font = new Font(Program.theme.Font, 10);
            comboBox1.Font = new Font(Program.theme.Font, 10);
            tb6.Font = new Font(Program.theme.Font, 10);
            tb7.Font = new Font(Program.theme.Font, 10);
            tb8.Font = new Font(Program.theme.Font, 10);
            tb9.Font = new Font(Program.theme.Font, 10);
            tb10.Font = new Font(Program.theme.Font, 10);
            tb11.Font = new Font(Program.theme.Font, 10);
            tb12.Font = new Font(Program.theme.Font, 10);
            tb13.Font = new Font(Program.theme.Font, 10);
            tb14.Font = new Font(Program.theme.Font, 10);
            tb15.Font = new Font(Program.theme.Font, 10);
            tb16.Font = new Font(Program.theme.Font, 10);

            l1.Font = new Font(Program.theme.Font, 11);
            l2.Font = new Font(Program.theme.Font, 11);
            l3.Font = new Font(Program.theme.Font, 11);
            l4.Font = new Font(Program.theme.Font, 11);
            l5.Font = new Font(Program.theme.Font, 11);
            l6.Font = new Font(Program.theme.Font, 11);
            l7.Font = new Font(Program.theme.Font, 11);
            l8.Font = new Font(Program.theme.Font, 11);
            l9.Font = new Font(Program.theme.Font, 11);
            l10.Font = new Font(Program.theme.Font, 11);
            l11.Font = new Font(Program.theme.Font, 11);
            l12.Font = new Font(Program.theme.Font, 11);
            l13.Font = new Font(Program.theme.Font, 11);
            l14.Font = new Font(Program.theme.Font, 11);
            l15.Font = new Font(Program.theme.Font, 11);
            l16.Font = new Font(Program.theme.Font, 11);

            label1.Font = new Font(Program.theme.Font, 12);
            label2.Font = new Font(Program.theme.Font, 12);
            label3.Font = new Font(Program.theme.Font, 12);
            label4.Font = new Font(Program.theme.Font, 12);
            label5.Font = new Font(Program.theme.Font, 12);

            b1.Font = new Font(Program.theme.Font, 14);
            b2.Font = new Font(Program.theme.Font, 14);
        }
    }
}
