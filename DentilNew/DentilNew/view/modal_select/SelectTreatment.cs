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

namespace DentilNew.view.modal_select
{
    public partial class SelectTreatment : MaterialForm
    {
        private List<TreatmentDTO> arrTreatment = new List<TreatmentDTO>();
        private Main main = null;

        public SelectTreatment(Main main)
        {
            InitializeComponent();
            loadElements();
            changeTheme();
            this.main = main;
        }

        public void changeTheme()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = Program.theme.DefaultTheme;
            materialSkinManager.ColorScheme = Program.theme.DefaultColorPalette;
        }

        private void loadElements()
        {
            lb1.Items.Clear();
            this.arrTreatment = Program.treatmentController.select();

            foreach (TreatmentDTO i in this.arrTreatment)
                lb1.Items.Add(new MaterialSkin.MaterialListBoxItem(i.Name));

            lb1.Items.Add(new MaterialSkin.MaterialListBoxItem(""));
        }

        private void b1_Click(object sender, EventArgs e)
        {
            List<VisitTreatmentDTO> arrVisitTreatment = new List<VisitTreatmentDTO>();
            if (lb1.SelectedIndex >=0 && lb1.SelectedIndex < lb1.Items.Count - 1)
                arrVisitTreatment.Add(new VisitTreatmentDTO(arrTreatment[lb1.SelectedIndex], mtb1.Text));

            this.main.AddSelectedTreatments(arrVisitTreatment);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Treatment treatment = new Treatment();
            treatment.ShowDialog();
            loadElements();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lb1.SelectedIndex >= 0 && lb1.SelectedIndex < lb1.Items.Count - 1)
            {
                bool flag = Program.treatmentController.delete(this.arrTreatment[lb1.SelectedIndex].Id);
                Program.notification.manageModalResult(this, flag, 1);

                if (flag)
                    lb1.Items.RemoveAt(lb1.SelectedIndex);

                loadElements();
            }
        }
    }
}
