using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentil.user
{
    public class SpecificUser : User
    {
        elements.helpElements.Date dateBegin;
        elements.helpElements.Date dateEnd;
        string educationPlace;
        string title;

        public SpecificUser(List<string> arr) : base(arr)
        {
            try
            {
                if (arr.Count > 4)
                {
                    dateBegin = new elements.helpElements.Date(arr[arr.Count - 4]);
                    dateEnd = "0".Equals(arr[arr.Count - 3]) ? null : new elements.helpElements.Date(arr[arr.Count - 3]);
                    educationPlace = arr[arr.Count - 2];
                    title = arr[arr.Count - 1];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
            }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string EducationPlace
        {
            get { return educationPlace; }
            set { educationPlace = value; }
        }

        public elements.helpElements.Date DateBegin
        {
            get { return dateBegin; }
            set { dateBegin = value; }
        }

        public elements .helpElements.Date DateEnd
        {
            get { return dateEnd; }
            set { dateEnd = value; }
        }

        public string getType()
        {
            return "0".Equals(title) ? "Other" : "Dentist";
        }

        public override string ToString()
        {
            string rank = Program.lang.translate(getType(), Program.defaultLang, Program.lang.CurrLang);
            return $"{Program.lang.translate("Rank", Program.defaultLang, Program.lang.CurrLang)}: {rank}, {Name}, {Surname}";
        }
    }
}
