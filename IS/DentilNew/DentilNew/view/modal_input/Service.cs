using DentilNew.model.logger;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentilNew
{
    public partial class Treatment : MaterialForm
    {
        public Treatment()
        {
            InitializeComponent();
            changeTheme();
        }

        public void changeTheme()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = Program.theme.DefaultTheme;
            materialSkinManager.ColorScheme = Program.theme.DefaultColorPalette;
        }

        private void b1_Click(object sender, EventArgs e)
        {
            bool flag = false;
            if (tb1.Text.Length >= 2)
            {
                try
                {
                    flag = Program.treatmentController.insert(tb1.Text, double.Parse(tb2.Text));
                }
                catch (Exception ex)
                {
                    MyLogger.Logger.log(ex.Message);
                }
            }

            Program.notification.manageModalResult(this, flag, 1);
        }

        private void checkIfNumber(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb2_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkIfNumber(e);
        }
    }
}
