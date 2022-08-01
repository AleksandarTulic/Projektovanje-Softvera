using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dentil.elements.helpElements;

namespace Dentil.appointment
{
    public class Appointment
    {
        Date date = null;
        Time time = null;
        int howLong = 0;
        string dentistJmb;
        string patientJmb;
        string note;

        public Appointment(List <String> arr)
        {
            try
            {
                date = new Date(arr[0]);
                time = new Time(arr[1]);
                howLong = int.Parse(arr[2]);
                dentistJmb = arr[3];
                patientJmb = arr[4];
                note = arr[5];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
            }
        }

        public Date Date
        {
            get { return date; }
            set { date = value; }
        }

        public Time Time
        {
            get { return time; }
            set { time = value; }
        }

        public int HowLong
        {
            get { return howLong; }
            set { howLong = value; }
        }

        public string PatientJmb
        {
            get { return patientJmb; }
            set { patientJmb = value; }
        }

        public string Note
        {
            get { return note; }
            set { note = value; }
        }

        public string DentistJmb
        {
            get { return dentistJmb; }
            set { dentistJmb = value; }
        }

        public override string ToString()
        {
            return $"{date.ToString()}, {time.ToString()}";
        }
    }
}
