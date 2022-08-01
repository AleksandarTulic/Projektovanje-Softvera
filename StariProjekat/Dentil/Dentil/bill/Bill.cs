using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentil.bill
{
    public class Bill
    {
        List<ISBill> arr = new List<ISBill>();
        elements.helpElements.Date date = null;
        elements.helpElements.Time time = null;
        private static string saveBill = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\Dentil\\Bills"; 

        public Bill(List<ISBill> array)
        {
            foreach (ISBill i in array)
                arr.Add(i);
        }

        public void setDate(elements.helpElements.Date date)
        {
            this.date = date;
        }

        public void setTime(elements.helpElements.Time time)
        {
            this.time = time;
        }

        public double Cost()
        {
            double res = 0.0;
            foreach (ISBill i in arr)
                res += i.Cost;

            return res;
        }

        public int getId(int pos)
        {
            if (pos >= 0 && pos < arr.Count)
                return arr[pos].Id;
            
            return -1;
        }

        public List<ISBill> Arr
        {
            get { return arr; }
        }

        public void writeToFile(string path)
        {
            //Console.WriteLine("PUTANJA: " + path);
            Directory.CreateDirectory(saveBill);

            /*
            if ( !Directory.Exists(saveBill))
                saveBill = $"{Directory.GetCurrentDirectory()}\\..\\..\\bill\\issued";
            */

            path = $"{saveBill}\\{path}";
            int length = 0;
            double maxCost = 0.0;

            List<string> outString = new List<string>();
            foreach (ISBill i in arr)
            {
                outString.Add(i.ToString());
                maxCost += i.Cost;
            }

            outString.Add($"{Program.lang.translate("issued by", Program.defaultLang, Program.lang.CurrLang)}: {Program.user.Name}, {Program.user.Surname}");
            outString.Add($"{Program.lang.translate("Date", Program.defaultLang, Program.lang.CurrLang)}: {this.date}");
            outString.Add($"{Program.lang.translate("Time", Program.defaultLang, Program.lang.CurrLang)}: {this.time}");
            outString.Add($"{Program.lang.translate("Total cost", Program.defaultLang, Program.lang.CurrLang)}: {maxCost}");

            foreach (string i in outString)
                length = Math.Max(length, i.Length);

            string dash = "";
            for (int i = 0; i < length + 4; i++)
                dash += "#";

            List<string> outPut = new List<string>();
            outPut.Add(dash);
            
            foreach (string i in outString)
                outPut.Add(String.Format("# {0," + (-length) + "} #", i));

            outPut.Add(dash);

            fileManagement.FileOperations.writeAllLines(outPut, path);
        }
    }
}
