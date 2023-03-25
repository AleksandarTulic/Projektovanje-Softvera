using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentilNew.model.dto
{
    public class ServiceDTO : CommonElementTraits
    {
        public ServiceDTO(int id, string name) : base(id, name)
        {
        }

        public override string ToString()
        {
            return "Treatment ID: " + base.name + ", Treatment Name: " + base.id;
        }
    }
}
