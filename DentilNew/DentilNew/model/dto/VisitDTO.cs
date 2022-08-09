using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DentilNew.model.dto.common;

namespace DentilNew.model.dto
{
    internal class VisitDTO : CommonNameSurname
    {
        private int id;
        private string idPatient;
        private string date;
        private string idDentist;

        public VisitDTO(int id, string idPatient, string date, string idDentist, string name, string surname) : base(name, surname)
        {
            this.id = id;
            this.idPatient = idPatient;
            this.date = date;
            this.idDentist = idDentist;
        }

        public int Id { get { return id; } set { id = value; } }
        public string IdPatient { get { return idPatient;} set { idPatient = value; } }
        public string Date { get { return date; } set { date = value; } }
        public string IDDentist { get { return idDentist; } set { idDentist = value; } }
    }
}
