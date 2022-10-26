using DentilNew.model.dto;
using DentilNew.view.modal_input;
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
    public partial class Main : MaterialForm
    {
        private List<string> arrId = new List<string>();
        public Main()
        {
            arrId.Add("2402999100005");
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                ni1.Visible = true;
            }
        }

        private void ni1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            ni1.Visible = false;
        }

        //ADD PATIENT
        private void b1_Click(object sender, EventArgs e)
        {
            AddPatient addPatient = new AddPatient();
            addPatient.ShowDialog();
        }

        //DELETE PATIENT
        private void b2_Click(object sender, EventArgs e)
        {
            int number = 0;
            Program.patientController.delete(arrId[number]);
        }

        //UPDATE PATIENT
        private void b3_Click(object sender, EventArgs e)
        {
            PatientDTO dto = new PatientDTO("1505999122445", "AAAAAAAA", "BBBBBBB", "AAAAA@BBBBB.com", null, null);
            AddPatient addPatient = new AddPatient(dto, "1505999122445");
            addPatient.ShowDialog();
        }
    }
}
