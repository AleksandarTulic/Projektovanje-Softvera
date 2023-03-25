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
    public partial class TypeProblem : MaterialForm
    {
        public TypeProblem()
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
                flag = Program.typeProblemController.insert(tb1.Text);

            Program.notification.manageModalResult(this, flag, 1);
        }
    }
}
