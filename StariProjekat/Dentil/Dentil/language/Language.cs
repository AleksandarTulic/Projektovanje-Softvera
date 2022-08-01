using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentil.language
{
    public class Language
    {
        Dictionary<string, List<string> > langMap = new Dictionary<string, List<string>>();

        string currLang = "ENG";

        public Language()
        {
            List <string> arr = fileManagement.FileOperations.getAllLines($"{Directory.GetCurrentDirectory()}\\..\\..\\language\\language.txt");

            string []indexLang = arr[0].Split(';');

            //not using foreach because i skip 0 index
            for (int i = 1; i < arr.Count; i++)
            {
                string []valueLang = arr[i].Split(';');

                if ( i == 1)
                    for (int j = 0; j < valueLang.Length; j++)
                        langMap[indexLang[j]] = new List<string>();

                for (int j = 0; j < valueLang.Length; j++)
                    langMap[indexLang[j]].Add(valueLang[j]);
            }

            //currLang = fileManagement.FileOperations.getAllLines($"{Directory.GetCurrentDirectory()}\\..\\..\\language\\conf.txt")[0];
        }

        [Obsolete("Used in early development, we couldn't change items such as in menu.")]
        public void translate(List <Control> coll, string lang)
        {
            foreach (Control c in coll)
            {
                if (langMap[currLang].Contains(c.Text))
                {
                    int index = langMap[currLang].FindIndex(x => x.Equals(c.Text));
                    c.Text = langMap[lang][index];
                }
            }

            fileManagement.FileOperations.writeAllLines(new List<string>(){ lang}, $"{Directory.GetCurrentDirectory()}\\..\\..\\language\\conf.txt");
            currLang = lang;
        }

        public string translate(string word, string lang)
        {
            int index = langMap[currLang].FindIndex(x => x.Equals(word));

            return langMap[lang][index];
        }

        public string translate(string word, string curr, string want)
        {
            //Console.WriteLine(word + " " + curr + " " + want);

            int index = langMap[curr].FindIndex(x => x.Equals(word));

            if (index < 0)
                return word;
            else
                return langMap[want][index];
            //return index < 0 ? word : langMap[want][index];
        }

        public void addLangItems(ref ComboBox cb)
        {
            string getCurr = fileManagement.FileOperations.getAllLines($"{Directory.GetCurrentDirectory()}\\..\\..\\language\\conf.txt")[0];

            List<string> keys = langMap.Keys.ToList();
            for (int i = 0;i < keys.Count; i++){
                cb.Items.Add(keys[i]);

                if (keys[i].Equals(getCurr))
                    cb.SelectedIndex = i;
            }

            currLang = getCurr;
        }

        public string CurrLang
        {
            get { return currLang; }
            set 
            {
                currLang = value;
                fileManagement.FileOperations.writeAllLines(new List<string>() { currLang}, $"{Directory.GetCurrentDirectory()}\\..\\..\\language\\conf.txt" );
            }
        }
    }
}
