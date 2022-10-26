using DentilNew.model.dto.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentilNew.model.dto
{
    public class PatientDTO : CommonUserTraits
    {
        public PatientDTO(string id, string name, string surname, string email, string phone, string address) : base(id, name, surname, address, phone, email)
        {
        }
    }
}
