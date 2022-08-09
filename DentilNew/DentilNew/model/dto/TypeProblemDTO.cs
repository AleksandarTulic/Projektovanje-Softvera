using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentilNew.model.dto
{
    internal class TypeProblemDTO : CommonElementTraits
    {
        public TypeProblemDTO(int id, string name) : base(id, name)
        {

        }

        public override string ToString()
        {
            return "Type Problem ID: " + base.name + ", Type Problem Name: " + base.id;
        }
    }
}
