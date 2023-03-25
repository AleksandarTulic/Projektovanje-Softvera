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
    public partial class SelectProblem : MaterialForm
    {
        private List<int> arrTooth = new List<int>();
        private List<TypeProblemDTO> arrTypeProblem = new List<TypeProblemDTO>();
        private Main main = null;

        public SelectProblem(Main main)
        {
            InitializeComponent();
            loadElements();
            this.main = main;
            changeTheme();
        }

        private void changeTheme()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = Program.theme.DefaultTheme;
            materialSkinManager.ColorScheme = Program.theme.DefaultColorPalette;
        }

        private void loadElements()
        {
            arrTooth = Program.toothController.select();
            arrTypeProblem = Program.typeProblemController.select();

            lb1.Items.Clear();
            lb2.Items.Clear();

            for (int i = 0; i < arrTypeProblem.Count; i++)
                lb1.Items.Add(new MaterialListBoxItem(arrTypeProblem[i].Name));

            lb1.Items.Add(new MaterialListBoxItem(""));
            for (int i = 0; i < arrTooth.Count; i++)
            {
                lb2.Items.Add(new MaterialListBoxItem(arrTooth[i] + ""));
                //Console.WriteLine(i + " " + arrTooth[i]);
            }
            lb2.Items.Add(new MaterialListBoxItem(""));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TypeProblem typeProblem = new TypeProblem();
            typeProblem.ShowDialog();
            loadElements();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lb1.SelectedIndex >= 0)
            {
                bool flag = Program.typeProblemController.delete(arrTypeProblem[lb1.SelectedIndex].Id);
                Program.notification.manageModalResult(this, flag, 1);
                loadElements();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tooth tooth = new Tooth();
            tooth.ShowDialog();
            loadElements();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lb2.SelectedIndex >= 0)
            {
                bool flag = Program.toothController.delete(arrTooth[lb2.SelectedIndex]);
                Program.notification.manageModalResult(this, flag, 1);
                loadElements();
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            List<ProblemDTO> arrProblem = new List<ProblemDTO>();
            if (lb1.Items.Count - 1 != lb1.SelectedIndex && lb1.SelectedIndex >= 0)
                arrProblem.Add(new ProblemDTO(arrTypeProblem[lb1.SelectedIndex], lb2.SelectedIndex >= 0 ? arrTooth[lb2.SelectedIndex] : -1));
            main.AddSelectedProblems(arrProblem);
            this.Close();
        }
    }
}
