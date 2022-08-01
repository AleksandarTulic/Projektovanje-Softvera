using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentil.elements.helpElements
{
    public class Time
    {
        int hours = 0;
        int minutes = 0;
        int seconds = 0;

        public Time(string a)
        {
            string []sp = a.Split(':');

            try
            {
                hours = int.Parse(sp[0]);
                minutes = int.Parse(sp[1]);
                seconds = int.Parse(sp[2]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
            }
        }

        public Time(string hours, string minutes)
        {
            try
            {
                this.hours = int.Parse (hours);
                this.minutes = int.Parse (minutes);
                this.seconds = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
            }
        }

        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }

        public int Minutes
        {
            get { return minutes; }
            set { minutes = value; }
        }

        public int Seconds
        {
            get { return seconds; }
            set { seconds = value; }
        }

        public override string ToString()
        {
            return $"{hours}:{minutes}:{seconds}";
        }
    }
}
