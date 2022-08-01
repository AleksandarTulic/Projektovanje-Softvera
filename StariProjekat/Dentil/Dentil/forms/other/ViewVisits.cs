using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentil.forms.other
{
    public partial class ViewVisits : Form
    {
        string id;
        public ViewVisits(string id)
        {
            this.id = id;
            InitializeComponent();
            translate(Program.defaultLang, Program.lang.CurrLang);
            changeTheme();
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

        private void b1_Click(object sender, EventArgs e)
        {
            if (lb1.SelectedIndex < 0)
                return;

            try
            {
                int id = int.Parse(visitId[lb1.SelectedIndex]);

                dentist.BillInput bi = new dentist.BillInput(false, id);
                bi.ShowDialog();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
            }
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[0]);
        }
    }
}
