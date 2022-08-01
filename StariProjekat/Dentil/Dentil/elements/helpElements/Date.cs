using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentil.elements.helpElements
{
    public class Date
    {
        int year;
        int month;
        int day;

        readonly int[] numDays = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        public Date(string date)
        {
            try
            {
                string []sp1 = date.Split(' ');
                string []sp2 = sp1[0].Split('/');

                month = int.Parse(sp2[0]);
                day = int.Parse(sp2[1]);
                year = int.Parse(sp2[2]);

                if (!check())
                    throw new Exception();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
            }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public int Month
        {
            get { return month; }
            set { month = value; }
        }

        public int Day
        {
            get { return day; }
            set { day = value; }
        }

        public override string ToString()
        {
            return $"{year}-{month}-{day}";
        }

        public string getWithZero()
        {
            string mon = "";
            string da = "";

            if (month < 10)
                mon = "0" + month;
            else
                mon = $"{month}";

            if (day < 10)
                da = "0" + day;
            else
                da = $"{day}";

            return $"{year}-{mon}-{da}";
        }

        private bool check()
        {
            if (year < 0 || month < 1 || day < 1 || month > 12)
                return false;

            if (month == 2)
                if (!leapYear(year))
                    if (numDays[month] == 29)
                        return true;
                    else 
                        return false;

            return numDays[month-1] >= day;
        }

        private bool leapYear(int year)
        {
            if (year % 4 != 0)
                return false;
            else if (year % 100 != 0)
                return true;
            else if (year % 400 != 0)
                return false;
            else
                return true;
        }
    }
}
