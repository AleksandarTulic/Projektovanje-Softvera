using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dentil.forms.common;

namespace Dentil.forms.profile
{
    public class Settings : Common, language.Translate, theme.ChangeTheme
    {
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.TableLayoutPanel tlp;
        private System.Windows.Forms.ListBox lb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb2;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button b1;
        string type = "";
        Dentist dentistForm = null;
        Admin adminForm = null;
        Other otherForm = null;
        public Settings(Form form, string type)
        {
            if ("dentist".Equals(type))
                this.dentistForm = (Dentist)form;
            else if ("admin".Equals(type))
                this.adminForm = (Admin)form;
            else 
                this.otherForm = (Other)form;

            this.type = type;
            this.p2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cb2 = new System.Windows.Forms.ComboBox();
            this.tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.b1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.tlp = new System.Windows.Forms.TableLayoutPanel();
            this.l4 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.ListBox();
            this.p.SuspendLayout();
            this.p2.SuspendLayout();
            this.tlp.SuspendLayout();
            form.SuspendLayout();
            // 
            // p1
            // 
            this.p.BackColor = System.Drawing.Color.Indigo;
            this.p.Controls.Add(this.p2);
            this.p.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p.Location = new System.Drawing.Point(0, 0);
            this.p.MinimumSize = new System.Drawing.Size(647, 431);
            this.p.Name = "p1";
            this.p.Size = new System.Drawing.Size(647, 431);
            this.p.TabIndex = 0;
            // 
            // p2
            // 
            this.p2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p2.BackColor = System.Drawing.Color.SlateBlue;
            this.p2.Controls.Add(this.panel4);
            this.p2.Controls.Add(this.panel5);
            this.p2.Controls.Add(this.panel3);
            this.p2.Controls.Add(this.panel2);
            this.p2.Controls.Add(this.label5);
            this.p2.Controls.Add(this.cb2);
            this.p2.Controls.Add(this.tb);
            this.p2.Controls.Add(this.label4);
            this.p2.Controls.Add(this.b1);
            this.p2.Controls.Add(this.panel1);
            this.p2.Controls.Add(this.label3);
            this.p2.Controls.Add(this.label2);
            this.p2.Controls.Add(this.label1);
            this.p2.Controls.Add(this.cb1);
            this.p2.Controls.Add(this.tlp);
            this.p2.Controls.Add(this.lb);
            this.p2.Location = new System.Drawing.Point(20, 20);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(608, 394);
            this.p2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Indigo;
            this.panel4.Location = new System.Drawing.Point(214, 303);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(120, 3);
            this.panel4.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Indigo;
            this.panel5.Location = new System.Drawing.Point(429, 209);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(120, 3);
            this.panel5.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Indigo;
            this.panel3.Location = new System.Drawing.Point(214, 209);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(120, 3);
            this.panel3.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Location = new System.Drawing.Point(214, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 3);
            this.panel2.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(428, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Language";
            this.label5.MouseEnter += new System.EventHandler(this.label5_MouseEnter);
            this.label5.MouseLeave += new System.EventHandler(this.label5_MouseLeave);
            // 
            // cb2
            // 
            this.cb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb2.FormattingEnabled = true;
            this.cb2.Location = new System.Drawing.Point(428, 224);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(153, 26);
            this.cb2.TabIndex = 10;
            // 
            // tb
            // 
            this.tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb.Location = new System.Drawing.Point(214, 323);
            this.tb.Name = "tb";
            this.tb.ReadOnly = true;
            this.tb.Size = new System.Drawing.Size(164, 23);
            this.tb.TabIndex = 9;
            this.tb.Text = "the type of font you use";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(214, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Chosen Text";
            this.label4.MouseEnter += new System.EventHandler(this.label4_MouseEnter);
            this.label4.MouseLeave += new System.EventHandler(this.label4_MouseLeave);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.Indigo;
            this.b1.FlatAppearance.BorderSize = 0;
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(465, 314);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(128, 63);
            this.b1.TabIndex = 7;
            this.b1.Text = "Save";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            this.b1.MouseEnter += new System.EventHandler(this.b1_MouseEnter);
            this.b1.MouseLeave += new System.EventHandler(this.b1_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Location = new System.Drawing.Point(20, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 3);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Font";
            this.label3.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selected Color Theme";
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Color Theme";
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // cb1
            // 
            this.cb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb1.FormattingEnabled = true;
            this.cb1.Location = new System.Drawing.Point(214, 224);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(164, 26);
            this.cb1.TabIndex = 2;
            this.cb1.SelectedIndexChanged += new System.EventHandler(this.cb1_SelectedIndexChanged);
            // 
            // tlp
            // 
            this.tlp.ColumnCount = 4;
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp.Controls.Add(this.l4, 3, 0);
            this.tlp.Controls.Add(this.l1, 0, 0);
            this.tlp.Controls.Add(this.l3, 2, 0);
            this.tlp.Controls.Add(this.l2, 1, 0);
            this.tlp.Location = new System.Drawing.Point(214, 67);
            this.tlp.Name = "tlp";
            this.tlp.RowCount = 2;
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp.Size = new System.Drawing.Size(367, 100);
            this.tlp.TabIndex = 1;
            this.tlp.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tlp_CellPaint);
            // 
            // l4
            // 
            this.l4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l4.AutoSize = true;
            this.l4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l4.Location = new System.Drawing.Point(283, 16);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(73, 17);
            this.l4.TabIndex = 10;
            this.l4.Text = "Font Color";
            // 
            // l1
            // 
            this.l1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.Location = new System.Drawing.Point(3, 8);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(84, 34);
            this.l1.TabIndex = 7;
            this.l1.Text = "Background Color";
            // 
            // l3
            // 
            this.l3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l3.AutoSize = true;
            this.l3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3.Location = new System.Drawing.Point(186, 16);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(83, 17);
            this.l3.TabIndex = 9;
            this.l3.Text = "Hover Color";
            // 
            // l2
            // 
            this.l2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.Location = new System.Drawing.Point(101, 8);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(70, 34);
            this.l2.TabIndex = 8;
            this.l2.Text = "Elements Color";
            // 
            // lb
            // 
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.FormattingEnabled = true;
            this.lb.ItemHeight = 18;
            this.lb.Location = new System.Drawing.Point(20, 67);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(167, 310);
            this.lb.TabIndex = 0;
            this.lb.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Setting
            // 
            form.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            form.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            form.ClientSize = new System.Drawing.Size(647, 431);
            form.Controls.Add(this.p);
            this.p.ResumeLayout(false);
            this.p2.ResumeLayout(false);
            this.p2.PerformLayout();
            this.tlp.ResumeLayout(false);
            this.tlp.PerformLayout();
            form.ResumeLayout(false);

            fill();
            translate(Program.defaultLang, Program.lang.CurrLang);
            changeTheme();

            p.BringToFront();
        }

        public void translate(string curr, string want)
        {
            label1.Text = Program.lang.translate(label1.Text, curr, want);
            label2.Text = Program.lang.translate(label2.Text, curr, want);
            label3.Text = Program.lang.translate(label3.Text, curr, want);
            label4.Text = Program.lang.translate(label4.Text, curr, want);
            label5.Text = Program.lang.translate(label5.Text, curr, want);
            l1.Text = Program.lang.translate(l1.Text, curr, want);
            l2.Text = Program.lang.translate(l2.Text, curr, want);
            l3.Text = Program.lang.translate(l3.Text, curr, want);
            l4.Text = Program.lang.translate(l4.Text, curr, want);
            b1.Text = Program.lang.translate(b1.Text, curr, want);

            //Console.WriteLine($"{curr} - {want}");
            for (int i = 0; i < cb2.Items.Count; i++)
            {
                //Console.WriteLine(cb2.Items[i].ToString() + " " + curr + " " + want);
                cb2.Items[i] = Program.lang.translate(cb2.Items[i].ToString(), curr, want);
            }
            
            for (int i = 0; i < lb.Items.Count; i++)
                lb.Items[i] = Program.lang.translate(lb.Items[i].ToString(), curr, want);

            Program.lang.CurrLang = Program.lang.translate(want, Program.lang.CurrLang, Program.defaultLang);
        }

        public void changeTheme()
        {
            p.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel4.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel5.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            b1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);

            p2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            lb.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            tb.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            cb1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            cb2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);

            label1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label2.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label3.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label4.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label5.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            l1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            l2.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            l3.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            l4.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            b1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            cb1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            cb2.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            tb.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            tlp.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            lb.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);

