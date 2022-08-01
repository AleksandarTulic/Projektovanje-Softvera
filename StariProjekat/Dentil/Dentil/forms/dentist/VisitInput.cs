using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentil.forms.dentist
{
    public partial class VisitInput : Form
    {
        string patientJmb = "";
        public VisitInput(string patientJmb)
        {
            InitializeComponent();
            //Program.lang.CurrLang = "SER";
            translate(Program.defaultLang, Program.lang.CurrLang);
            changeTheme();
            fill();
            this.patientJmb = patientJmb;
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (lb.Items.Count < 0)
                MessageBox.Show(Program.lang.translate("Operation not possible", Program.defaultLang, Program.lang.CurrLang), Program.lang.translate("Add Visit", Program.defaultLang, Program.lang.CurrLang),
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int flag = dbManagement.Insert.insertVisit(patientJmb, Program.user.Id, arr);

                if (flag >= 0)
                {
                    bool f = dbManagement.Insert.insertBill(flag, bill);
                    if (f)
                    {
                        List<string> dateTime = dbManagement.Query.getDateTimeBill(flag);
                        bill.setDate(new elements.helpElements.Date(dateTime[0]));
                        bill.setTime(new elements.helpElements.Time(dateTime[1]));

                        //bill.writeToFile($"{Directory.GetCurrentDirectory()}\\..\\..\\bill\\issued\\{flag}.txt");
                        bill.writeToFile($"{flag}.txt");
                        MessageBox.Show(Program.lang.translate("Operation successful", Program.defaultLang, Program.lang.CurrLang), Program.lang.translate("Add Visit", Program.defaultLang, Program.lang.CurrLang),
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                }
                else
                    MessageBox.Show(Program.lang.translate("Operation not successful", Program.defaultLang, Program.lang.CurrLang), Program.lang.translate("Add Visit", Program.defaultLang, Program.lang.CurrLang),
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (lb.SelectedIndex < 0 && lb.SelectedIndex < arr.Count)
                MessageBox.Show(Program.lang.translate("Operation not possible", Program.defaultLang, Program.lang.CurrLang), Program.lang.translate("Delete From Problem List", Program.defaultLang, Program.lang.CurrLang),
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                arr.RemoveAt(lb.SelectedIndex);
                MessageBox.Show(Program.lang.translate("Operation successful", Program.defaultLang, Program.lang.CurrLang), Program.lang.translate("Delete From Problem List", Program.defaultLang, Program.lang.CurrLang),
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                fill();
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            ProblemInput pi = new ProblemInput();
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

        private void lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb.SelectedIndex < 0)
                return;

            fillSpecific(lb.SelectedIndex);
        }

        private void b4_MouseEnter(object sender, EventArgs e)
        {
            b4.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void b4_MouseLeave(object sender, EventArgs e)
        {
            b4.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            string s1 = Program.lang.translate("Delete Bill", Program.defaultLang, Program.lang.CurrLang);
            string s2 = Program.lang.translate(b4.Text, Program.defaultLang, Program.lang.CurrLang);
            if ( s1.Equals(s2))
            {
                b4.Text = Program.lang.translate("Add Bill", Program.defaultLang, Program.lang.CurrLang);
                bill = null;
                return;
            }

            BillInput bi = new BillInput(true, 0);
            bi.ShowDialog();

            if (bill != null)
                b4.Text = Program.lang.translate("Delete Bill", Program.defaultLang, Program.lang.CurrLang);
        }
    }
}
