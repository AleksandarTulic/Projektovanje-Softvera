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

namespace DentilNew.view
{
    public partial class ViewDescription : MaterialForm
    {
        public ViewDescription(string description)
        {
            InitializeComponent();
            changeTheme();

            mltb1.Text = description;       
        }

        private void changeTheme()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = Program.theme.DefaultTheme;
            materialSkinManager.ColorScheme = Program.theme.DefaultColorPalette;
        }
    }
}
