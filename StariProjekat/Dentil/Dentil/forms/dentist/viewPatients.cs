using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentil.forms.dentist
{
    public partial class viewPatients : Form
    {
        bool flagButton = false;
        public viewPatients(bool flagButton)
        {
            this.flagButton = flagButton;
            InitializeComponent();
            fill();
            translate(Program.defaultLang, Program.lang.CurrLang);
            changeTheme();
        }

        private bool checkRegex(Regex regex, string text)
        {
            return regex.IsMatch(text);
        }

        //INPUT
        private void b1_Click(object sender, EventArgs e)
        {
            if (
                (!checkRegex(new Regex(user.Patient.regexCity), tb5.Text) && !"".Equals(tb5.Text))
                ||
                (!checkRegex(new Regex(user.Patient.regexEmail), tb8.Text) && !"".Equals(tb8.Text))
                ||
                (!checkRegex(new Regex(user.Patient.regexPhone), tb9.Text) && !"".Equals(tb9.Text))
                )
            {
                MessageBox.Show(Program.lang.translate("Operation not possible", Program.defaultLang, Program.lang.CurrLang), Program.lang.translate("Input new Patient", Program.defaultLang, Program.lang.CurrLang),
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool flag = dbManagement.Insert.insertPatient(tb1.Text, tb2.Text, tb3.Text, tb8.Text, tb9.Text,
                    tb5.Text, tb6.Text, tb7.Text, comboBox1.SelectedItem.ToString());

            if (flag)
            {
                MessageBox.Show(Program.lang.translate("Operation successful", Program.defaultLang, Program.lang.CurrLang), Program.lang.translate("Input new Patient", Program.defaultLang, Program.lang.CurrLang),
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();
                fill();
            }
            else
            {
                MessageBox.Show(Program.lang.translate("Operation not possible", Program.defaultLang, Program.lang.CurrLang), Program.lang.translate("Input new Patient", Program.defaultLang, Program.lang.CurrLang),
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //MODIFY
        private void b2_Click(object sender, EventArgs e)
        {
            if ( lb.SelectedIndex < 0 )
            {
                MessageBox.Show(Program.lang.translate("Operation not possible", Program.defaultLang, Program.lang.CurrLang), Program.lang.translate("Modify Patient Info", Program.defaultLang, Program.lang.CurrLang),
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (
                (!checkRegex(new Regex(user.Patient.regexCity), tb5.Text) && !"".Equals(tb5.Text))
                ||
                (!checkRegex(new Regex(user.Patient.regexEmail), tb8.Text) && !"".Equals(tb8.Text))
                ||
                (!checkRegex(new Regex(user.Patient.regexPhone), tb9.Text) && !"".Equals(tb9.Text))
                )
            {
                MessageBox.Show(Program.lang.translate("Operation not possible", Program.defaultLang, Program.lang.CurrLang), Program.lang.translate("Modify Patient Info", Program.defaultLang, Program.lang.CurrLang),
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool flag = dbManagement.Modify.modifyPatient(users[lb.SelectedIndex], tb1.Text, tb2.Text, tb3.Text, tb8.Text, tb9.Text, tb5.Text, tb6.Text, tb7.Text, comboBox1.SelectedItem.ToString());

            if (flag)
            {
                MessageBox.Show(Program.lang.translate("Operation successful", Program.defaultLang, Program.lang.CurrLang), Program.lang.translate("Modify Patient Info", Program.defaultLang, Program.lang.CurrLang),
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();
                fill();
            }
            else
            {
                MessageBox.Show(Program.lang.translate("Operation not possible", Program.defaultLang, Program.lang.CurrLang), Program.lang.translate("Modify Patient Info", Program.defaultLang, Program.lang.CurrLang),
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //DELETE
        private void b3_Click(object sender, EventArgs e)
        {
            if (lb.SelectedIndex < 0)
                return;

            bool flag = dbManagement.Delete.deletePatient(users[lb.SelectedIndex].Id);

            if (flag)
            {
                MessageBox.Show(Program.lang.translate("Operation successful", Program.defaultLang, Program.lang.CurrLang), Program.lang.translate("Delete Patient", Program.defaultLang, Program.lang.CurrLang),
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();
                fill();
            }
            else
            {
                MessageBox.Show(Program.lang.translate("Operation not possible", Program.defaultLang, Program.lang.CurrLang), Program.lang.translate("Delete Patient", Program.defaultLang, Program.lang.CurrLang),
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void b4_MouseEnter(object sender, EventArgs e)
        {
            b4.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void b4_MouseLeave(object sender, EventArgs e)
        {
            b4.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (lb.SelectedIndex < 0)
                return;

            other.ViewVisits vv = new other.ViewVisits(users[lb.SelectedIndex].Id);
            vv.ShowDialog();
        }

        private void reset()
        {
            comboBox1.SelectedIndex = 0;
            tb1.Text = "";
            tb2.Text = "";
            tb3.Text = "";
            tb5.Text = "";
            tb6.Text = "";
            tb7.Text = "";
            tb8.Text = "";
            tb9.Text = "";
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

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            panel6.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            panel6.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
        }

        private void b3_MouseEnter(object sender, EventArgs e)
        {
            b3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void b3_MouseLeave(object sender, EventArgs e)
        {
            b3.BackColor = Color.Transparent;
        }

        private void b2_MouseEnter(object sender, EventArgs e)
        {
            b2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void b2_MouseLeave(object sender, EventArgs e)
        {
            b2.BackColor = Color.Transparent;
        }

        private void b1_MouseEnter(object sender, EventArgs e)
        {
            b1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void b1_MouseLeave(object sender, EventArgs e)
        {
            b1.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lb.SelectedIndex < 0)
                MessageBox.Show(Program.lang.translate("Operation not possible", Program.defaultLang, Program.lang.CurrLang), Program.lang.translate("Add Patient Visit", Program.defaultLang, Program.lang.CurrLang),
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                VisitInput vi = new VisitInput(users[lb.SelectedIndex].Id);
                vi.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ( lb.SelectedIndex < 0 )
                MessageBox.Show(Program.lang.translate("Operation not possible", Program.defaultLang, Program.lang.CurrLang), Program.lang.translate("Add Appointment", Program.defaultLang, Program.lang.CurrLang),
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                AppointmentInput ai = new AppointmentInput(users[lb.SelectedIndex].Id);
                ai.ShowDialog();
                fill();
            }
        }

        private void tb9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void tb7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            findFill(textBox3.Text, textBox4.Text, textBox5.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            findFill(textBox3.Text, textBox4.Text, textBox5.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            findFill(textBox3.Text, textBox4.Text, textBox5.Text);
        }

        private void lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb.SelectedIndex < 0)
                return;
            tb1.Text = users[lb.SelectedIndex].Id;
            tb2.Text = users[lb.SelectedIndex].Name;
            tb3.Text = users[lb.SelectedIndex].Surname;
            if ("Male".Equals(users[lb.SelectedIndex].Gender))
                comboBox1.SelectedIndex = 0;
            else
                comboBox1.SelectedIndex = 1;
            tb5.Text = users[lb.SelectedIndex].City;
            tb6.Text = users[lb.SelectedIndex].Street;
            tb7.Text = users[lb.SelectedIndex].StreetNum == -1 ? "" : users[lb.SelectedIndex].StreetNum.ToString();
            tb8.Text = users[lb.SelectedIndex].Email;
            tb9.Text = users[lb.SelectedIndex].Phone;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lb.SelectedIndex < 0)
                return;
            
             ViewVisit vv = new ViewVisit(users[lb.SelectedIndex].Id);
             vv.ShowDialog();
        }
    }
}
