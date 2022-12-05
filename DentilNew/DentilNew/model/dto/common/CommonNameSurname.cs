using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentilNew.model.dto.common
{
    public class CommonNameSurname
    {
        protected string name;
        protected string surname;

        public CommonNameSurname()
        {
            name = null;
            surname = null;
        }

        public CommonNameSurname(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public string Name { get { return name; } set { name = value; } }
        public string Surname { get { return surname; } set { surname = value; } }
    }
}
