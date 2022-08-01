using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentil.renderer
{
    public class MenuRenderer : ToolStripProfessionalRenderer
    {
        public MenuRenderer() : base(new MyColors()) { }
    }

    public class MyColors : ProfessionalColorTable
    {
        public override Color MenuItemSelected
        {
            get { return ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]); }
        }

        public override Color MenuItemSelectedGradientBegin
        {
            get { return ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]); }
        }

        public override Color MenuItemSelectedGradientEnd
        {
            get { return ColorTranslator.FromHtml(Program.theme.ColTheme.Arr[2]); }
        }
    }
}
