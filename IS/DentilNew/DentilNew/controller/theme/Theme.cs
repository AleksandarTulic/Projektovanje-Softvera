using DentilNew.model.fileManagement;
using DentilNew.model.logger;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentilNew.model.theme
{
    internal class Theme
    {
        private Dictionary<string, ColorScheme> colorPalette = new Dictionary<string, ColorScheme>();
        private Dictionary<string, MaterialSkinManager.Themes> theme = new Dictionary<string, MaterialSkinManager.Themes>();
        private ColorScheme defaultColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        private MaterialSkinManager.Themes defaultTheme = MaterialSkinManager.Themes.LIGHT;
        private string themePath = "..\\..\\controller\\theme\\conf\\theme.txt";
        private string colorPalettePath = "..\\..\\controller\\theme\\conf\\colorPalette.txt";

        public Theme()
        {
            loadColorPalettes();
            loadThemes();
            loadConfig();
        }

        private void loadConfig()
        {
            try
            {
                string theme = FileOperations.getAllLines(themePath)[0];
                string colorPalette = FileOperations.getAllLines(colorPalettePath)[0];

                defaultColorScheme = this.colorPalette[colorPalette];
                defaultTheme = this.theme[theme];
            }
            catch (Exception ex)
            {
                MyLogger.Logger.log(ex.Message);
            }
        }

        private void loadColorPalettes()
        {
            colorPalette.Add("BlueGrey", new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE));
            colorPalette.Add("Blue", new ColorScheme(Primary.Blue700, Primary.Blue900, Primary.Blue500, Accent.Blue400, TextShade.WHITE));
            colorPalette.Add("Green", new ColorScheme(Primary.Green700, Primary.Green900, Primary.Green500, Accent.Green400, TextShade.WHITE));
        }

        private void loadThemes()
        {
            theme.Add("LIGHT", MaterialSkinManager.Themes.LIGHT);
            theme.Add("DARK", MaterialSkinManager.Themes.DARK);
        }

        public void save(string theme, string colorPalette)
        {
            List<string> arrTheme = new List<string>() { theme };
            List<string> arrColorPalette = new List<string>() { colorPalette };

            FileOperations.saveLines(arrTheme, themePath);
            FileOperations.saveLines(arrColorPalette, colorPalettePath);

            loadConfig();
        }

        public MaterialSkinManager.Themes DefaultTheme
        {
            get { return defaultTheme; }
        }

        public ColorScheme DefaultColorPalette
        {
            get { return defaultColorScheme; }
        }

        public bool setValue(string value)
        {
            if (colorPalette[value] == DefaultColorPalette)
                return true;

            return false;
        }
    }
}
