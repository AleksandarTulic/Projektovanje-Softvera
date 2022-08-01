using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentil.forms.common
{
    public class Common
    {
        protected Panel p = null;

        public Common()
        {
            p = new Panel();
        }

        public void setVisibility(bool flag)
        {
            p.Visible = flag;
        }
    }
}
