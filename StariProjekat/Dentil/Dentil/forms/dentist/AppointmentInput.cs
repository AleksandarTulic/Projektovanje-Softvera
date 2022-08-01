using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentil.forms.dentist
{
    public partial class AppointmentInput : Form
    {
        string patientJmb = "";

        public AppointmentInput(string patientJmb)
        {
            InitializeComponent();
            this.patientJmb = patientJmb;

            translate(Program.defaultLang, Program.lang.CurrLang);
            changeTheme();
            fill();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lb.Items.Count < 1 || cb1.SelectedIndex < 0 || cb2.SelectedIndex < 0 || comboBox1.SelectedIndex < 0 || "".Equals(textBox1.Text))
            {
                MessageBox.Show(Program.lang.translate("Operation not successful", Program.defaultLang, Program.lang.CurrLang), Program.lang.translate("Input Appointment", Program.defaultLang, Program.lang.CurrLang),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                bool flag = dbManagement.Query.checkDentistWorks(users[comboBox1.SelectedIndex], new elements.helpElements.Date(lb.Items[0].ToString()), new elements.helpElements.Time(cb1.SelectedItem.ToString(), cb2.SelectedItem.ToString()),
                    int.Parse(textBox1.Text));

                if (flag)
                {
                    flag = dbManagement.Insert.insertAppointment(new elements.helpElements.Date(lb.Items[0].ToString()), new elements.helpElements.Time(cb1.SelectedItem.ToString(), cb2.SelectedItem.ToString()),
                        int.Parse(textBox1.Text), users[comboBox1.SelectedIndex], patientJmb, tb.Text);

                    if (flag)
                    {
                        MessageBox.Show(Program.lang.translate("Operation successful", Program.defaultLang, Program.lang.CurrLang), Program.lang.translate("Input Appointment", Program.defaultLang, Program.lang.CurrLang),
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return;
                    }
                }
            }

            MessageBox.Show(Program.lang.translate("Operation not successful", Program.defaultLang, Program.lang.CurrLang), Program.lang.translate("Input Appointment", Program.defaultLang, Program.lang.CurrLang),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void b1_MouseEnter(object sender, EventArgs e)
        {
            b1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void b1_MouseLeave(object sender, EventArgs e)
        {
            b1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
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

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            panel5.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            panel6.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            panel6.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
        }

        private void mc_MouseDown(object sender, MouseEventArgs e)
        {
            MonthCalendar.HitTestInfo info = mc.HitTest(e.Location);
            if (info.HitArea == MonthCalendar.HitArea.Date)
            {
                if (mc.BoldedDates.Contains(info.Time))
                {
                    mc.RemoveBoldedDate(info.Time);
                    lb.Items.Clear();
                }
                else if (mc.BoldedDates.Length < 1)
                {
                    mc.AddBoldedDate(info.Time);
                    lb.Items.Add(info.Time);
                }

                mc.UpdateBoldedDates();
            }
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(textBox1, Program.lang.translate("Number of Minutes", Program.defaultLang, Program.lang.CurrLang));
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            panel7.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            panel7.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
        }
    }
}
