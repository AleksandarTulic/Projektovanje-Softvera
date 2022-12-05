using DentilNew.model.logger;
using MaterialSkin;
using MaterialSkin.Controls;
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

namespace DentilNew
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
            changeTheme();
        }

        public void changeTheme()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = Program.theme.DefaultColorPalette;
            materialSkinManager.Theme = Program.theme.DefaultTheme;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            bool tmp = Program.loginController.select(tb1.Text, tb2.Text);

            if (tmp)
            {
                this.Hide();
                Main main = new Main(this);
                main.Show();

                tb1.Text = "";
                tb2.Text = "";
            }
            else
                MessageBox.Show("Login Failed! \nTry Again.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }
    }
}
