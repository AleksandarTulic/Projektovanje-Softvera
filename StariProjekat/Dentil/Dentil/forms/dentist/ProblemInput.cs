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
    public partial class ProblemInput : Form
    {
        public ProblemInput()
        {
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

        private void b1_MouseEnter(object sender, EventArgs e)
        {
            b1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void b1_MouseLeave(object sender, EventArgs e)
        {
            b1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (lb.SelectedIndex >= 0 && cb1.Items.Count >= 1)
            {
                problem.Problem pr = new problem.Problem(cb.Checked ? -1 : teeth[cb1.SelectedIndex], typeProblem[lb.SelectedIndex]);
                bool flag = true;
                foreach (problem.Problem i in VisitInput.arr)
                    if (i.Equals(pr))
                    {
                        flag = false;
                        break;
                    }

                if (flag)
                    VisitInput.arr.Add(new problem.Problem(cb.Checked ? -1 : teeth[cb1.SelectedIndex], typeProblem[lb.SelectedIndex]));
                this.Dispose();
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            TypeProblem tp = new TypeProblem();
            tp.ShowDialog();
            fill();
        }

        private void cb_CheckedChanged(object sender, EventArgs e)
        {
            if (cb.Checked)
                cb1.Visible = false;
            else
                cb1.Visible = true;
        }

        private void lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb.SelectedIndex < 0)
                return;

            if (File.Exists(typeProblem[lb.SelectedIndex][2]))
            {
                pb.Image = Image.FromFile(typeProblem[lb.SelectedIndex][2]);
                pb.Visible = true;
            }
            else
            {
                pb.Visible = false;
            }

            string desc = typeProblem[lb.SelectedIndex][1];
            tb.Text = "0".Equals(desc) ? "" : desc;
        }
    }
}
