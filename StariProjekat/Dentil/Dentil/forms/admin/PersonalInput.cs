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

namespace Dentil.forms.admin
{
    public partial class PersonalInput : Form
    {
        public PersonalInput()
        {
            InitializeComponent();

            translate(Program.defaultLang, Program.lang.CurrLang);

            comboBox1.SelectedIndex = 0;
            tb1.Text = "";
            tb2.Text = "";
            tb3.Text = "";
            tb5.Text = "";
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
            changeTheme();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (!checkRegex(new Regex(user.User.regexEmail), tb8.Text) || !checkRegex(new Regex(user.User.regexCity), tb5.Text) || !checkRegex(new Regex(user.User.regexPhone), tb9.Text))
            {
                MessageBox.Show(Program.lang.translate("Operation not possible", Program.defaultLang, Program.lang.CurrLang), Program.lang.translate("Input new staff member", Program.defaultLang, Program.lang.CurrLang),
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                bool flag = dbManagement.Insert.insertPersonal(tb1.Text, tb2.Text, tb3.Text, comboBox1.SelectedItem.ToString(),
                    tb5.Text, tb6.Text, int.Parse(tb7.Text), tb8.Text, tb9.Text, tb10.Text, tb11.Text, tb12.Text, tb13.Text, tb14.Text, tb15.Text);

                if (flag)
                {
                    MessageBox.Show(Program.lang.translate("Operation successful", Program.defaultLang, Program.lang.CurrLang), Program.lang.translate("Input new staff member", Program.defaultLang, Program.lang.CurrLang),
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reset();
                }
                else
                {
                    MessageBox.Show(Program.lang.translate("Operation not possible", Program.defaultLang, Program.lang.CurrLang), Program.lang.translate("Input new staff member", Program.defaultLang, Program.lang.CurrLang),
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
            }
        }

        private bool checkRegex(Regex regex, string text)
        {
            return regex.IsMatch(text);
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
            tb10.Text = "";
            tb11.Text = "";
            tb12.Text = "";
            tb13.Text = "";
            tb14.Text = "";
            tb15.Text = "";
        }

        private void tb7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void tb11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void tb9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
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

        private void b1_MouseEnter(object sender, EventArgs e)
        {
            b1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void b1_MouseLeave(object sender, EventArgs e)
        {
            b1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
        }
    }
}
