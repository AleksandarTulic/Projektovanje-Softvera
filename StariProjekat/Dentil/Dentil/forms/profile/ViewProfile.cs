using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentil.forms.profile
{
    public class ViewProfile : common.Common, language.Translate, theme.ChangeTheme
    {
        private System.Windows.Forms.Panel p4;
        private System.Windows.Forms.Panel p3;
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tb10;
        private System.Windows.Forms.TextBox tb9;
        private System.Windows.Forms.TextBox tb8;
        private System.Windows.Forms.TextBox tb7;
        private System.Windows.Forms.TextBox tb6;
        private System.Windows.Forms.TextBox tb5;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label l10;
        private System.Windows.Forms.Label l9;
        private System.Windows.Forms.Label l8;
        private System.Windows.Forms.Label l7;
        private System.Windows.Forms.Label l6;
        private System.Windows.Forms.Label l5;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label l12;
        private System.Windows.Forms.Label l11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label l15;
        private System.Windows.Forms.Label l14;
        private System.Windows.Forms.Label l13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb12;
        private System.Windows.Forms.TextBox tb11;
        private System.Windows.Forms.TextBox tb15;
        private System.Windows.Forms.TextBox tb14;
        private System.Windows.Forms.TextBox tb13;

        public ViewProfile(Form form)
        {
            this.p = new System.Windows.Forms.Panel();
            this.p4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tb15 = new System.Windows.Forms.TextBox();
            this.tb14 = new System.Windows.Forms.TextBox();
            this.tb13 = new System.Windows.Forms.TextBox();
            this.l15 = new System.Windows.Forms.Label();
            this.l14 = new System.Windows.Forms.Label();
            this.l13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.p3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tb12 = new System.Windows.Forms.TextBox();
            this.tb11 = new System.Windows.Forms.TextBox();
            this.l12 = new System.Windows.Forms.Label();
            this.l11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.p2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb10 = new System.Windows.Forms.TextBox();
            this.tb9 = new System.Windows.Forms.TextBox();
            this.tb8 = new System.Windows.Forms.TextBox();
            this.tb7 = new System.Windows.Forms.TextBox();
            this.tb6 = new System.Windows.Forms.TextBox();
            this.tb5 = new System.Windows.Forms.TextBox();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.l10 = new System.Windows.Forms.Label();
            this.l9 = new System.Windows.Forms.Label();
            this.l8 = new System.Windows.Forms.Label();
            this.l7 = new System.Windows.Forms.Label();
            this.l6 = new System.Windows.Forms.Label();
            this.l5 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.p.SuspendLayout();
            this.p4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.p3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.p2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            form.SuspendLayout();
            // 
            // p1
            // 
            this.p.BackColor = System.Drawing.Color.Indigo;
            this.p.Controls.Add(this.p4);
            this.p.Controls.Add(this.p3);
            this.p.Controls.Add(this.p2);
            this.p.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p.Location = new System.Drawing.Point(0, 0);
            this.p.Name = "p1";
            this.p.Size = new System.Drawing.Size(690, 423);
            this.p.TabIndex = 0;
            // 
            // p4
            // 
            this.p4.BackColor = System.Drawing.Color.SlateBlue;
            this.p4.Controls.Add(this.tableLayoutPanel3);
            this.p4.Controls.Add(this.panel3);
            this.p4.Controls.Add(this.label3);
            this.p4.Location = new System.Drawing.Point(395, 216);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(273, 190);
            this.p4.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tb15, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.tb14, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.tb13, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.l15, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.l14, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.l13, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(20, 70);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(236, 90);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // tb15
            // 
            this.tb15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb15.Location = new System.Drawing.Point(122, 63);
            this.tb15.Name = "tb15";
            this.tb15.ReadOnly = true;
            this.tb15.Size = new System.Drawing.Size(110, 23);
            this.tb15.TabIndex = 6;
            // 
            // tb14
            // 
            this.tb14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb14.Location = new System.Drawing.Point(122, 33);
            this.tb14.Name = "tb14";
            this.tb14.ReadOnly = true;
            this.tb14.Size = new System.Drawing.Size(110, 23);
            this.tb14.TabIndex = 6;
            // 
            // tb13
            // 
            this.tb13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb13.Location = new System.Drawing.Point(122, 3);
            this.tb13.Name = "tb13";
            this.tb13.ReadOnly = true;
            this.tb13.Size = new System.Drawing.Size(110, 23);
            this.tb13.TabIndex = 6;
            // 
            // l15
            // 
            this.l15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l15.AutoSize = true;
            this.l15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l15.Location = new System.Drawing.Point(40, 65);
            this.l15.Name = "l15";
            this.l15.Size = new System.Drawing.Size(38, 20);
            this.l15.TabIndex = 5;
            this.l15.Text = "Title";
            // 
            // l14
            // 
            this.l14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l14.AutoSize = true;
            this.l14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l14.Location = new System.Drawing.Point(4, 36);
            this.l14.Name = "l14";
            this.l14.Size = new System.Drawing.Size(110, 17);
            this.l14.TabIndex = 5;
            this.l14.Text = "Education Place";
            // 
            // l13
            // 
            this.l13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l13.AutoSize = true;
            this.l13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l13.Location = new System.Drawing.Point(22, 5);
            this.l13.Name = "l13";
            this.l13.Size = new System.Drawing.Size(74, 20);
            this.l13.TabIndex = 5;
            this.l13.Text = "Job Start";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Indigo;
            this.panel3.Location = new System.Drawing.Point(20, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 3);
            this.panel3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Other info";
            this.label3.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            // 
            // p3
            // 
            this.p3.BackColor = System.Drawing.Color.SlateBlue;
            this.p3.Controls.Add(this.tableLayoutPanel2);
            this.p3.Controls.Add(this.panel2);
            this.p3.Controls.Add(this.label2);
            this.p3.Location = new System.Drawing.Point(395, 20);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(273, 176);
            this.p3.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tb12, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tb11, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.l12, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.l11, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(20, 67);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(236, 80);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // tb12
            // 
            this.tb12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb12.Location = new System.Drawing.Point(122, 48);
            this.tb12.Name = "tb12";
            this.tb12.ReadOnly = true;
            this.tb12.Size = new System.Drawing.Size(110, 23);
            this.tb12.TabIndex = 4;
            // 
            // tb11
            // 
            this.tb11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb11.Location = new System.Drawing.Point(122, 8);
            this.tb11.Name = "tb11";
            this.tb11.ReadOnly = true;
            this.tb11.Size = new System.Drawing.Size(110, 23);
            this.tb11.TabIndex = 4;
            // 
            // l12
            // 
            this.l12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l12.AutoSize = true;
            this.l12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l12.Location = new System.Drawing.Point(4, 50);
            this.l12.Name = "l12";
            this.l12.Size = new System.Drawing.Size(109, 20);
            this.l12.TabIndex = 5;
            this.l12.Text = "Bank Account";
            // 
            // l11
            // 
            this.l11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l11.AutoSize = true;
            this.l11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l11.Location = new System.Drawing.Point(36, 10);
            this.l11.Name = "l11";
            this.l11.Size = new System.Drawing.Size(46, 20);
            this.l11.TabIndex = 5;
            this.l11.Text = "Bank";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Location = new System.Drawing.Point(20, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 3);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bank Information";
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.Color.SlateBlue;
            this.p2.Controls.Add(this.tableLayoutPanel1);
            this.p2.Controls.Add(this.panel1);
            this.p2.Controls.Add(this.label1);
            this.p2.Location = new System.Drawing.Point(20, 20);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(359, 386);
            this.p2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.tb10, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.tb9, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.tb8, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.tb7, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.tb6, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tb5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tb4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.l10, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.l9, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.l8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.l7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.l6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.l5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.l4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.l3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.l2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.l1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 61);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(319, 300);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tb10
            // 
            this.tb10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb10.Location = new System.Drawing.Point(133, 273);
            this.tb10.Name = "tb10";
            this.tb10.ReadOnly = true;
            this.tb10.Size = new System.Drawing.Size(180, 23);
            this.tb10.TabIndex = 4;
            // 
            // tb9
            // 
            this.tb9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb9.Location = new System.Drawing.Point(133, 243);
            this.tb9.Name = "tb9";
            this.tb9.ReadOnly = true;
            this.tb9.Size = new System.Drawing.Size(180, 23);
            this.tb9.TabIndex = 4;
            // 
            // tb8
            // 
            this.tb8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb8.Location = new System.Drawing.Point(133, 213);
            this.tb8.Name = "tb8";
            this.tb8.ReadOnly = true;
            this.tb8.Size = new System.Drawing.Size(180, 23);
            this.tb8.TabIndex = 4;
            // 
            // tb7
            // 
            this.tb7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb7.Location = new System.Drawing.Point(133, 183);
            this.tb7.Name = "tb7";
            this.tb7.ReadOnly = true;
            this.tb7.Size = new System.Drawing.Size(180, 23);
            this.tb7.TabIndex = 4;
            // 
            // tb6
            // 
            this.tb6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb6.Location = new System.Drawing.Point(133, 153);
            this.tb6.Name = "tb6";
            this.tb6.ReadOnly = true;
            this.tb6.Size = new System.Drawing.Size(180, 23);
            this.tb6.TabIndex = 4;
            // 
            // tb5
            // 
            this.tb5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb5.Location = new System.Drawing.Point(133, 123);
            this.tb5.Name = "tb5";
            this.tb5.ReadOnly = true;
            this.tb5.Size = new System.Drawing.Size(180, 23);
            this.tb5.TabIndex = 4;
            // 
            // tb4
            // 
            this.tb4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb4.Location = new System.Drawing.Point(133, 93);
            this.tb4.Name = "tb4";
            this.tb4.ReadOnly = true;
            this.tb4.Size = new System.Drawing.Size(180, 23);
            this.tb4.TabIndex = 5;
            // 
            // tb3
            // 
            this.tb3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb3.Location = new System.Drawing.Point(133, 63);
            this.tb3.Name = "tb3";
            this.tb3.ReadOnly = true;
            this.tb3.Size = new System.Drawing.Size(180, 23);
            this.tb3.TabIndex = 4;
            // 
            // tb2
            // 
            this.tb2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb2.Location = new System.Drawing.Point(133, 33);
            this.tb2.Name = "tb2";
            this.tb2.ReadOnly = true;
            this.tb2.Size = new System.Drawing.Size(180, 23);
            this.tb2.TabIndex = 4;
            // 
            // tb1
            // 
            this.tb1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb1.Location = new System.Drawing.Point(133, 3);
            this.tb1.Name = "tb1";
            this.tb1.ReadOnly = true;
            this.tb1.Size = new System.Drawing.Size(180, 23);
            this.tb1.TabIndex = 3;
            // 
            // l10
            // 
            this.l10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l10.AutoSize = true;
            this.l10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l10.Location = new System.Drawing.Point(32, 275);
            this.l10.Name = "l10";
            this.l10.Size = new System.Drawing.Size(63, 20);
            this.l10.TabIndex = 4;
            this.l10.Text = "Gender";
            // 
            // l9
            // 
            this.l9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l9.AutoSize = true;
            this.l9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l9.Location = new System.Drawing.Point(7, 245);
            this.l9.Name = "l9";
            this.l9.Size = new System.Drawing.Size(113, 20);
            this.l9.TabIndex = 4;
            this.l9.Text = "Street Number";
            // 
            // l8
            // 
            this.l8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l8.AutoSize = true;
            this.l8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l8.Location = new System.Drawing.Point(37, 215);
            this.l8.Name = "l8";
            this.l8.Size = new System.Drawing.Size(53, 20);
            this.l8.TabIndex = 4;
            this.l8.Text = "Street";
            // 
            // l7
            // 
            this.l7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l7.AutoSize = true;
            this.l7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l7.Location = new System.Drawing.Point(46, 185);
            this.l7.Name = "l7";
            this.l7.Size = new System.Drawing.Size(35, 20);
            this.l7.TabIndex = 4;
            this.l7.Text = "City";
            // 
            // l6
            // 
            this.l6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l6.AutoSize = true;
            this.l6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l6.Location = new System.Drawing.Point(36, 155);
            this.l6.Name = "l6";
            this.l6.Size = new System.Drawing.Size(55, 20);
            this.l6.TabIndex = 4;
            this.l6.Text = "Phone";
            // 
            // l5
            // 
            this.l5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l5.AutoSize = true;
            this.l5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l5.Location = new System.Drawing.Point(39, 125);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(48, 20);
            this.l5.TabIndex = 4;
            this.l5.Text = "Email";
            // 
            // l4
            // 
            this.l4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l4.AutoSize = true;
            this.l4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l4.Location = new System.Drawing.Point(22, 95);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(83, 20);
            this.l4.TabIndex = 4;
            this.l4.Text = "Username";
            // 
            // l3
            // 
            this.l3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l3.AutoSize = true;
            this.l3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3.Location = new System.Drawing.Point(26, 65);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(74, 20);
            this.l3.TabIndex = 4;
            this.l3.Text = "Surname";
            // 
            // l2
            // 
            this.l2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.Location = new System.Drawing.Point(38, 35);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(51, 20);
            this.l2.TabIndex = 4;
            this.l2.Text = "Name";
            // 
            // l1
            // 
            this.l1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.Location = new System.Drawing.Point(50, 5);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(26, 20);
            this.l1.TabIndex = 4;
            this.l1.Text = "ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Location = new System.Drawing.Point(20, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 3);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Main Info";
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // Form1
            // 

            this.p2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p4.Anchor = System.Windows.Forms.AnchorStyles.None;
            form.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            form.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            form.ClientSize = new System.Drawing.Size(690, 423);
            form.Controls.Add(p);
            this.p.ResumeLayout(false);
            this.p4.ResumeLayout(false);
            this.p4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.p3.ResumeLayout(false);
            this.p3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.p2.ResumeLayout(false);
            this.p2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            form.ResumeLayout(false);

            fill();
            translate(Program.defaultLang, Program.lang.CurrLang);
            changeTheme();

            p.BringToFront();
        }

        public void changeTheme()
        {
            p.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            p2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            p3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            p4.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            tb1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            tb2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            tb3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            tb4.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            tb5.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
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

            l1.Font = new Font(Program.theme.Font, 12);
            l2.Font = new Font(Program.theme.Font, 12);
            l3.Font = new Font(Program.theme.Font, 12);
            l4.Font = new Font(Program.theme.Font, 12);
            l5.Font = new Font(Program.theme.Font, 12);
            l6.Font = new Font(Program.theme.Font, 12);
            l7.Font = new Font(Program.theme.Font, 12);
            l8.Font = new Font(Program.theme.Font, 12);
            l9.Font = new Font(Program.theme.Font, 12);
            l10.Font = new Font(Program.theme.Font, 12);
            l11.Font = new Font(Program.theme.Font, 12);
            l12.Font = new Font(Program.theme.Font, 12);
            l13.Font = new Font(Program.theme.Font, 12);
            l14.Font = new Font(Program.theme.Font, 12);
            l15.Font = new Font(Program.theme.Font, 12);
            label1.Font = new Font(Program.theme.Font, 12);
            label2.Font = new Font(Program.theme.Font, 12);
            label3.Font = new Font(Program.theme.Font, 12);

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
            label1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label2.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label3.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            tb1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            tb2.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            tb3.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            tb4.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            tb5.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
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
        }

        public void translate(string curr, string want)
        {
            label1.Text = Program.lang.translate(label1.Text, curr, want);
            label2.Text = Program.lang.translate(label2.Text, curr, want);
            label3.Text = Program.lang.translate(label3.Text, curr, want);
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

        public void fill()
        {
            List<List<string>> getSpecific = dbManagement.Query.query(dbManagement.Query.allUserSpecificInfo);
            user.SpecificUser su = null;

            foreach (List<string> i in getSpecific)
            {
                if (i[0].Equals(Program.user.Id))
                {
                    su = new user.SpecificUser(i);
                    break;
                }
            }

            tb1.Text = Program.user.Id;
            tb2.Text = Program.user.Name;
            tb3.Text = Program.user.Surname;
            tb4.Text = "0".Equals(Program.user.UserName) ? "" : Program.user.UserName;
            tb5.Text = "0".Equals(Program.user.Email) ? "" : Program.user.Email;
            tb6.Text = "0".Equals(Program.user.Phone) ? "" : Program.user.Phone;
            tb7.Text = "0".Equals(Program.user.City) ? "" : Program.user.City;
            tb8.Text = "0".Equals(Program.user.Street) ? "" : $"{Program.user.Street}";
            tb9.Text = "0".Equals(Program.user.StreetNum) ? "" : $"{Program.user.StreetNum}";
            tb10.Text = "0".Equals(Program.user.Gender) ? "" : $"{Program.user.Gender}";
            tb11.Text = "0".Equals(Program.user.Bank) ? "" : Program.user.Bank;
            tb12.Text = "0".Equals(Program.user.NumAccount) ? "" : Program.user.NumAccount;

            if (su != null)
            {
                tb13.Text = "0".Equals(su.DateBegin.ToString()) ? "" : $"{su.DateBegin}";
                tb14.Text = "0".Equals(su.EducationPlace) ? "" : $"{su.EducationPlace}";
                tb15.Text = "0".Equals(su.Title) ? "" : $"{su.Title}";
            }
        }
    }
}
