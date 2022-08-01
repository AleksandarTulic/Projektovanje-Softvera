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
    public partial class TypeProblem : Form
    {
        string filePath = "";
        public TypeProblem()
        {
            InitializeComponent();
            translate(Program.defaultLang, Program.lang.CurrLang);
            changeTheme();
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

        private void b1_Click(object sender, EventArgs e)
        {
            bool flag = dbManagement.Insert.insertTypeProblem(textBox1.Text, textBox2.Text, filePath);

            if (flag)
                MessageBox.Show(Program.lang.translate("Operation successful", Program.defaultLang, Program.lang.CurrLang),
                    Program.lang.translate("Input Type Problem", Program.defaultLang, Program.lang.CurrLang), MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(Program.lang.translate("Operation not successful", Program.defaultLang, Program.lang.CurrLang),
                    Program.lang.translate("Input Type Problem", Program.defaultLang, Program.lang.CurrLang), MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (!"".Equals(filePath))
                fileManagement.FileOperations.copyFile(filePath, $"{Directory.GetCurrentDirectory()}\\..\\..\\images\\typeProblem\\{Path.GetFileName(filePath)}");

            filePath = "";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;";

            ofd.Multiselect = false;
            ofd.Title = Program.lang.translate("Select picture", Program.defaultLang, Program.lang.CurrLang);

            DialogResult res = ofd.ShowDialog();
            if (res == DialogResult.OK)
            {
                Console.WriteLine("PUTANJA: " + ofd.FileName);
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                filePath = ofd.FileName;
                pictureBox1.Visible = true;
            }
            else if (res != DialogResult.Cancel)
            {
                MessageBox.Show(Program.lang.translate("Selected item is not valid", Program.defaultLang, Program.lang.CurrLang),
                    Program.lang.translate("Not Valid", Program.defaultLang, Program.lang.CurrLang), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
