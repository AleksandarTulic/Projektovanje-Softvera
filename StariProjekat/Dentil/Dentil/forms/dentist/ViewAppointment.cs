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
    public partial class ViewAppointment : Form
    {
        bool type = true;
        public ViewAppointment(bool type)
        {
            this.type = type;
            InitializeComponent();

            translate(Program.defaultLang, Program.lang.CurrLang);
            changeTheme();
            fill();
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

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lb2.SelectedIndex < 0)
                MessageBox.Show(Program.lang.translate("Operation not possible", Program.defaultLang, Program.lang.CurrLang), Program.lang.translate("Delete Appointment", Program.defaultLang, Program.lang.CurrLang),
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                bool flag = dbManagement.Delete.deleteAppointment(app[lb2.SelectedIndex].Date, app[lb2.SelectedIndex].Time, app[lb2.SelectedIndex].DentistJmb);

                if ( flag )
                    MessageBox.Show(Program.lang.translate("Operation successful", Program.defaultLang, Program.lang.CurrLang), Program.lang.translate("Delete Appointment", Program.defaultLang, Program.lang.CurrLang),
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(Program.lang.translate("Operation not possible", Program.defaultLang, Program.lang.CurrLang), Program.lang.translate("Delete Appointment", Program.defaultLang, Program.lang.CurrLang),
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            fillWhenChanged();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lb2.SelectedIndex < 0)
                MessageBox.Show(Program.lang.translate("Operation not successful", Program.defaultLang, Program.lang.CurrLang), Program.lang.translate("View Appointment", Program.defaultLang, Program.lang.CurrLang),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                ViewAppointmentDetail vad = new ViewAppointmentDetail(app[lb2.SelectedIndex]);
                vad.ShowDialog();
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewPatients vp = new viewPatients(type);
            vp.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            fillWhenChanged();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            fillWhenChanged();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            fillWhenChanged();
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillWhenChanged();
        }

        private void mc_MouseDown(object sender, MouseEventArgs e)
        {
            MonthCalendar.HitTestInfo info = mc.HitTest(e.Location);
            if (info.HitArea == MonthCalendar.HitArea.Date)
            {
                if (mc.BoldedDates.Contains(info.Time))
                {
                    mc.RemoveBoldedDate(info.Time);
                    for (int i = 0; i < lb1.Items.Count; i++)
                        if (lb1.Items.IndexOf(info.Time) >= 0)
                            lb1.Items.RemoveAt(lb1.Items.IndexOf(info.Time));

                    lb2.Items.Clear();
                }
                else if ( mc.BoldedDates.Length < 1 )
                {
                    mc.AddBoldedDate(info.Time);
                    lb1.Items.Add(info.Time);
                }

                mc.UpdateBoldedDates();
                //fillWhenChanged();
            }
        }

        private void lb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb1.SelectedIndex < 0)
                return;

            fillWhenChanged();
        }
    }
}
