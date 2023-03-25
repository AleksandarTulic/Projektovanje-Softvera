using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace DentilNew.view.modal_input
{
    public partial class RecoveryPatient : MaterialForm
    {
        public RecoveryPatient()
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

        private void mbtnSubmitRecovery_Click(object sender, EventArgs e)
        {
            bool flag = Program.patientController.recoverPatient(mtbPatientID.Text);

            Program.notification.manageModalResult(this, flag, 1);
        }
    }
}
