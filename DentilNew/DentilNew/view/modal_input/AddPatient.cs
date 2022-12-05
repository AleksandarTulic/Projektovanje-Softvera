using DentilNew.model.dto;
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

namespace DentilNew.view.modal_input
{
    public partial class AddPatient : MaterialForm
    {
        private int howMuchChanged = 0;
        private Dictionary<int, int> mapProgressBarValue = new Dictionary<int, int>();
        private Dictionary<int, bool> flagForProgressBar = new Dictionary<int, bool>();
        private bool flagUpdate = false;
        private string oldId = "";

        public AddPatient()
        {
            fillProgressBarValues();
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
        public AddPatient(PatientDTO dto, string oldId) : this()
        {
            this.oldId = oldId;
            tb1.Text = dto.Id;
            tb2.Text = dto.Name;
            tb3.Text = dto.Surname;
            tb4.Text = dto.Email == null ? "" : dto.Email;
            tb5.Text = dto.Phone == null ? "" : dto.Phone;
            tb6.Text = dto.Address == null ? "" : dto.Address;

            b1.Text = "Update";
            this.Text = "Update Patient";
            this.flagUpdate = true;
        }

        public AddPatient(PatientDTO dto) : this()
        {
            tb1.Text = dto.Id;
            tb2.Text = dto.Name;
            tb3.Text = dto.Surname;
            tb4.Text = dto.Email == null ? "" : dto.Email;
            tb5.Text = dto.Phone == null ? "" : dto.Phone;
            tb6.Text = dto.Address == null ? "" : dto.Address;

            this.Text = "View Patient";
            this.flagUpdate = true;

            tb1.Enabled = false;
            tb2.Enabled = false;
            tb3.Enabled = false;
            tb4.Enabled = false;
            tb5.Enabled = false;
            tb6.Enabled = false;

            mpb1.Hide();
            b1.Hide();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (mpb1.Value == 100)
            {
                if (Program.patientValidation.checkNotRequiredAttributes(tb4.Text, tb5.Text, tb6.Text))
                {
                    PatientDTO dto = new PatientDTO(tb1.Text, tb2.Text, tb3.Text, tb4.Text, tb5.Text, tb6.Text);
                    if (flagUpdate)
                        Program.notification.manageModalResult(this, Program.patientController.update(dto, oldId), 1);
                    else
                        Program.notification.manageModalResult(this, Program.patientController.insert(dto), 1);
                }
            }
        }

        private void tb5_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkIfNumber(e);
        }

        private void tb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkIfNumber(e);
        }

        private void checkIfNumber(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {
            if (Program.patientValidation.checkID(tb1.Text))
            {
                if (flagForProgressBar[1])
                    fill(flagForProgressBar[1]);
                flagForProgressBar[1] = false;
            }
            else if (!flagForProgressBar[1])
            {
                fill(false);
                flagForProgressBar[1] = true;
            }
        }

        private void tb2_TextChanged(object sender, EventArgs e)
        {
            if (Program.patientValidation.checkName(tb2.Text))
            {
                if (flagForProgressBar[2])
                    fill(flagForProgressBar[2]);
                flagForProgressBar[2] = false;
            }
            else if (!flagForProgressBar[2])
            {
                fill(false);
                flagForProgressBar[2] = true;
            }
        }

        private void tb3_TextChanged(object sender, EventArgs e)
        {
            if (Program.patientValidation.checkSurname(tb3.Text))
            {
                if (flagForProgressBar[3])
                    fill(flagForProgressBar[3]);
                flagForProgressBar[3] = false;
            }
            else if (!flagForProgressBar[3])
            {
                fill(false);
                flagForProgressBar[3] = true;
            }
        }

        private void fill(bool flag)
        {
            howMuchChanged = flag ? howMuchChanged + 1 : howMuchChanged - 1;
            mpb1.Value = mapProgressBarValue[howMuchChanged];
        }

        private void fillProgressBarValues()
        {
            flagForProgressBar.Add(1, true);
            flagForProgressBar.Add(2, true);
            flagForProgressBar.Add(3, true);
            mapProgressBarValue.Add(0, 0);
            mapProgressBarValue.Add(1, 33);
            mapProgressBarValue.Add(2, 66);
            mapProgressBarValue.Add(3, 100);
        }
    }
}
