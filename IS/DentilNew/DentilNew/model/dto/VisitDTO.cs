using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DentilNew.model.dto.common;

namespace DentilNew.model.dto
{
    public class VisitDTO
    {
        private int id;
        private string idPatient;
        private string date;
        private string idDentist;
        private CommonNameSurname patient;
        private CommonNameSurname dentist;

        public VisitDTO(int id, string idPatient, string date, string idDentist)
        {
            this.id = id;
            this.idPatient = idPatient;
            this.date = date;
            this.idDentist = idDentist;
        }

        public VisitDTO(int id, string idPatient, string date, string idDentist, string namePatient, string surnamePatient, string nameDentist, string surnameDentist)
        {
            this.id = id;
            this.idPatient = idPatient;
            this.date = date;
            this.idDentist = idDentist;
            this.patient = new CommonNameSurname(namePatient, surnamePatient);
            this.dentist = new CommonNameSurname(nameDentist, surnameDentist);
        }

        public int Id { get { return id; } set { id = value; } }
        public string IdPatient { get { return idPatient;} set { idPatient = value; } }
        public string Date { get { return date; } set { date = value; } }
        public string IDDentist { get { return idDentist; } set { idDentist = value; } }

        public CommonNameSurname Patient { get { return patient; } }

        public CommonNameSurname Dentist { get { return dentist; } }
    }
}
