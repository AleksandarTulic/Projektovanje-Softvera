using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentil.theme
{
    public class Theme
    {
        Dictionary<string, string> map = new Dictionary<string, string>()
        {
            {"Font", $"{Directory.GetCurrentDirectory()}\\..\\..\\theme\\currFont.txt" },
            {"Theme", $"{Directory.GetCurrentDirectory()}\\..\\..\\theme\\currTheme.txt" },
            {"Themes", $"{Directory.GetCurrentDirectory()}\\..\\..\\theme\\confTheme.txt" },
            {"Fonts", $"{Directory.GetCurrentDirectory()}\\..\\..\\theme\\confFont.txt" }
        };

        ColorTheme colTheme = null; 
        string font = "";

        int numTheme = 0;
        int numFont = 0;

        List <string> fonts = new List<string>();
        List<ColorTheme> themes = new List<ColorTheme>();

        public Theme()
        {
            input();
        }

        public void changeTheme(string font, int theme)
        {
            List <string> arr = new List<string> ();
            arr.Add (font);
            fileManagement.FileOperations.writeAllLines(arr, map["Font"]);

            arr.Clear ();

            arr.Add(themes[theme].ToString());
            fileManagement.FileOperations.writeAllLines(arr, map["Theme"]);

            input();

            //Console.WriteLine("Theme: " + font + ", " + fonts.Count + ", ");
        }

        public void input()
        {
            fonts.Clear();
            themes.Clear();

            font = getElements("Font")[0];
            colTheme = new ColorTheme(getElements("Theme")[0]);

            fonts = getElements("Fonts");
            List<string> t = getElements("Themes");

            //Console.WriteLine("Theme: " + font + ", " + fonts.Count + ", " + t.Count);

            foreach (string i in t)
                themes.Add(new ColorTheme(i));

            //Console.WriteLine("Theme: " + font + ", " + fonts.Count + ", " + t.Count);

            for (int i = 0; i < fonts.Count; i++)
                if (fonts[i].Equals(font))
                {
                    numFont = i;
                    break;
                }

            for (int i = 0; i < themes.Count; i++)
                if (themes[i].Equals(colTheme))
                {
                    numTheme = i;
                    break;
                }
        }

        public List<string> getElements(string what)
        {
            return fileManagement.FileOperations.getAllLines(map[what]);
        }

        public string Font
        {
            get { return font; }
            set { font = value; }
        }

        public ColorTheme ColTheme
        {
            get { return colTheme; }
            set { colTheme = value; }
        }

        public int NumTheme
        {
            get { return numTheme; }
            set { numTheme = value; }
        }

        public int NumFont
        {
            get { return numFont; }
            set { numFont = value; }
        }

        public List<ColorTheme> ColorThemes
        {
            get { return themes; }
            set { themes = value; }
        }

        public List<string> Fonts
        {
            get { return fonts; }
            set { fonts = value; }
        }
    }
}
