using DentilNew.model.dto;
using DentilNew.model.dto.common;
using DentilNew.model.theme;
using DentilNew.view;
using DentilNew.view.modal_input;
using DentilNew.view.modal_select;
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
        //GLOBAL
        private static readonly int VisibleTime = 1000;
        private MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;
        private Login login = null;

        //Patients
        private List<PatientDTO> arrPatient = new List<PatientDTO>();
        private static readonly int PAGE_PATIENT_NUMBER = 3;
        private static int SELECTED_PAGE = 1;
        private static int MAX_PAGES_NUMBER = 1;
        
        //Visits
        private List<VisitDTO> arrVisit = new List<VisitDTO>();
        private static readonly int PAGE_VISIT_NUMBER = 3;
        private static int SELECTED_PAGE_VISIT = 1;
        private static int MAX_PAGES_NUMBER_VISIT = 1;

        //Add Visit
        private List<ProblemDTO> arrProblem = new List<ProblemDTO>();
        private List<VisitTreatmentDTO> arrVisitTreatment = new List<VisitTreatmentDTO>();

        public Main(Login login)
        {
            this.login = login;

            InitializeComponent();
            changeTheme();
            configure();
            loadElements_1();
        }

        public void changeTheme()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = Program.theme.DefaultTheme;
            materialSkinManager.ColorScheme = Program.theme.DefaultColorPalette;
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                ni1.Visible = true;
            }
        }

        /*
         ****************************************************************************
         ****************************************************************************
                                        PATIENTs TAB
         ****************************************************************************
         ****************************************************************************
         */

        private void loadElements_1()
        {
            Patients_dgv1.Items.Clear();
            Patients_dgv1.Refresh();
            this.arrPatient = Program.patientController.select();
            MAX_PAGES_NUMBER = arrPatient.Count() / PAGE_PATIENT_NUMBER + 1;
            int i;
            for(i = (SELECTED_PAGE - 1)* PAGE_PATIENT_NUMBER; i < Math.Min(SELECTED_PAGE * PAGE_PATIENT_NUMBER, this.arrPatient.Count); i++)
            {
                string[] elements = { arrPatient[i].Id, arrPatient[i].Name, arrPatient[i].Surname};
                var arrItems = new ListViewItem(elements);
                Patients_dgv1.Items.Add(arrItems);
            }
        }


        private void Patients_pageD_Click(object sender, EventArgs e)
        {
            if (SELECTED_PAGE != 1)
            {
                SELECTED_PAGE--;
                loadElements_1();
            }
        }

        private void Patients_pageU_Click(object sender, EventArgs e)
        {
            if (SELECTED_PAGE < MAX_PAGES_NUMBER)
            {
                SELECTED_PAGE++;
                loadElements_1();
            }
        }

        //ADD PATIENT
        private void Patients_b2_Click(object sender, EventArgs e)
        {
            AddPatient addPatient = new AddPatient();
            addPatient.ShowDialog();
        }

        //DELETE PATIENT
        private void Patients_b3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete patient", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool tmp = Program.patientController.delete(arrPatient[Patients_dgv1.SelectedIndices[0]].Id);
                if (tmp)
                    loadElements_1();
            }         
            
        }

        //UPDATE PATIENT
        private void Patients_b4_Click(object sender, EventArgs e)
        {
            PatientDTO dto = new PatientDTO("1505999122445", "AAAAAAAA", "BBBBBBB", "AAAAA@BBBBB.com", null, null);
            AddPatient addPatient = new AddPatient(dto, "1505999122445");
            addPatient.ShowDialog();
        }

        //VIEW PATIENT
        private void Patients_b1_Click(object sender, EventArgs e)
        {
            AddPatient addPatient = new AddPatient(arrPatient[Patients_dgv1.SelectedIndices[0]]);
            addPatient.ShowDialog();
        }

        //SEARCH PATIENTS
        private void Patients_b5_Click(object sender, EventArgs e)
        {
            Patients_dgv1.Items.Clear();
            Patients_dgv1.Refresh();

            for (int i = 0; i < arrPatient.Count(); i++)
            {
                if (arrPatient[i].Id.ToLower().Contains(Patients_tb1.Text.ToLower()) || arrPatient[i].Name.ToLower().Contains(Patients_tb1.Text.ToLower()) || arrPatient[i].Surname.ToLower().Contains(Patients_tb1.Text.ToLower()))
                {
                    string[] elements = { arrPatient[i].Id, arrPatient[i].Name, arrPatient[i].Surname };
                    var arrItems = new ListViewItem(elements);
                    Patients_dgv1.Items.Add(arrItems);
                }
            }
        }

        /*
         ****************************************************************************
         ****************************************************************************
                                        VISITs TAB
         ****************************************************************************
         ****************************************************************************
         */

        private void loadElements_2()
        {
            Visits_dgv1.Items.Clear();
            Visits_dgv1.Refresh();
            this.arrVisit = Program.visitController.select();
            MAX_PAGES_NUMBER_VISIT = arrVisit.Count() / PAGE_VISIT_NUMBER + 1;
            int i;
            for (i = (SELECTED_PAGE_VISIT - 1) * PAGE_VISIT_NUMBER; i < Math.Min(SELECTED_PAGE_VISIT * PAGE_VISIT_NUMBER, this.arrVisit.Count); i++)
            {
                CommonNameSurname patient = arrVisit[i].Patient;
                CommonNameSurname dentist = arrVisit[i].Dentist;
                string patientName = patient.Name + " " + patient.Surname;
                string dentistName = dentist.Name + " " + dentist.Surname;
                string[] elements = { patientName, dentistName, arrVisit[i].Date };
                var arrItems = new ListViewItem(elements);
                Visits_dgv1.Items.Add(arrItems);
            }
        }
        private void Visits_pageD_Click(object sender, EventArgs e)
        {
            if (SELECTED_PAGE_VISIT != 1)
            {
                SELECTED_PAGE_VISIT--;
                loadElements_2();
            }
        }

        private void Visits_pageU_Click(object sender, EventArgs e)
        {
            if (SELECTED_PAGE_VISIT < MAX_PAGES_NUMBER_VISIT)
            {
                SELECTED_PAGE_VISIT++;
                loadElements_2();
            }
        }

        //SEARCH
        private void Visits_b5_Click(object sender, EventArgs e)
        {
            Visits_dgv1.Items.Clear();
            Visits_dgv1.Refresh();

            for (int i = 0; i < arrVisit.Count(); i++)
            {
                string tmpPatient = arrVisit[i].Patient.Name + " " + arrVisit[i].Patient.Surname;
                string tmpDentist = arrVisit[i].Dentist.Name + " " + arrVisit[i].Dentist.Surname;

                if (tmpPatient.ToLower().Contains(Visits_tb1.Text.ToLower()) || tmpDentist.ToLower().Contains(Visits_tb1.Text.ToLower()))
                {
                    CommonNameSurname patient = arrVisit[i].Patient;
                    CommonNameSurname dentist = arrVisit[i].Dentist;
                    string patientName = patient.Name + " " + patient.Surname;
                    string dentistName = dentist.Name + " " + dentist.Surname;
                    string[] elements = { patientName, dentistName, arrVisit[i].Date };
                    var arrItems = new ListViewItem(elements);
                    Patients_dgv1.Items.Add(arrItems);
                }
            }
        }

        //PREVIOUS
        private void Visits_b1_Click(object sender, EventArgs e)
        {
            Visits_dgv1.Items.Clear();
            Visits_dgv1.Refresh();

            for (int i = 0; i < arrVisit.Count(); i++)
            {
                String date = arrVisit[i].Date;
                DateTime dateNow = DateTime.Today;
                if (String.Compare(date, dateNow.ToString("yyyy-MM-dd"), StringComparison.OrdinalIgnoreCase) < 0)
                {
                    string tmpPatient = arrVisit[i].Patient.Name + " " + arrVisit[i].Patient.Surname;
                    string tmpDentist = arrVisit[i].Dentist.Name + " " + arrVisit[i].Dentist.Surname;
                    string[] elements = { tmpPatient, tmpDentist, arrVisit[i].Date };
                    var arrItems = new ListViewItem(elements);
                    Patients_dgv1.Items.Add(arrItems);
                }
            }
        }

        //TODAY
        private void Visits_b2_Click(object sender, EventArgs e)
        {
            Visits_dgv1.Items.Clear();
            Visits_dgv1.Refresh();

            for (int i = 0; i < arrVisit.Count(); i++)
            {
                String date = arrVisit[i].Date;
                DateTime dateNow = DateTime.Today;
                if (String.Compare(date, dateNow.ToString("yyyy-MM-dd"), StringComparison.OrdinalIgnoreCase) == 0)
                {
                    string tmpPatient = arrVisit[i].Patient.Name + " " + arrVisit[i].Patient.Surname;
                    string tmpDentist = arrVisit[i].Dentist.Name + " " + arrVisit[i].Dentist.Surname;
                    string[] elements = { tmpPatient, tmpDentist, arrVisit[i].Date };
                    var arrItems = new ListViewItem(elements);
                    Patients_dgv1.Items.Add(arrItems);
                }
            }
        }

        //VIEW
        private void Visits_b3_Click(object sender, EventArgs e)
        {
            ViewVisit vv = new ViewVisit(this.arrVisit[Visits_dgv1.SelectedIndices[0]]);
            vv.ShowDialog();
        }

        //DELETE
        private void Visits_b4_Click(object sender, EventArgs e)
        {
            bool tmp = Program.visitController.delete(arrVisit[Visits_dgv1.SelectedIndices[0]].Id);
            Program.notification.manageModalResult(this, tmp, 1);
            if (tmp)
                loadElements_2();
        }

        private void Visits_tb1_MouseEnter(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.Show("Search by dentist or patient names. \nReset list with search on empty textbox.", Visits_tb1, 0, 0, VisibleTime);
        }

        /*
         ****************************************************************************
         ****************************************************************************
                                       PERSONAL DATA TAB
         ****************************************************************************
         ****************************************************************************
         */

        private void PersonalData_rb1_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void PersonalData_rb2_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.ColorScheme = new ColorScheme(Primary.Green700, Primary.Green900, Primary.Green500, Accent.Green400, TextShade.WHITE);
        }

        private void PersonalData_rb3_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue900, Primary.Blue500, Accent.Blue400, TextShade.WHITE);
        }

        private void PersonalData_ms1_CheckedChanged(object sender, EventArgs e)
        {
            if (!PersonalData_ms1.Checked)
            {
                PersonalData_ms1.Text = "LIGHT";
                ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
            }
            else
            {
                PersonalData_ms1.Text = "DARK";
                ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
            }
        }

        private void PersonalData_mb1_Click(object sender, EventArgs e)
        {
            Program.theme.save(PersonalData_ms1.Text, PersonalData_rb1.Checked ? PersonalData_rb1.Text : PersonalData_rb2.Checked ? PersonalData_rb2.Text : PersonalData_rb3.Text);
            login.changeTheme();
        }

        /*
         ****************************************************************************
         ****************************************************************************
                                        ADD VISIT TAB
         ****************************************************************************
         ****************************************************************************
         */

        private void AddVisit_combob1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = AddVisit_combob1.SelectedIndex;
            if (index >= 0)
                AddVisit_checkb1.Checked = true;

            else
                AddVisit_checkb1.Checked = false;
        }

        private void AddVisit_b2_Click(object sender, EventArgs e)
        {
            SelectProblem sp = new SelectProblem(this);
            sp.ShowDialog();
        }

        private void AddVisit_b3_Click(object sender, EventArgs e)
        {
            if (AddVisit_lb1.SelectedIndex >= 0 && AddVisit_lb1.SelectedIndex < AddVisit_lb1.Items.Count - 1)
            {
                arrProblem.RemoveAt(AddVisit_lb1.SelectedIndex);
                AddVisit_lb1.Items.RemoveAt(AddVisit_lb1.SelectedIndex);
            }
        }

        private void AddVisit_b4_Click(object sender, EventArgs e)
        {
            SelectTreatment st = new SelectTreatment(this);
            st.ShowDialog();
        }

        private void AddVisit_b5_Click(object sender, EventArgs e)
        {
            if (AddVisit_lb2.SelectedIndex >= 0 && AddVisit_lb2.SelectedIndex < AddVisit_lb2.Items.Count - 1)
            {
                Console.WriteLine(AddVisit_lb2.SelectedIndex);
                arrVisitTreatment.RemoveAt(AddVisit_lb2.SelectedIndex);
                AddVisit_lb2.Items.RemoveAt(AddVisit_lb2.SelectedIndex);
            }
        }

        public void AddSelectedProblems(List<ProblemDTO> arrProblem)
        {
            for (int i = 0; i < arrProblem.Count; i++)
                if (!this.arrProblem.Contains(arrProblem[i]))
                    this.arrProblem.Add(arrProblem[i]);

            AddVisit_lb1.Items.Clear();
            foreach(ProblemDTO i in this.arrProblem)
                AddVisit_lb1.Items.Add(new MaterialListBoxItem(i.TypeProblemDto.Name + (i.Tooth == -1 ? "" : " " + i.Tooth)));

            AddVisit_lb1.Items.Add(new MaterialListBoxItem(""));
        }

        public void AddSelectedTreatments(List<VisitTreatmentDTO> arrVisitTreatment)
        {
            for (int i = 0; i < arrVisitTreatment.Count; i++)
                if (!this.arrVisitTreatment.Contains(arrVisitTreatment[i]))
                    this.arrVisitTreatment.Add(arrVisitTreatment[i]);

            AddVisit_lb2.Items.Clear();
            foreach (VisitTreatmentDTO i in this.arrVisitTreatment)
                AddVisit_lb2.Items.Add(new MaterialListBoxItem(i.TreatmentDTO.Name));

            AddVisit_lb2.Items.Add(new MaterialListBoxItem(""));
        }

        //ADD VISIT
        private void AddVisit_b6_Click(object sender, EventArgs e)
        {
            VisitDTO dto = new VisitDTO(-1, this.arrPatient[AddVisit_combob1.SelectedIndex].Id, DateTime.Today.ToString("yyyy-MM-dd"), Program.dto.Id);
            bool flag = Program.visitController.insert(dto, this.arrVisitTreatment, this.arrProblem);
            Program.notification.manageModalResult(this, flag, 1);

            if (flag)
            {
                AddVisit_checkb1.Checked = false;
                AddVisit_combob1.SelectedIndex = -1;
                AddVisit_lb1.Items.Clear();
                AddVisit_lb2.Items.Clear();
            }
        }

        private void loadElements_3()
        {
            this.arrPatient = Program.patientController.select();

            AddVisit_combob1.Items.Clear();
            foreach (PatientDTO i in this.arrPatient)
                AddVisit_combob1.Items.Add(i.Name + " " + i.Surname);
        }

        //ADD PATIENT
        private void AddVisit_b1_Click(object sender, EventArgs e)
        {
            AddPatient ap = new AddPatient();
            ap.ShowDialog();
            loadElements_3();
        }

        /*
         ****************************************************************************
         ****************************************************************************
                                           GLOBAL
         ****************************************************************************
         ****************************************************************************
         */
        private void View_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (View.SelectedTab == View.TabPages["tabPage1"])
            {
                loadElements_1();
            }
            else if (View.SelectedTab == View.TabPages["tabPage2"])
            {
                loadElements_2();
            }
            else if (View.SelectedTab == View.TabPages["tabPage4"])
            {
                PersonalData_tb1.Text = Program.dto.Id;
                PersonalData_tb2.Text = Program.dto.Name;
                PersonalData_tb3.Text = Program.dto.Surname;
                PersonalData_tb4.Text = Program.dto.Email;
                PersonalData_tb5.Text = Program.dto.Phone;
                PersonalData_tb6.Text = Program.dto.Address;
                PersonalData_tb7.Text = Program.dto.Username;
                PersonalData_tb8.Text = Program.dto.JobStart;
            }
            else if (View.SelectedTab == View.TabPages["tabPage3"])
            {
                loadElements_3();
            }
            else if (View.SelectedTab == View.TabPages["tabPage5"])
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Logout", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Dispose();
                    login.Show();
                }
                else
                {
                    View.SelectedIndex = 0;
                    View.SelectedTab.Show();
                }
            }
        }

        private void ni1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            ni1.Visible = false;
        }

        private void configure()
        {
            //Personal Data
            PersonalData_ms1.Checked = Program.theme.DefaultTheme == MaterialSkinManager.Themes.LIGHT ? false : true;

//            Patients_dgv1.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
//            Patients_dgv1.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
//            Patients_dgv1.Columns[2].HeaderCell.Style.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);

//          Visits_dgv1.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
//          Visits_dgv1.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
//          Visits_dgv1.Columns[2].HeaderCell.Style.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
        }

        
    }
}
