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

namespace Dentil.forms.admin
{
    public partial class ElementsInput : Form
    {
        bool flagForm = true;
        elements.Elements ele = null;

        public ElementsInput(elements.Elements element, bool flagForm)
        {
            InitializeComponent(flagForm);

            this.ele = element;
            this.flagForm = flagForm;
            fill(element, flagForm);
            translate(Program.defaultLang, Program.lang.CurrLang);
        }

        //INPUT
        private void button1_Click(object sender, EventArgs e)
        {
            string destFile = pictureBox1.Visible == true ? $"{Directory.GetCurrentDirectory()}\\..\\..\\images\\" + Path.GetFileName(textBox4.Text) : textBox4.Text;

            string type = Program.lang.translate(cb.SelectedItem.ToString(), Program.lang.CurrLang, Program.defaultLang);
            elements.Elements element = new elements.Elements(new List<string>()
                    {
                        ele == null ? "1" : ele.Id.ToString(),
                        textBox1.Text,
                        textBox2.Text,
                        tb3.Text,
                        destFile,
                        type
                    });

            bool flagOper = flagForm ? dbManagement.Insert.insertElement(element) : dbManagement.Modify.modifyElement(element);
            if (flagOper)
                MessageBox.Show(Program.lang.translate("Successful operation", Program.defaultLang, Program.lang.CurrLang), 
                    flagForm ? Program.lang.translate("Input Element", Program.defaultLang, Program.lang.CurrLang)
                     : Program.lang.translate("Modify Element", Program.defaultLang, Program.lang.CurrLang), MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(Program.lang.translate("Operation not successful", Program.defaultLang, Program.lang.CurrLang),
                    flagForm ? Program.lang.translate("Input Element", Program.defaultLang, Program.lang.CurrLang)
                     : Program.lang.translate("Modify Element", Program.defaultLang, Program.lang.CurrLang), MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (flagOper && flagForm)
                fileManagement.FileOperations.copyFile(textBox4.Text, destFile);


            fill(element, flagForm);
        }

        //WHICH PICTURE
        private void b2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;";

            ofd.Multiselect = false;
            ofd.Title = Program.lang.translate("Select picture", Program.defaultLang, Program.lang.CurrLang);

            DialogResult res = ofd.ShowDialog();
            if ( res == DialogResult.OK)
            {
                textBox4.Text = ofd.FileName;
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                pictureBox1.Visible = true;
            }
            else if ( res != DialogResult.Cancel )
            {
                MessageBox.Show(Program.lang.translate("Selected item is not valid", Program.defaultLang, Program.lang.CurrLang),
                    Program.lang.translate("Not Valid", Program.defaultLang, Program.lang.CurrLang), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
