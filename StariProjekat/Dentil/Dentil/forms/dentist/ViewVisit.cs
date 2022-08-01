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
    public partial class ViewVisit : Form
    {
        string patientJmb = "";
        public ViewVisit(string patientJmb)
        {
            this.patientJmb = patientJmb;
            InitializeComponent();
            fill(patientJmb);
            changeTheme();
            translate(Program.defaultLang, Program.lang.CurrLang);
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            panel6.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            panel6.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
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
            this.Dispose();
        }

        private void lb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb1.SelectedIndex < 0)
                return;

            lb2.Items.Clear();
            pictureBox1.Visible = false;
            tb.Text = "";
            tb1.Text = "";

            for (int i = 0; i < pr[lb1.SelectedIndex].Count; i++)
                lb2.Items.Add(pr[lb1.SelectedIndex][i].Name);

            try 
            {
                dbManagement.Insert.insertLastSeen(Program.user.Id, int.Parse(visitId[lb1.SelectedIndex]));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
            }
        }

        private void b2_MouseEnter(object sender, EventArgs e)
        {
            b2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void b2_MouseLeave(object sender, EventArgs e)
        {
            b2.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[1]);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (lb1.SelectedIndex < 0)
                return;

            try
            {
                Console.WriteLine(visit[lb1.SelectedIndex]);
                ViewLastSeen vls = new ViewLastSeen(int.Parse(visitId[lb1.SelectedIndex]));
                vls.ShowDialog();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
            }
        }

        private void lb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb2.SelectedIndex < 0 || lb1.SelectedIndex < 0)
                return;

            pictureBox1.Visible = false;
            tb.Text = "";
            tb1.Text = "";
        
            if ( System.IO.File.Exists(pr[lb1.SelectedIndex][lb2.SelectedIndex].FilePath))
            {
                pictureBox1.Image = Image.FromFile(pr[lb1.SelectedIndex][lb2.SelectedIndex].FilePath);
                pictureBox1.Visible = true;
            }

            string desc = pr[lb1.SelectedIndex][lb2.SelectedIndex].Description;
            tb.Text = "0".Equals(desc) ? "" : desc;
            tb1.Text = pr[lb1.SelectedIndex][lb2.SelectedIndex].Teeth <= 0 ? "" : pr[lb1.SelectedIndex][lb2.SelectedIndex].Teeth.ToString();
        }
    }
}
