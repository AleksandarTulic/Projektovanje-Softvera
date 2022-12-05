using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentilNew.model.notification
{
    internal class Notification
    {
        public void manageModalResult(MaterialForm form, bool flag, int idMessage)
        {
            if (!flag)
                MessageBox.Show("Operation not possible. \nCheck the possible parameter values in help.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Operation successfull.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