            label1.Font = new Font(Program.theme.Font, 12);
            label2.Font = new Font(Program.theme.Font, 12);
            label3.Font = new Font(Program.theme.Font, 12);
            label4.Font = new Font(Program.theme.Font, 12);
            label5.Font = new Font(Program.theme.Font, 12);
            l1.Font = new Font(Program.theme.Font, 10);
            l2.Font = new Font(Program.theme.Font, 10);
            l3.Font = new Font(Program.theme.Font, 10);
            l4.Font = new Font(Program.theme.Font, 10);
            b1.Font = new Font(Program.theme.Font, 14);

            tlp.Font = new Font(Program.theme.Font, 11);
            cb1.Font = new Font(Program.theme.Font, 11);
            cb2.Font = new Font(Program.theme.Font, 11);
            tb.Font = new Font(Program.theme.Font, 10);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tlp.Refresh();
        }

        private void tlp_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (lb.SelectedIndex < 0)
                return;

            if (e.Row == 1)
            {
                List<string> arr = Program.theme.ColorThemes[lb.SelectedIndex].Arr;

                for (int i = 0; i < arr.Count; i++)
                    if (i == e.Column)
                        e.Graphics.FillRectangle((new SolidBrush(ColorTranslator.FromHtml(arr[i]))), e.CellBounds);
            }
        }

        private void b1_MouseEnter(object sender, EventArgs e)
        {
            b1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void b1_MouseLeave(object sender, EventArgs e)
        {
            b1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            panel4.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            panel5.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            panel3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
        }

        private void fill()
        {
            cb1.Items.Clear();
            cb2.Items.Clear();
            lb.Items.Clear();

            foreach (theme.ColorTheme i in Program.theme.ColorThemes)
                lb.Items.Add(i.Name);

            if (lb.Items.Count > 0)
                lb.SelectedIndex = 0;

            foreach (string i in Program.theme.Fonts)
                cb1.Items.Add(i);

            for (int i=0;i<cb1.Items.Count;i++)
                if (cb1.Items[i].Equals(Program.theme.Font))
                {
                    cb1.SelectedIndex = i;
                    break;
                }

            Program.lang.addLangItems(ref cb2);
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (cb1.SelectedIndex < 0)
                return;

            Program.theme.changeTheme(cb1.SelectedItem.ToString(), lb.SelectedIndex);
            this.changeTheme();

            if ("admin".Equals(type))
            {
                Admin.changeThemeAll();
                Admin.translateAll(Program.lang.CurrLang, Program.lang.translate(cb2.SelectedItem.ToString(), Program.lang.CurrLang, Program.defaultLang));
                adminForm.translate(Program.lang.CurrLang, Program.lang.translate(cb2.SelectedItem.ToString(), Program.lang.CurrLang, Program.defaultLang));
                adminForm.changeTheme();
            }
            else if ("dentist".Equals(type))
            {
                Dentist.changeThemeAll();
                Dentist.translateAll(Program.lang.CurrLang, Program.lang.translate(cb2.SelectedItem.ToString(), Program.lang.CurrLang, Program.defaultLang));
                dentistForm.translate(Program.lang.CurrLang, Program.lang.translate(cb2.SelectedItem.ToString(), Program.lang.CurrLang, Program.defaultLang));
                dentistForm.changeTheme();
            }
            else
            {
                Other.changeThemeAll();
                Other.translateAll(Program.lang.CurrLang, Program.lang.translate(cb2.SelectedItem.ToString(), Program.lang.CurrLang, Program.defaultLang));
                otherForm.translate(Program.lang.CurrLang, Program.lang.translate(cb2.SelectedItem.ToString(), Program.lang.CurrLang, Program.defaultLang));
                otherForm.changeTheme();
            }


            this.translate(Program.lang.CurrLang, Program.lang.translate(cb2.SelectedItem.ToString(), Program.lang.CurrLang, Program.defaultLang));
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb.Font = new Font(cb1.SelectedItem.ToString(), 10);
        }
    }
}
