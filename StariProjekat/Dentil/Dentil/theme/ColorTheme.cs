using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentil.theme
{
    public class ColorTheme
    {
        string name;
        List<string> arr = new List<string>();

        public ColorTheme(string value)
        {
            try
            {
                string[] sp = value.Split(';');
                name = sp[0];

                if (sp.Length != 5)
                    throw new Exception();

                for (int i=1;i<5;i++)
                    arr.Add(sp[i]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
            }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<string> Arr
        {
            get { return arr; }
            set { arr = value; }
        }

        public string getElement(int index)
        {
            try
            {
                return arr[index];
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
            }

            return "";
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                ColorTheme ct = (ColorTheme)obj;
                return name.Equals(ct.name);
            }
        }

        public override string ToString()
        {
            return name + ";" + arr[0] + ";" + arr[1] + ";" + arr[2] + ";" + arr[3];
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
