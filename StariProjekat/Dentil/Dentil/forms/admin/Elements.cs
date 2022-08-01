using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentil.forms.admin
{
    public class Elements : common.Common, language.Translate, theme.ChangeTheme
    {
        const string selectAll = "select * from ItemAndServices;";
        private Button b3;
        private Button b2;
        private Button b1;
        private Panel p2;
        private Label l3;
        private Label l2;
        private Label l1;
        private TextBox textBox1;
        private PictureBox pb;
        private ListBox clb;
        private Panel panel2;
        private CheckBox checkBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;

        List <int> flagCheckBox = new List<int> ();
        List<elements.Elements> arr = new List<elements.Elements>();
        public Elements(Form form)
        {
            this.p = new System.Windows.Forms.Panel();
            this.p2 = new System.Windows.Forms.Panel();
            this.clb = new System.Windows.Forms.ListBox();
            this.pb = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.p.SuspendLayout();
            this.p2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.panel2.SuspendLayout();

            // 
            // panel1
            // 
            this.p.AutoScroll = true;
            this.p.BackColor = System.Drawing.Color.Indigo;
            this.p.Controls.Add(this.b3);
            this.p.Controls.Add(this.panel2);
            this.p.Controls.Add(this.b2);
            this.p.Controls.Add(this.b1);
            this.p.Controls.Add(this.p2);
            this.p.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            this.p.Location = new System.Drawing.Point(10, 39); 
            this.p.MinimumSize = new System.Drawing.Size(800, 473);
            this.p.Name = "panel1";
            this.p.Size = new System.Drawing.Size(1057, 473);
            this.p.TabIndex = 2;
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.Color.SlateBlue;
            this.p2.Controls.Add(this.panel5);
            this.p2.Controls.Add(this.panel4);
            this.p2.Controls.Add(this.panel3);
            this.p2.Controls.Add(this.checkBox1);
            this.p2.Controls.Add(this.label3);
            this.p2.Controls.Add(this.label2);
            this.p2.Controls.Add(this.label1);
            this.p2.Controls.Add(this.textBox3);
            this.p2.Controls.Add(this.textBox2);
            this.p2.Controls.Add(this.l3);
            this.p2.Controls.Add(this.l1);
            this.p2.Controls.Add(this.textBox1);
            this.p2.Controls.Add(this.clb);
            this.p2.Location = new System.Drawing.Point(12, 12);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(521, 444);
            this.p2.TabIndex = 0;
            // 
            // clb
            // 
            this.clb.BackColor = System.Drawing.Color.White;
            this.clb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb.FormattingEnabled = true;
            this.clb.Items.AddRange(new object[] {
            "item1,item2;",
            "item3,item4"});
            this.clb.Location = new System.Drawing.Point(14, 84);
            this.clb.Name = "clb";
            this.clb.ScrollAlwaysVisible = true;
            clb.HorizontalScrollbar = true;
            this.clb.Size = new System.Drawing.Size(250, 340);
            this.clb.TabIndex = 0;
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(20, 99);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(265, 200);
            this.pb.TabIndex = 1;
            this.pb.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(291, 275);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = (ScrollBars.Vertical);
            this.textBox1.Size = new System.Drawing.Size(212, 150);
            this.textBox1.TabIndex = 4;
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.Location = new System.Drawing.Point(14, 44);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(144, 20);
            this.l1.TabIndex = 3;
            this.l1.Text = "Items and Services";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.Location = new System.Drawing.Point(20, 59);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(58, 20);
            this.l2.TabIndex = 4;
            this.l2.Text = "Picture";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3.Location = new System.Drawing.Point(291, 235);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(89, 20);
            this.l3.TabIndex = 5;
            this.l3.Text = "Description";
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.SlateBlue;
            this.b1.FlatAppearance.BorderSize = 0;
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(554, 357);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(110, 105);
            this.b1.TabIndex = 0;
            this.b1.Text = "Input";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            this.b1.MouseEnter += new System.EventHandler(this.b1_MouseEnter);
            this.b1.MouseLeave += new System.EventHandler(this.b1_MouseLeave);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.SlateBlue;
            this.b2.FlatAppearance.BorderSize = 0;
            this.b2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(674, 357);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(110, 105);
            this.b2.TabIndex = 1;
            this.b2.Text = "Modify";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            this.b2.MouseEnter += new System.EventHandler(this.b2_MouseEnter);
            this.b2.MouseLeave += new System.EventHandler(this.b2_MouseLeave);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.SlateBlue;
            this.b3.FlatAppearance.BorderSize = 0;
            this.b3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(794, 357);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(110, 105);
            this.b3.TabIndex = 2;
            this.b3.Text = "Delete";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            this.b3.MouseEnter += new System.EventHandler(this.b3_MouseEnter);
            this.b3.MouseLeave += new System.EventHandler(this.b3_MouseLeave);

            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateBlue;
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.l2);
            this.panel2.Controls.Add(this.pb);
            this.panel2.Location = new System.Drawing.Point(559, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 317);
            this.panel2.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(355, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(355, 145);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(148, 20);
            this.textBox3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(291, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Search";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(317, 196);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(176, 22);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Select More Than One";
            this.checkBox1.UseVisualStyleBackColor = true;
            checkBox1.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Indigo;
            this.panel3.Location = new System.Drawing.Point(14, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 3);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Indigo;
            this.panel4.Location = new System.Drawing.Point(295, 67);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(120, 3);
            this.panel4.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Indigo;
            this.panel5.Location = new System.Drawing.Point(295, 258);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(120, 3);
            this.panel5.TabIndex = 14;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Indigo;
            this.panel6.Location = new System.Drawing.Point(20, 82);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(120, 3);
            this.panel6.TabIndex = 15;

            form.Controls.Add(p);

            this.p.ResumeLayout(false);
            this.p.PerformLayout();
            this.p2.ResumeLayout(false);
            this.p2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();

            clb.SelectedIndexChanged += new EventHandler(this.clb_SelectedIndexChanged);
            p.BringToFront();

            fill();
            translate(Program.defaultLang, Program.lang.CurrLang);

            p2.Anchor = AnchorStyles.None;
            panel2.Anchor = AnchorStyles.None;
            b1.Anchor = AnchorStyles.None;
            b2.Anchor = AnchorStyles.None;
            b3.Anchor = AnchorStyles.None;

            l1.MouseEnter += new EventHandler(this.Panel3_MouseEnter);
            l1.MouseLeave += new EventHandler(this.Panel3_MouseLeave);
            label3.MouseEnter += new EventHandler(this.Panel4_MouseEnter);
            label3.MouseLeave += new EventHandler(this.Panel4_MouseLeave);
            l3.MouseEnter += new EventHandler(this.Panel5_MouseEnter);
            l3.MouseLeave += new EventHandler(this.Panel5_MouseLeave);
            l2.MouseEnter += new EventHandler(this.Panel6_MouseEnter);
            l2.MouseLeave += new EventHandler(this.Panel6_MouseLeave);

            changeTheme();
            
        }

        private void Panel3_MouseEnter(object sender, EventArgs e)
        {
            panel3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void Panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
        }

        private void Panel4_MouseEnter(object sender, EventArgs e)
        {
            panel4.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void Panel4_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
        }

        private void Panel5_MouseEnter(object sender, EventArgs e)
        {
            panel5.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void Panel5_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
        }

        private void Panel6_MouseEnter(object sender, EventArgs e)
        {
            panel6.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void Panel6_MouseLeave(object sender, EventArgs e)
        {
            panel6.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
        }

        private void clb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clb.SelectedIndex>=0)
            {
                if (File.Exists(arr[clb.SelectedIndex].Path))
                {
                    pb.Visible = true;
                    pb.Image = Image.FromFile(arr[clb.SelectedIndex].Path);
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                    pb.Visible = false;

                textBox1.Text = "0".Equals(arr[clb.SelectedIndex].Description) ? "" : arr[clb.SelectedIndex].Description;
            }
        }

        private void fill()
        {
            List<List<string>> buffer = dbManagement.Query.query(selectAll);
            arr.Clear();
            flagCheckBox.Clear();

            foreach (List<string> i in buffer)
            {
                arr.Add(new elements.Elements(i));
            }

            clb.Items.Clear();

            foreach (elements.Elements i in arr)
                clb.Items.Add(i.ToString());
        }

        public void changeTheme()
        {
            p.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel4.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel5.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            panel6.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            
            b1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            b2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            b3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            panel2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            p2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            clb.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            textBox1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            textBox2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            textBox3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);

            b1.Font = new Font(Program.theme.Font, 14);
            b2.Font = new Font(Program.theme.Font, 14);
            b3.Font = new Font(Program.theme.Font, 14);
            l3.Font = new Font(Program.theme.Font, 12);
            l2.Font = new Font(Program.theme.Font, 12);
            l1.Font = new Font(Program.theme.Font, 12);
            label3.Font = new Font(Program.theme.Font, 12);
            label2.Font = new Font(Program.theme.Font, 11);
            label1.Font = new Font(Program.theme.Font, 11);
            checkBox1.Font = new Font(Program.theme.Font, 11);
            textBox3.Font = new Font(Program.theme.Font, 10);
            textBox2.Font = new Font(Program.theme.Font, 10);
            textBox1.Font = new Font(Program.theme.Font, 10);
            clb.Font = new Font(Program.theme.Font, 10);

            b1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            b2.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            b3.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            l3.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            l2.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            l1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label2.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label3.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            checkBox1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            textBox1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            textBox2.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            textBox3.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            clb.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);

        }

        public void translate(string curr, string want)
        {
            label1.Text = Program.lang.translate(label1.Text, curr, want);
            label2.Text = Program.lang.translate(label2.Text, curr, want);
            label3.Text = Program.lang.translate(label3.Text, curr, want);
            l1.Text = Program.lang.translate(l1.Text, curr, want);
            l2.Text = Program.lang.translate(l2.Text, curr, want);
            l3.Text = Program.lang.translate(l3.Text, curr, want);
            checkBox1.Text = Program.lang.translate(checkBox1.Text, curr, want);
            b1.Text = Program.lang.translate(b1.Text, curr, want);
            b2.Text = Program.lang.translate(b2.Text, curr, want);
            b3.Text = Program.lang.translate(b3.Text, curr, want);
            
        }

        //DELETE
        private void b3_Click(object sender, EventArgs e)
        {
            if (clb.SelectedIndex < 0)
                MessageBox.Show(Program.lang.translate("Operation not possible", Program.defaultLang, Program.lang.CurrLang),
                    Program.lang.translate("Delete Element", Program.defaultLang, Program.lang.CurrLang), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                int num = 0;
                if (dbManagement.Delete.deleteElement(arr[clb.SelectedIndex].Id))
                        num++;

                Console.WriteLine(flagCheckBox.Count);
                if (num > 0)
                    MessageBox.Show(Program.lang.translate("Operation successful", Program.defaultLang, Program.lang.CurrLang), 
                        Program.lang.translate("Delete successful", Program.defaultLang, Program.lang.CurrLang), MessageBoxButtons.OK, MessageBoxIcon.Information);

                fill();
            }
        }

        //MODIFY
        private void b2_Click(object sender, EventArgs e)
        {
            if (clb.SelectedIndex >= 0)
            {
                ElementsInput ei = new ElementsInput(arr[clb.SelectedIndex], false);
                ei.ShowDialog();
                fill();
            }else
                MessageBox.Show(Program.lang.translate("Operation not possible", Program.defaultLang, Program.lang.CurrLang),
                    Program.lang.translate("Modify Element", Program.defaultLang, Program.lang.CurrLang), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        //INSERT
        private void b1_Click(object sender, EventArgs e)
        {
            ElementsInput ei = new ElementsInput(null, true);
            ei.ShowDialog();
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

        private void b2_MouseEnter(object sender, EventArgs e)
        {
            b2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void b2_MouseLeave(object sender, EventArgs e)
        {
            b2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
        }

        private void b3_MouseEnter(object sender, EventArgs e)
        {
            b3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void b3_MouseLeave(object sender, EventArgs e)
        {
            b3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
        }
    }
}
