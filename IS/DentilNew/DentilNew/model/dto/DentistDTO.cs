using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DentilNew.model.dto.common;

namespace DentilNew.model.dto
{
    public class DentistDTO : CommonUserTraits
    {
        private string username;
        private string jobStart;
        private string jobEnd;

        public DentistDTO(string id, string name, string surname, string address, string phone, string email, string username, string jobStart, string jobEnd) : base(id, name, surname, address, phone, email)
        {
            this.username = username;
            this.jobStart = jobStart;
            this.jobEnd = jobEnd;
        }

        public string Username { get { return username; } set { username = value; } }
        public string JobStart { get { return jobStart; } set { jobStart = value; } }
        public string JobEnd { get { return jobEnd; } set { jobEnd = value; } }
    }
}
