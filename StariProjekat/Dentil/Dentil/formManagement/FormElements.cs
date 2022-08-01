using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentil.formManagement
{
    public class FormElements
    {
        public static List<Control> filterFormControls(Control.ControlCollection coll)
        {
            List <Control> arr = new List<Control> ();
            foreach (Control c in coll)
            {
                arr.Add(c);

                //this will grow as i write the program and know which type i need to look deeper
                if ( c is TableLayoutPanel)
                    foreach (Control cc in ((TableLayoutPanel)c).Controls)
                        arr.Add(cc);
            }

            return arr;
        }
    }
}
