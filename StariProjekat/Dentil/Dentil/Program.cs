using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentil
{
    internal static class Program
    {
        public static language.Language lang = new language.Language(); //remembering all words for all languages
        public static readonly string defaultLang = "ENG"; //default language
        public static readonly dbManagement.Connection defaultCon = new dbManagement.Connection(); //for storing info for connection on one place
        public static theme.Theme theme = new theme.Theme();
        public static user.User user = null;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
