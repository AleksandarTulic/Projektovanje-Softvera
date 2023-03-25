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
using System.IO;
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
        private List<int> tmpArrPatient = new List<int>();
        private static readonly int PAGE_PATIENT_NUMBER = 3;
        private static int SELECTED_PAGE_PATIENT = 1;
        private static int MAX_PAGES_NUMBER_PATIENT = 1;
        
        //Visits
        private List<VisitDTO> arrVisit = new List<VisitDTO>();
        private List<int> tmpArrVisit = new List<int>();
        private static readonly int PAGE_VISIT_NUMBER = 3;
        private static int SELECTED_PAGE_VISIT = 1;
        private static int MAX_PAGES_NUMBER_VISIT = 1;

        //Add Visit
        private List<ProblemDTO> arrProblem = new List<ProblemDTO>();
        private List<VisitServiceDTO> arrVisitTreatment = new List<VisitServiceDTO>();

        public Main(Login login)
        {
            this.login = login;

            InitializeComponent();
            changeTheme();
            configure();
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

        private void loadElements_1(bool flag, bool returnToStart)
        {
            Patients_dgv1.Items.Clear();
            Patients_dgv1.Refresh();
            this.arrPatient = Program.patientController.select();

            if (flag)
            {
                this.tmpArrPatient.Clear();
                for (int i = 0; i < this.arrPatient.Count; i++)
                    this.tmpArrPatient.Add(i);
            }

            SELECTED_PAGE_PATIENT = returnToStart ? 1 : SELECTED_PAGE_PATIENT;
            Patients_pageD.Enabled = !returnToStart;

            MAX_PAGES_NUMBER_PATIENT = this.tmpArrPatient.Count % PAGE_PATIENT_NUMBER == 0 ? this.tmpArrPatient.Count() / PAGE_PATIENT_NUMBER : this.tmpArrPatient.Count() / PAGE_PATIENT_NUMBER + 1;
            for(int i = (SELECTED_PAGE_PATIENT - 1) * PAGE_PATIENT_NUMBER; i < Math.Min(SELECTED_PAGE_PATIENT * PAGE_PATIENT_NUMBER, this.tmpArrPatient.Count); i++)
            {
                string[] elements = { arrPatient[this.tmpArrPatient[i]].Id, arrPatient[this.tmpArrPatient[i]].Name, arrPatient[this.tmpArrPatient[i]].Surname};
                var arrItems = new ListViewItem(elements);
                Patients_dgv1.Items.Add(arrItems);
            }

            Patients_pageU.Enabled = SELECTED_PAGE_PATIENT != MAX_PAGES_NUMBER_PATIENT;
        }


        private void Patients_pageD_Click(object sender, EventArgs e)
        {
            if (SELECTED_PAGE_PATIENT != 1)
            {
                if (SELECTED_PAGE_PATIENT < MAX_PAGES_NUMBER_PATIENT)
                    Patients_pageU.Enabled = true;
                SELECTED_PAGE_PATIENT--;
                loadElements_1(false, false);

                if (SELECTED_PAGE_PATIENT == 1)
                    Patients_pageD.Enabled = false;
            }
        }

        private void Patients_pageU_Click(object sender, EventArgs e)
        {
            if (SELECTED_PAGE_PATIENT < MAX_PAGES_NUMBER_PATIENT)
            {
                Patients_pageD.Enabled = true;
                SELECTED_PAGE_PATIENT++;
                loadElements_1(false, false);

                if (SELECTED_PAGE_PATIENT == MAX_PAGES_NUMBER_PATIENT)
                    Patients_pageU.Enabled = false;
            }
        }

        //ADD PATIENT
        private void Patients_b2_Click(object sender, EventArgs e)
        {
            SinglePatient addPatient = new SinglePatient();
            addPatient.ShowDialog();

            //someone added a patient
            //of course it can be that a patient wasn't added but we will call this non the less
            //we will change it if we have more time
            this.loadElements_1(true, true);
        }

        //DELETE PATIENT
        private void Patients_b3_Click(object sender, EventArgs e)
        {
            if (Patients_dgv1.SelectedIndices == null || Patients_dgv1.SelectedIndices.Count <= 0 || Patients_dgv1.SelectedIndices[0] >= Math.Min(PAGE_PATIENT_NUMBER, this.tmpArrPatient.Count))
                Program.notification.manageModalResult(this, false, 1);
            else if (Patients_dgv1.SelectedIndices != null && Patients_dgv1.SelectedIndices[0] < Math.Min(PAGE_PATIENT_NUMBER, this.tmpArrPatient.Count))
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete patient", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bool tmp = Program.patientController.delete(this.arrPatient[((SELECTED_PAGE_PATIENT - 1) * PAGE_PATIENT_NUMBER) + this.tmpArrPatient[Patients_dgv1.SelectedIndices[0]]].Id);
                    Program.notification.manageModalResult(this, tmp, 1);
                    if (tmp)
                        loadElements_1(true, true);
                }
            }
            
        }

        //UPDATE PATIENT
        private void Patients_b4_Click(object sender, EventArgs e)
        {
            if (Patients_dgv1.SelectedIndices == null || Patients_dgv1.SelectedIndices.Count <= 0 || Patients_dgv1.SelectedIndices[0] >= Math.Min(PAGE_PATIENT_NUMBER, this.tmpArrPatient.Count))
                Program.notification.manageModalResult(this, false, 1);
            else if (Patients_dgv1.SelectedIndices != null && Patients_dgv1.SelectedIndices[0] < Math.Min(PAGE_PATIENT_NUMBER, this.tmpArrPatient.Count))
            {
                SinglePatient addPatient = new SinglePatient(this.arrPatient[((SELECTED_PAGE_PATIENT - 1) * PAGE_PATIENT_NUMBER) + this.tmpArrPatient[Patients_dgv1.SelectedIndices[0]]],
                    this.arrPatient[((SELECTED_PAGE_PATIENT - 1) * PAGE_PATIENT_NUMBER) + this.tmpArrPatient[Patients_dgv1.SelectedIndices[0]]].Id);
                addPatient.ShowDialog();

                loadElements_1(true, true);
            }
        }

        //VIEW PATIENT
        private void Patients_b1_Click(object sender, EventArgs e)
        {
            if (Patients_dgv1.SelectedIndices == null || Patients_dgv1.SelectedIndices.Count <= 0 || Patients_dgv1.SelectedIndices[0] > Math.Min(PAGE_PATIENT_NUMBER, this.tmpArrPatient.Count))
                Program.notification.manageModalResult(this, false, 1);
            else if (Patients_dgv1.SelectedIndices != null && Patients_dgv1.SelectedIndices[0] < Math.Min(PAGE_PATIENT_NUMBER, this.tmpArrPatient.Count))
            {
                SinglePatient addPatient = new SinglePatient(this.arrPatient[((SELECTED_PAGE_PATIENT - 1) * PAGE_PATIENT_NUMBER) + this.tmpArrPatient[Patients_dgv1.SelectedIndices[0]]]);
                addPatient.ShowDialog();
            }
        }

        //SEARCH PATIENTS
        private void Patients_b5_Click(object sender, EventArgs e)
        {
            Patients_dgv1.Items.Clear();
            Patients_dgv1.Refresh();

            this.tmpArrPatient.Clear();
            for (int i = 0; i < arrPatient.Count(); i++)
                if (arrPatient[i].Id.ToLower().Contains(Patients_tb1.Text.ToLower()) || arrPatient[i].Name.ToLower().Contains(Patients_tb1.Text.ToLower()) || arrPatient[i].Surname.ToLower().Contains(Patients_tb1.Text.ToLower()))
                    this.tmpArrPatient.Add(i);

            loadElements_1(false, true);
        }

        /*
         ****************************************************************************
         ****************************************************************************
                                        VISITs TAB
         ****************************************************************************
         ****************************************************************************
         */

        private void loadElements_2(bool flag, bool returnToStart)
        {
            Visits_dgv1.Items.Clear();
            Visits_dgv1.Refresh();
            this.arrVisit = Program.visitController.select();
            
            if (flag)
            {
                this.tmpArrVisit.Clear();
                for (int i = 0; i < this.arrVisit.Count; i++)
                    this.tmpArrVisit.Add(i);
            }

            SELECTED_PAGE_VISIT = returnToStart ? 1 : SELECTED_PAGE_VISIT;
            Visits_pageD.Enabled = returnToStart ? false : true;

            MAX_PAGES_NUMBER_VISIT = this.tmpArrVisit.Count % PAGE_VISIT_NUMBER == 0 ? this.tmpArrVisit.Count() / PAGE_VISIT_NUMBER : this.tmpArrVisit.Count() / PAGE_VISIT_NUMBER + 1;
            for (int i = (SELECTED_PAGE_VISIT - 1) * PAGE_VISIT_NUMBER; i < Math.Min(SELECTED_PAGE_VISIT * PAGE_VISIT_NUMBER, this.tmpArrVisit.Count); i++)
            {
                CommonNameSurname patient = arrVisit[this.tmpArrVisit[i]].Patient;
                CommonNameSurname dentist = arrVisit[this.tmpArrVisit[i]].Dentist;
                string patientName = patient.Name + " " + patient.Surname;
                string dentistName = dentist.Name + " " + dentist.Surname;
                //Console.WriteLine(patientName + " " + dentistName + ", Redni Broj: " + this.tmpArrVisit[i]);
                string[] elements = { patientName, dentistName, arrVisit[this.tmpArrVisit[i]].Date };
                var arrItems = new ListViewItem(elements);
                Visits_dgv1.Items.Add(arrItems);
            }

            Visits_pageU.Enabled = SELECTED_PAGE_VISIT != MAX_PAGES_NUMBER_VISIT;
        }
        private void Visits_pageD_Click(object sender, EventArgs e)
        {
            if (SELECTED_PAGE_VISIT != 1)
            {
                if (SELECTED_PAGE_VISIT < MAX_PAGES_NUMBER_VISIT)
                    Visits_pageU.Enabled = true;
                SELECTED_PAGE_VISIT--;
                loadElements_2(false, false);

                if (SELECTED_PAGE_VISIT == 1)
                    Visits_pageD.Enabled = false;
            }

        }

        private void Visits_pageU_Click(object sender, EventArgs e)
        {
            if (SELECTED_PAGE_VISIT < MAX_PAGES_NUMBER_VISIT)
            {
                Visits_pageD.Enabled = true;
                SELECTED_PAGE_VISIT++;
                loadElements_2(false, false);

                if (SELECTED_PAGE_VISIT == MAX_PAGES_NUMBER_VISIT)
                    Visits_pageU.Enabled = false;
            }
        }

        //SEARCH
        private void Visits_b5_Click(object sender, EventArgs e)
        {
            this.tmpArrVisit.Clear();
            Visits_dgv1.Items.Clear();
            Visits_dgv1.Refresh();

            this.tmpArrVisit.Clear();
            for (int i = 0; i < arrVisit.Count(); i++)
            {
                string tmpPatient = arrVisit[i].Patient.Name + " " + arrVisit[i].Patient.Surname;
                string tmpDentist = arrVisit[i].Dentist.Name + " " + arrVisit[i].Dentist.Surname;

                if (tmpPatient.ToLower().Contains(Visits_tb1.Text.ToLower()) || tmpDentist.ToLower().Contains(Visits_tb1.Text.ToLower()))
                    this.tmpArrVisit.Add(i);
            }

            loadElements_2(false, true);
        }

        //PREVIOUS
        private void Visits_b1_Click(object sender, EventArgs e)
        {
            Visits_dgv1.Items.Clear();
            Visits_dgv1.Refresh();

            this.tmpArrVisit.Clear();
            for (int i = 0; i < arrVisit.Count(); i++)
            {
                String date = arrVisit[i].Date;
                DateTime dateNow = DateTime.Today;
                if (String.Compare(date, dateNow.ToString("yyyy-MM-dd"), StringComparison.OrdinalIgnoreCase) < 0)
                    this.tmpArrVisit.Add(i);
            }

            loadElements_2(false, true);
        }

        //TODAY
        private void Visits_b2_Click(object sender, EventArgs e)
        {
            Visits_dgv1.Items.Clear();
            Visits_dgv1.Refresh();

            this.tmpArrVisit.Clear();
            for (int i = 0; i < arrVisit.Count(); i++)
            {
                String date = arrVisit[i].Date;
                DateTime dateNow = DateTime.Today;
                if (String.Compare(date, dateNow.ToString("yyyy-MM-dd"), StringComparison.OrdinalIgnoreCase) == 0)
                    this.tmpArrVisit.Add(i);
            }

            loadElements_2(false, true);
        }

        //VIEW
        private void Visits_b3_Click(object sender, EventArgs e)
        {
            if (Visits_dgv1.SelectedIndices == null || Visits_dgv1.SelectedIndices.Count <= 0)
                Program.notification.manageModalResult(this, false, 1);
            else if (Visits_dgv1.SelectedIndices != null && Visits_dgv1.SelectedIndices[0] < Math.Min(PAGE_VISIT_NUMBER, this.tmpArrVisit.Count))
            {
                ViewVisit vv = new ViewVisit(this.arrVisit[this.tmpArrVisit[((SELECTED_PAGE_VISIT - 1) * PAGE_VISIT_NUMBER) + Visits_dgv1.SelectedIndices[0]]]);
                vv.ShowDialog();
            }
        }

        //DELETE
        private void Visits_b4_Click(object sender, EventArgs e)
        {
            if (Visits_dgv1.SelectedIndices == null || Visits_dgv1.SelectedIndices.Count <= 0 || Visits_dgv1.SelectedIndices[0] >= Math.Min(PAGE_VISIT_NUMBER, this.tmpArrVisit.Count))
                Program.notification.manageModalResult(this, false, 1);
            else if (Visits_dgv1.SelectedIndices != null && Visits_dgv1.SelectedIndices[0] < Math.Min(PAGE_VISIT_NUMBER, this.tmpArrVisit.Count))
            {
                bool tmp = Program.visitController.delete(this.arrVisit[this.tmpArrVisit[((SELECTED_PAGE_VISIT - 1) * PAGE_VISIT_NUMBER) + Visits_dgv1.SelectedIndices[0]]].Id);
                Program.notification.manageModalResult(this, tmp, 1);
                if (tmp)
                    loadElements_2(true, true);
            }
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
            SelectServices st = new SelectServices(this);
            st.ShowDialog();
        }

        private void AddVisit_b5_Click(object sender, EventArgs e)
        {
            if (AddVisit_lb2.SelectedIndex >= 0 && AddVisit_lb2.SelectedIndex < AddVisit_lb2.Items.Count - 1)
            {
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

        public void AddSelectedTreatments(List<VisitServiceDTO> arrVisitTreatment)
        {
            for (int i = 0; i < arrVisitTreatment.Count; i++)
                if (!this.arrVisitTreatment.Contains(arrVisitTreatment[i]))
                    this.arrVisitTreatment.Add(arrVisitTreatment[i]);

            AddVisit_lb2.Items.Clear();
            foreach (VisitServiceDTO i in this.arrVisitTreatment)
                AddVisit_lb2.Items.Add(new MaterialListBoxItem(i.TreatmentDTO.Name));

            AddVisit_lb2.Items.Add(new MaterialListBoxItem(""));
        }

        //ADD VISIT
        private void AddVisit_b6_Click(object sender, EventArgs e)
        {
            if (AddVisit_checkb1.Checked)
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

                    this.arrVisitTreatment.Clear();
                    this.arrProblem.Clear();
                }
            }
            else
                Program.notification.manageModalResult(this, false, 1);
        }

        private void loadElements_3()
        {
            AddVisit_checkb1.Checked = false;
            AddVisit_combob1.SelectedIndex = -1;
            this.arrPatient = Program.patientController.select();

            AddVisit_combob1.Items.Clear();
            foreach (PatientDTO i in this.arrPatient)
                AddVisit_combob1.Items.Add(i.Name + " " + i.Surname);
        }

        //ADD PATIENT
        private void AddVisit_b1_Click(object sender, EventArgs e)
        {
            SinglePatient ap = new SinglePatient();
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
                loadElements_1(true, false);
            }
            else if (View.SelectedTab == View.TabPages["tabPage2"])
            {
                loadElements_2(true, false);
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
            }else if(View.SelectedTab == View.TabPages["tabPage6"])
            {
                mrtbHelp.Clear();
                mrtbHelp.Text = "WELCOME TO HELP WIZARD";
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
            //Patients
            loadElements_1(true, true); //first tab is opened on default
            Patients_pageD.Enabled = false;

            //Personal Data
            PersonalData_ms1.Checked = Program.theme.DefaultTheme == MaterialSkinManager.Themes.LIGHT ? false : true;
            PersonalData_rb1.Checked = Program.theme.setValue(PersonalData_rb1.Text);
            PersonalData_rb2.Checked = Program.theme.setValue(PersonalData_rb2.Text);
            PersonalData_rb3.Checked = Program.theme.setValue(PersonalData_rb3.Text);
            PersonalData_tb1.Text = Program.dto.Id;
            PersonalData_tb2.Text = Program.dto.Name;
            PersonalData_tb3.Text = Program.dto.Surname;
            PersonalData_tb4.Text = Program.dto.Email;
            PersonalData_tb5.Text = Program.dto.Phone;
            PersonalData_tb6.Text = Program.dto.Address;
            PersonalData_tb7.Text = Program.dto.Username;
            PersonalData_tb8.Text = Program.dto.JobStart;

            //Visits
            Visits_pageD.Enabled = false;
            mrtbHelp.Text = "WELCOME TO HELP WIZARD";
        }

        private void mbtnRecovery_Click(object sender, EventArgs e)
        {
            RecoveryPatient rp = new RecoveryPatient();
            rp.ShowDialog();

            loadElements_1(true, true);
        }

        private void helpButtonAction(object sender, EventArgs e)
        {
            String path = Directory.GetCurrentDirectory() + @"\..\..\help\";
            mrtbHelp.Clear();
            string labelText = ((MaterialButton)sender).Text;
            List<String> text = new List<string>();

            if (labelText.Equals("Patients"))
                text = model.fileManagement.FileOperations.getAllLines(path + labelText.ToLower() + ".txt");
            else if (labelText.Equals("Visits"))
                text = model.fileManagement.FileOperations.getAllLines(path + labelText.ToLower() + ".txt");
            else if (labelText.Equals("Add Visit"))
                text = model.fileManagement.FileOperations.getAllLines(path + labelText.Replace(" ", "").ToLower() + ".txt");
            else if (labelText.Equals("Personal Data"))
                text = model.fileManagement.FileOperations.getAllLines(path + labelText.Replace(" ", "").ToLower() + ".txt");
            else if (labelText.Equals("Logout"))
                text = model.fileManagement.FileOperations.getAllLines(path + labelText.ToLower() + ".txt");

            foreach (String str in text)
                mrtbHelp.Text += str + '\n';

        }
    }
}
