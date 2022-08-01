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
    public partial class ViewPersonal : Form
    {
        public ViewPersonal()
        {
            InitializeComponent();

            translate(Program.defaultLang, Program.lang.CurrLang);
            changeTheme();
            fill();
        }

        //insert
        private void b1_MouseClick(object sender, MouseEventArgs e)
        {
            PersonalInput pi = new PersonalInput();
            pi.ShowDialog();
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
        }

        private void b2_MouseEnter(object sender, EventArgs e)
        {
            b2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void b2_MouseLeave(object sender, EventArgs e)
        {
            b1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
        }

        //delete
        private void b3_MouseClick(object sender, MouseEventArgs e)
        {
            if ( lb1.SelectedIndex < 0)
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
            if ( (b3.Visible && lb1.SelectedIndex < 0) || (!b3.Visible && lb2.SelectedIndex < 0) || !checkRegex(new Regex(user.User.regexEmail), tb9.Text) || !checkRegex(new Regex(user.User.regexCity), tb6.Text) )
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
    }
}
