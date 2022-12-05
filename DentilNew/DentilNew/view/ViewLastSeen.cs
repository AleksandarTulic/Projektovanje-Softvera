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

namespace DentilNew.view
{
    public partial class ViewLastSeen : MaterialForm
    {
        private int idVisit;
        private List<LastSeenDTO> arrLastSeen = new List<LastSeenDTO>();

        public ViewLastSeen(int idVisit)
        {
            this.idVisit = idVisit;
            InitializeComponent();
            changeTheme();
            configure();
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
            lv1.Items.Clear();

            this.arrLastSeen = Program.lastSeenController.select(idVisit);
            foreach (LastSeenDTO i in this.arrLastSeen)
            {
                string[] elements = { i.Name, i.Surname, i.DateWhen, i.TimeWhen};
                var arrItems = new ListViewItem(elements);
                lv1.Items.Add(arrItems);
            }
        }
    }
}
