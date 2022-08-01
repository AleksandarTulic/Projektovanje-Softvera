using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentil.forms.admin
{
    public partial class ScheduleInput : Form
    {
        List<elements.Shift> shifts = new List<elements.Shift>();
        List<user.User> users = new List<user.User>();
        public ScheduleInput()
        {
            InitializeComponent();

            fill();

            changeTheme();
            translate(Program.defaultLang, Program.lang.CurrLang);
        }

        private void fill()
        {
            lb2.Items.Clear();

            fillShifts();
            fillPersonal();
        }

        private void fillShifts()
        {
            lb3.Items.Clear();
            shifts.Clear();
            List<List<string>> arr = dbManagement.Query.query(dbManagement.Query.allShift);

            for (int i = 0; i < arr.Count; i++)
                shifts.Add(new elements.Shift(arr[i]));

            foreach (elements.Shift es in shifts)
                lb3.Items.Add(es.ToString());
        }

        private void fillPersonal()
        {
            users.Clear();
            lb1.Items.Clear();
            List<List<string>> arr = dbManagement.Query.query(dbManagement.Query.allPersonal);

            for (int i = 0; i < arr.Count; i++)
            {
                users.Add(dbManagement.Query.getUser(arr[i][0]));
                lb1.Items.Add(users[users.Count-1].Name + " " + users[users.Count-1].Surname);
            }
        }

        private void b2_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.AutoPopDelay = 5000;
            tt.InitialDelay = 1000;
            tt.ReshowDelay = 500;
            tt.ShowAlways = true;
            tt.SetToolTip(b2, Program.lang.translate("Input Shift", Program.defaultLang, Program.lang.CurrLang));
        }

        private void b2_Click(object sender, EventArgs e)
        {
            ShiftInput si = new ShiftInput();
            si.ShowDialog();
        }

        private void mc_MouseDown(object sender, MouseEventArgs e)
        {
            MonthCalendar.HitTestInfo info = mc.HitTest(e.Location);
            if (info.HitArea == MonthCalendar.HitArea.Date)
            {
                if (mc.BoldedDates.Contains(info.Time))
                {
                    mc.RemoveBoldedDate(info.Time);
                    for (int i = 0; i < lb2.Items.Count; i++)
                        if (lb2.Items.IndexOf(info.Time) >= 0)
                            lb2.Items.RemoveAt(lb2.Items.IndexOf(info.Time));
                }
                else
                {
                    mc.AddBoldedDate(info.Time);
                    lb2.Items.Add(info.Time);
                }
                
                mc.UpdateBoldedDates();
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (lb3.SelectedIndex < 0)
            {
                MessageBox.Show(Program.lang.translate("Operation not successful", Program.defaultLang, Program.lang.CurrLang),
                   Program.lang.translate("Delete Shift", Program.defaultLang, Program.lang.CurrLang), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Console.WriteLine(lb3.SelectedIndex + " " + lb3.SelectedItem);
            bool flag = dbManagement.Delete.deleteShift(shifts[lb3.SelectedIndex].Id);

            if (!flag)
                MessageBox.Show(Program.lang.translate("Operation not successful", Program.defaultLang, Program.lang.CurrLang),
                   Program.lang.translate("Delete Shift", Program.defaultLang, Program.lang.CurrLang), MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //shifts.RemoveAt(lb3.SelectedIndex);
                //lb3.Items.RemoveAt(lb3.SelectedIndex);

                MessageBox.Show(Program.lang.translate("Operation successful", Program.defaultLang, Program.lang.CurrLang),
                   Program.lang.translate("Delete Shift", Program.defaultLang, Program.lang.CurrLang), MessageBoxButtons.OK, MessageBoxIcon.Information);

                fillShifts();
            }
        }

        //INPUT SHIFT
        private void b1_Click(object sender, EventArgs e)
        {
            if ( lb1.SelectedIndex < 0 || lb2.Items.Count <= 0 || lb3.SelectedIndex < 0 )
                MessageBox.Show(Program.lang.translate("Operation not successful", Program.defaultLang, Program.lang.CurrLang),
                   Program.lang.translate("Input Shift", Program.defaultLang, Program.lang.CurrLang), MessageBoxButtons.OK, MessageBoxIcon.Error);

            List<user.User> ar = new List<user.User>();
            for (int i = 0; i < lb1.SelectedIndices.Count; i++)
                ar.Add(users[lb1.SelectedIndices[i]]);

            List <elements.helpElements.Date> arrDate = new List<elements.helpElements.Date>();
            for (int i = 0; i < lb2.Items.Count; i++)
                arrDate.Add(new elements.helpElements.Date(lb2.Items[i].ToString()));

            for (int i = 0; i < lb2.Items.Count; i++)
                Console.WriteLine(lb2.Items[i].ToString());

            bool flag = dbManagement.Insert.insertSchedule(ar, arrDate, shifts[lb3.SelectedIndex]);

            if ( flag )
                MessageBox.Show(Program.lang.translate("Operation successful", Program.defaultLang, Program.lang.CurrLang),
                   Program.lang.translate("Input Shift", Program.defaultLang, Program.lang.CurrLang), MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(Program.lang.translate("Operation not(or partially) successful", Program.defaultLang, Program.lang.CurrLang),
                   Program.lang.translate("Input Shift", Program.defaultLang, Program.lang.CurrLang), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void b3_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.AutoPopDelay = 5000;
            tt.InitialDelay = 1000;
            tt.ReshowDelay = 500;
            tt.ShowAlways = true;
            tt.SetToolTip(b3, Program.lang.translate("Delete Shift", Program.defaultLang, Program.lang.CurrLang));
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
