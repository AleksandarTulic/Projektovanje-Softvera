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
    public partial class Tooth : MaterialForm
    {
        public Tooth()
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

        private void tb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            var flag = int.TryParse(tb1.Text, out int n);

            if (flag)
                flag = Program.toothController.insert(n);

            Program.notification.manageModalResult(this, flag, 1);
        }
    }
}
