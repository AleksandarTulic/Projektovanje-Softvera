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
    public partial class ShiftInput : Form
    {
        public ShiftInput()
        {
            InitializeComponent();

            translate(Program.defaultLang, Program.lang.CurrLang);
            changeTheme();
            fill();
        }

        private void fill()
        {
            cb1.Items.Clear();
            cb2.Items.Clear();
            cb1_copy.Items.Clear();
            cb2_copy.Items.Clear();
            
            for (int i = 0; i < 59; i++)
                if (i < 10)
                    cb2.Items.Add("0" + i);
                else
                    cb2.Items.Add(i);

            for (int i = 0; i < 24; i++)
                if (i < 10)
                    cb1.Items.Add("0" + i);
                else
                    cb1.Items.Add(i);

            for (int i = 0; i < 59; i++)
                if (i < 10)
                    cb2_copy.Items.Add("0" + i);
                else
                    cb2_copy.Items.Add(i);

            for (int i = 0; i < 24; i++)
                if (i < 10)
                    cb1_copy.Items.Add("0" + i);
                else
                    cb1_copy.Items.Add(i);
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (cb1.SelectedIndex < 0 || cb2.SelectedIndex < 0 ||
                cb1_copy.SelectedIndex < 0 || cb2_copy.SelectedIndex < 0)
            {
                MessageBox.Show(Program.lang.translate("Operation not successful", Program.defaultLang, Program.lang.CurrLang),
                    Program.lang.translate("Input Shift", Program.defaultLang, Program.lang.CurrLang), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool flag = dbManagement.Insert.insertShift(cb1.SelectedItem.ToString(), cb2.SelectedItem.ToString(), cb1_copy.SelectedItem.ToString(), cb2_copy.SelectedItem.ToString());

            if (flag)
                MessageBox.Show(Program.lang.translate("Operation successful", Program.defaultLang, Program.lang.CurrLang),
                    Program.lang.translate("Input Shift", Program.defaultLang, Program.lang.CurrLang), MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(Program.lang.translate("Operation not successful", Program.defaultLang, Program.lang.CurrLang),
                    Program.lang.translate("Input Shift", Program.defaultLang, Program.lang.CurrLang), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void b1_MouseEnter(object sender, EventArgs e)
        {
            b1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void b1_MouseLeave(object sender, EventArgs e)
        {
            b1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
        }

        private void l1_MouseEnter(object sender, EventArgs e)
        {
            p3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void l1_MouseLeave(object sender, EventArgs e)
        {
            p3.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
        }

        private void l2_MouseEnter(object sender, EventArgs e)
        {
            p4.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void l2_MouseLeave(object sender, EventArgs e)
        {
            p4.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
        }

        private void l2_copy_MouseEnter(object sender, EventArgs e)
        {
            p3_copy.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void l2_copy_MouseLeave(object sender, EventArgs e)
        {
            p3_copy.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
        }

        private void l1_copy_MouseEnter(object sender, EventArgs e)
        {
            p4_copy.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void l1_copy_MouseLeave(object sender, EventArgs e)
        {
            p4_copy.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
        }

        private void cb1_copy_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.AutoPopDelay = 5000;
            tt.InitialDelay = 1000;
            tt.ReshowDelay = 500;
            tt.ShowAlways = true;
            tt.SetToolTip(cb1_copy, Program.lang.translate("If smaller than start then it lasts until the other day", Program.defaultLang, Program.lang.CurrLang));
        }

        private void cb2_copy_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.AutoPopDelay = 5000;
            tt.InitialDelay = 1000;
            tt.ReshowDelay = 500;
            tt.ShowAlways = true;
            tt.SetToolTip(cb2_copy, Program.lang.translate("If smaller than start then it lasts until the other day", Program.defaultLang, Program.lang.CurrLang));
        }
    }
}
