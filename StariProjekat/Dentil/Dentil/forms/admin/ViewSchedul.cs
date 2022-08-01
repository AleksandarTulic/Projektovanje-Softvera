using Dentil.forms.common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentil.forms.admin
{
    public class ViewSchedul : Common, language.Translate, theme.ChangeTheme
    {
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Panel p3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ListBox lb3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.ListBox lb2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pa3;
        private System.Windows.Forms.Panel pa2;
        private System.Windows.Forms.Panel pa1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Panel pa4;
        private System.Windows.Forms.Label label4;
        List <user.User> users = new List <user.User> ();

        public ViewSchedul(Form form)
        {
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.p3 = new System.Windows.Forms.Panel();
            this.pa4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.pa3 = new System.Windows.Forms.Panel();
            this.lb3 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.p2 = new System.Windows.Forms.Panel();
            this.pa2 = new System.Windows.Forms.Panel();
            this.pa1 = new System.Windows.Forms.Panel();
            this.lb1 = new System.Windows.Forms.ListBox();
            this.lb2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.p.SuspendLayout();
            this.p3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.p2.SuspendLayout();
            // 
            // p1
            // 
            this.p.BackColor = System.Drawing.Color.Indigo;
            this.p.Controls.Add(this.b2);
            this.p.Controls.Add(this.b1);
            this.p.Controls.Add(this.p3);
            this.p.Controls.Add(this.p2);
            this.p.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p.Location = new System.Drawing.Point(0, 0);
            this.p.Name = "p1";
            this.p.Size = new System.Drawing.Size(800, 450);
            this.p.TabIndex = 0;
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.SlateBlue;
            this.b2.FlatAppearance.BorderSize = 0;
            this.b2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(644, 347);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(128, 82);
            this.b2.TabIndex = 8;
            this.b2.Text = "Input";
            this.b2.UseVisualStyleBackColor = false;
            // 
            // b1
            // 
            this.b1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b1.BackColor = System.Drawing.Color.SlateBlue;
            this.b1.FlatAppearance.BorderSize = 0;
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(496, 347);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(128, 82);
            this.b1.TabIndex = 7;
            this.b1.Text = "Delete";
            this.b1.UseVisualStyleBackColor = false;
            // 
            // p3
            // 
            this.p3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p3.BackColor = System.Drawing.Color.SlateBlue;
            this.p3.Controls.Add(this.pa4);
            this.p3.Controls.Add(this.label4);
            this.p3.Controls.Add(this.tableLayoutPanel1);
            this.p3.Controls.Add(this.pa3);
            this.p3.Controls.Add(this.lb3);
            this.p3.Controls.Add(this.label3);
            this.p3.Location = new System.Drawing.Point(496, 20);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(276, 300);
            this.p3.TabIndex = 4;
            // 
            // pa4
            // 
            this.pa4.BackColor = System.Drawing.Color.Indigo;
            this.pa4.Location = new System.Drawing.Point(20, 191);
            this.pa4.Name = "pa4";
            this.pa4.Size = new System.Drawing.Size(120, 3);
            this.pa4.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Admin";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox5, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 211);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(235, 72);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Surname";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(126, 6);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox5.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Name";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(126, 42);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 23);
            this.textBox5.TabIndex = 11;
            // 
            // pa3
            // 
            this.pa3.BackColor = System.Drawing.Color.Indigo;
            this.pa3.Location = new System.Drawing.Point(20, 43);
            this.pa3.Name = "pa3";
            this.pa3.Size = new System.Drawing.Size(120, 3);
            this.pa3.TabIndex = 10;
            // 
            // lb3
            // 
            this.lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3.FormattingEnabled = true;
            this.lb3.ItemHeight = 18;
            this.lb3.Location = new System.Drawing.Point(20, 58);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(235, 94);
            this.lb3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Shift";
            // 
            // p2
            // 
            this.p2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p2.BackColor = System.Drawing.Color.SlateBlue;
            this.p2.Controls.Add(this.pa2);
            this.p2.Controls.Add(this.pa1);
            this.p2.Controls.Add(this.lb1);
            this.p2.Controls.Add(this.lb2);
            this.p2.Controls.Add(this.label1);
            this.p2.Controls.Add(this.label2);
            this.p2.Location = new System.Drawing.Point(20, 20);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(446, 409);
            this.p2.TabIndex = 0;
            // 
            // pa2
            // 
            this.pa2.BackColor = System.Drawing.Color.Indigo;
            this.pa2.Location = new System.Drawing.Point(289, 43);
            this.pa2.Name = "pa2";
            this.pa2.Size = new System.Drawing.Size(120, 3);
            this.pa2.TabIndex = 10;
            // 
            // pa1
            // 
            this.pa1.BackColor = System.Drawing.Color.Indigo;
            this.pa1.Location = new System.Drawing.Point(20, 43);
            this.pa1.Name = "pa1";
            this.pa1.Size = new System.Drawing.Size(120, 3);
            this.pa1.TabIndex = 9;
            // 
            // lb1
            // 
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.FormattingEnabled = true;
            this.lb1.HorizontalScrollbar = true;
            this.lb1.ItemHeight = 18;
            this.lb1.Location = new System.Drawing.Point(20, 58);
            this.lb1.Name = "lb1";
            this.lb1.ScrollAlwaysVisible = true;
            this.lb1.Size = new System.Drawing.Size(251, 328);
            this.lb1.TabIndex = 1;
            // 
            // lb2
            // 
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.FormattingEnabled = true;
            this.lb2.ItemHeight = 18;
            this.lb2.Location = new System.Drawing.Point(289, 58);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(133, 328);
            this.lb2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Working Staff";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(289, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dates";

            form.Controls.Add(this.p);

            this.p.ResumeLayout(false);
            this.p3.ResumeLayout(false);
            this.p3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.p2.ResumeLayout(false);
            this.p2.PerformLayout();

            fill();
            translate(Program.defaultLang, Program.lang.CurrLang);
            changeTheme();

            lb1.SelectedIndexChanged += new EventHandler(lb1_SelectedIndexChanged);
            lb2.SelectedIndexChanged += new EventHandler(lb2_SelectedIndexChanged);
            lb3.SelectedIndexChanged += new EventHandler(lb3_SelectedIndexChanged);
            label1.MouseEnter += new EventHandler(label1_MouseEnter);
            label1.MouseLeave += new EventHandler(label1_MouseLeave);

            label2.MouseEnter += new EventHandler(label2_MouseEnter);
            label2.MouseLeave += new EventHandler(label2_MouseLeave);

            label3.MouseEnter += new EventHandler(label3_MouseEnter);
            label3.MouseLeave += new EventHandler(label3_MouseLeave);

            label4.MouseEnter += new EventHandler(label4_MouseEnter);
            label4.MouseLeave += new EventHandler(label4_MouseLeave);

            b1.MouseEnter += new EventHandler(b1_MouseEnter);
            b1.MouseLeave += new EventHandler(b1_MouseLeave);

            b2.MouseEnter += new EventHandler(b2_MouseEnter);
            b2.MouseLeave += new EventHandler(b2_MouseLeave);
            b1.Click += new EventHandler(b1_Click);
            b2.Click += new EventHandler(b2_Click);
            p.BringToFront();
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

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            pa1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            pa1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            pa2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            pa2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            pa3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            pa3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            pa4.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            pa4.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
        }

        private void b1_Click(object sender , EventArgs e)
        {
            if (lb1.SelectedIndex < 0 || lb2.SelectedIndex < 0 || lb3.SelectedIndex < 0)
            {
                MessageBox.Show(Program.lang.translate("Operation not possible", Program.defaultLang, Program.lang.CurrLang), Program.lang.translate("Delete Schedule", Program.defaultLang, Program.lang.CurrLang)
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] sp = lb3.SelectedItem.ToString().Split(' ');
            bool flag = dbManagement.Delete.deleteSchedule(users[lb1.SelectedIndex].Id, sp[1],lb2.SelectedItem.ToString());
        
            if (flag)
                MessageBox.Show(Program.lang.translate("Operation successful", Program.defaultLang, Program.lang.CurrLang), Program.lang.translate("Delete Schedule", Program.defaultLang, Program.lang.CurrLang)
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(Program.lang.translate("Operation not successful", Program.defaultLang, Program.lang.CurrLang), Program.lang.translate("Delete Schedule", Program.defaultLang, Program.lang.CurrLang)
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);

            fill();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            ScheduleInput si = new ScheduleInput();
            si.ShowDialog();
            fill();
        }

        private void lb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb1.SelectedIndex < 0)
                return;

            fillDates(users[lb1.SelectedIndex].Id);
        }

        private void lb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb2.SelectedIndex < 0)
                return;

            fillShifts(users[lb1.SelectedIndex].Id, lb2.SelectedItem.ToString());
        }

        private void lb3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb3.SelectedIndex < 0)
                return;

            try 
            {
                string[] sp = lb3.SelectedItem.ToString().Split(' ');

                List<string> arr = dbManagement.Query.getShiftAdmin(users[lb1.SelectedIndex].Id, sp[1], lb2.SelectedItem.ToString());

                textBox4.Text = arr[0];
                textBox5.Text = arr[1];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
            }
        }

        private void fill()
        {
            fillPersonal();
        }

        private void fillShifts(string id, string date)
        {
            textBox4.Text = "";
            textBox5.Text = "";
            lb3.Items.Clear();

            List<string> arrShift = dbManagement.Query.getUserScheduleDateShifts(id, date);

            foreach (string i in arrShift)
                lb3.Items.Add(i);

            if (arrShift.Count > 0)
                lb3.SelectedIndex = 0;
        }

        private void fillDates(string id)
        {
            textBox4.Text = "";
            textBox5.Text = "";
            lb2.Items.Clear();
            lb3.Items.Clear();

            List<elements.helpElements.Date> arrDate = dbManagement.Query.getUserScheduleDates(id);
            
            foreach(elements.helpElements.Date i in arrDate)
                lb2.Items.Add(i.ToString());

            if (arrDate.Count > 0)
                lb2.SelectedIndex = 0;
        }

        private void fillPersonal()
        {
            textBox4.Text = "";
            textBox5.Text = "";
            users.Clear();
            lb1.Items.Clear();
            List<List<string>> arr = dbManagement.Query.query(dbManagement.Query.allPersonal);

            for (int i = 0; i < arr.Count; i++)
            {
                users.Add(dbManagement.Query.getUser(arr[i][0]));
                lb1.Items.Add(users[users.Count - 1].Name + " " + users[users.Count - 1].Surname);
            }

            if (users.Count > 0)
                lb1.SelectedIndex = 0;
        }

        public void changeTheme()
        {
            lb1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            lb2.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            lb3.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            b1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            b2.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label1.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label2.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label3.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label4.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label5.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            label6.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            textBox4.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);
            textBox5.ForeColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[3]);

            lb1.Font = new Font(Program.theme.Font, 11);
            lb2.Font = new Font(Program.theme.Font, 11);
            lb3.Font = new Font(Program.theme.Font, 11);
            label1.Font = new Font(Program.theme.Font, 12);
            label2.Font = new Font(Program.theme.Font, 12);
            label3.Font = new Font(Program.theme.Font, 12);
            label5.Font = new Font(Program.theme.Font, 12);
            label6.Font = new Font(Program.theme.Font, 12);
            b1.Font = new Font(Program.theme.Font, 14);
            b2.Font = new Font(Program.theme.Font, 14);
            textBox4.Font = new Font(Program.theme.Font, 10);
            textBox5.Font = new Font(Program.theme.Font, 10);

            p.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            pa1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            pa2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            pa3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            pa4.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
            p2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            p3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            b1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            b2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            lb1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            lb2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            lb3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            textBox4.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
            textBox5.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
        }

        public void translate(string curr, string want)
        {
            b1.Text = Program.lang.translate(b1.Text, curr, want);
            b2.Text = Program.lang.translate(b2.Text, curr, want);
            label1.Text = Program.lang.translate(label1.Text, curr, want);
            label2.Text = Program.lang.translate(label2.Text, curr, want);
            label3.Text = Program.lang.translate(label3.Text, curr, want);
            label5.Text = Program.lang.translate(label5.Text, curr, want);
            label6.Text = Program.lang.translate(label6.Text, curr, want);
        }
    }
}
