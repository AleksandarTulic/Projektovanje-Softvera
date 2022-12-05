using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DentilNew.model.dto.common;

namespace DentilNew.model.dto
{
    public class LastSeenDTO : CommonNameSurname
    {
        private int idVisit;
        private string dateWhen; //this is only string because we don't input these values to database that part is the job of mysql server - no validation needed
        private string timeWhen; //this is only string because we don't input these values to database that part is the job of mysql server - no validation needed
        private string idDentist;

        //this is not in the same table in mysql database but because if we read rows of that table users would like to see the names so the programmer
        //on the front can easily access thi data without calling another service for values from another table
        //private string dentistName = null;
        //private string dentistSurname = null;

        public LastSeenDTO(int idVisit, string idDentist) : base()
        {
            this.idVisit = idVisit;
            this.idDentist = idDentist;
        }

        public LastSeenDTO(int idVisit, string dateWhen, string timeWhen, string idDentist) : base()
        {
            this.idVisit = idVisit;
            this.dateWhen = dateWhen;
            this.timeWhen = timeWhen;
            this.idDentist = idDentist;
        }

        public LastSeenDTO(int idVisit, string dateWhen, string timeWhen, string idDentist, string dentistName, string dentistSurname) : base(dentistName, dentistSurname)
        {
            this.idVisit = idVisit;
            this.dateWhen = dateWhen;
            this.timeWhen = timeWhen;
            this.idDentist = idDentist;
        }

        public int IdVisit
        {
            get { return idVisit; }
            set { idVisit = value; }
        }

        public string IdDentist
        {
            get { return idDentist; }
            set { idDentist = value; }
        }

        public string DateWhen
        {
            get { return dateWhen; }
            set { dateWhen = value; }
        }

        public string TimeWhen
        {
            get { return timeWhen; }
            set { timeWhen = value; }
        }
    }
}
