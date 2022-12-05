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

namespace DentilNew.view
{
    public partial class ViewVisit : MaterialForm
    {
        private VisitDTO dto;
        private List<ProblemDTO> arrProblem = new List<ProblemDTO>();
        private List<VisitTreatmentDTO> arrVisitTreatment = new List<VisitTreatmentDTO>();

        public ViewVisit(VisitDTO dto)
        {
            this.dto = dto;
            InitializeComponent();
            changeTheme();
            configure();
            inputLastSeen();
        }

        private void changeTheme()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = Program.theme.DefaultTheme;
            materialSkinManager.ColorScheme = Program.theme.DefaultColorPalette;
        }

        private void configure()
        {
            lb1.Items.Clear();
            lb2.Items.Clear();

            tb1.Text = dto.Patient.Name;
            tb2.Text = dto.Patient.Surname;
            tb3.Text = dto.Dentist.Name;
            tb4.Text = dto.Dentist.Surname;

            this.arrProblem = Program.problemController.selectWithIdVisit(dto.Id);
            foreach (ProblemDTO i in this.arrProblem)
                lb2.Items.Add(new MaterialListBoxItem(i.TypeProblemDto.Name + (i.Tooth == -1 ? "" : " " + i.Tooth)));

            lb2.Items.Add(new MaterialListBoxItem(""));
            this.arrVisitTreatment = Program.visitTreatmentController.selectWithIdvisit(dto.Id);
            foreach (VisitTreatmentDTO i in this.arrVisitTreatment)
                lb1.Items.Add(new MaterialListBoxItem(i.TreatmentDTO.Name));


            lb1.Items.Add(new MaterialListBoxItem(""));
        }

        private void inputLastSeen()
        {
            Program.lastSeenController.insert(new LastSeenDTO(dto.Id, dto.IDDentist));
        }

        //SHOW MORE INFO OF PATIENT
        private void b1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Program.patientController.selectWithId(dto.IdPatient));
            AddPatient ap = new AddPatient(Program.patientController.selectWithId(dto.IdPatient));
            ap.ShowDialog();
        }

        //SHOW DESCRIPTION
        private void b2_Click(object sender, EventArgs e)
        {
            if (lb1.SelectedIndex >= 0 && lb1.SelectedIndex < lb1.Items.Count - 1)
            {
                ViewDescription vw = new ViewDescription(arrVisitTreatment[lb1.SelectedIndex].Description);
                vw.ShowDialog();
            }
            else
                Program.notification.manageModalResult(this, false, 1);
        }

        //SHOW LAST SEEN
        private void b3_Click(object sender, EventArgs e)
        {
            ViewLastSeen vls = new ViewLastSeen(dto.Id);
            vls.ShowDialog();
        }
    }
}
