using DentilNew.model.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentilNew.controller
{
    public class AppointmentController
    {
        private AppointmentDAO dao = new AppointmentDAO();

        public bool deleteWithIdPatient(string idPatient)
        {
            return dao.change(idPatient, !Program.SQL_ACTIVE);
        }
    }
}
