using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentil.elements
{
    public class Shift
    {
        int id;
        helpElements.Time begin;
        helpElements.Time end;

        public Shift(List <string> arr)
        {
            try
            {
                id = int.Parse(arr[0]);
                begin = new helpElements.Time(arr[1]);
                end = new helpElements.Time(arr[2]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
            }
        }

        public helpElements.Time Begin
        {
            get { return begin; }
            set { begin = value; }
        }

        public helpElements.Time End
        {
            get { return end; }
            set { end = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public override string ToString()
        {
            return $"{Program.lang.translate("Start", Program.defaultLang, Program.lang.CurrLang)}: " + begin.ToString() + 
                $", {Program.lang.translate("End", Program.defaultLang, Program.lang.CurrLang)}: " + end.ToString();
        }
    }
}
