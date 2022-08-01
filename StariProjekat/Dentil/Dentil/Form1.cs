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

namespace Dentil
{
    public partial class Form1 : Form
    {
        string[] imgArr = new string[3] { Directory.GetCurrentDirectory() + "\\..\\..\\images\\icons\\operator.png",
            Directory.GetCurrentDirectory() + "\\..\\..\\images\\icons\\admin.png",
            Directory.GetCurrentDirectory() + "\\..\\..\\images\\icons\\dentist.png"};
        public static Admin admin = null;

        ToolTip tt = new ToolTip();

        int currShow = 1;

        public Form1()
        {
            InitializeComponent();

            Program.lang.addLangItems(ref cb1);

            this.translate(Program.defaultLang, Program.lang.CurrLang);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            currShow = currShow + 1 > 2 ? 0 : currShow + 1;
            pb1.Image = Image.FromFile(imgArr[currShow]);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            currShow = currShow - 1 < 0 ? 2 : currShow - 1;
            pb1.Image = Image.FromFile(imgArr[currShow]);
        }

        private string getType()
        {
            if (currShow == 0)
                return "other";
            else if (currShow == 1)
                return "admin";
            else
                return "dentist";
        }

        private void b1_Click(object sender, EventArgs e)
        {
            string hash = tb2.Text;
            for (int i=0;i<3;i++)
                hash = security.Security.getHash(hash);

            if ( dbManagement.Query.checkLogIn(hash, tb1.Text, getType()) )
            {
                Program.user = dbManagement.Query.getUser("", "", "", "", "", "", hash, tb1.Text, "-")[0];

                if ( currShow == 0)
                {
                    Other other = new Other(this);
                    other.Visible = true;
                }else if (currShow == 1)
                {
                    Admin admin = new Admin(this);
                    admin.Visible = true;
                }
                else
                {
                    Dentist dentist = new Dentist(this);
                    dentist.Visible = true;
                }

                this.Visible = false;
            }
            else
                MessageBox.Show(Program.lang.translate("Operation not successful", Program.defaultLang, Program.lang.CurrLang), 
                    Program.lang.translate("Failed validation", Program.defaultLang, Program.lang.CurrLang), MessageBoxButtons.OK ,MessageBoxIcon.Error);

            reset();
        }

        private void reset()
        {
            tb1.Text = "";
            tb2.Text = "";
        }

        private void pb1_MouseEnter(object sender, EventArgs e)
        {
            switch (currShow)
            {
                case 0:
                    tt.SetToolTip(pb1, "operator");
                    break;
                case 1:
                    tt.SetToolTip(pb1, "admin");
                    break;
                case 2:
                    tt.SetToolTip(pb1, "dentist");
                    break;
            }
        }

        private void pb1_MouseLeave(object sender, EventArgs e)
        {
            tt.RemoveAll();
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.translate(Program.lang.CurrLang, cb1.SelectedItem.ToString());
        }
    }
}
