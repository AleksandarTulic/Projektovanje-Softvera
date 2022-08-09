using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentilNew.model.dto.common
{
    internal abstract class CommonUserTraits
    {
        protected string id;
        protected string name;
        protected string surname;
        protected string address;
        protected string phone;
        protected string email;

        public CommonUserTraits(string id, string name, string surname, string address, string phone, string email)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.address = address;
            this.phone = phone;
            this.email = email;
        }

        public string Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Surname { get { return surname; } set { surname = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string Phone { get { return phone; } set { phone = value; } }
        public string Email { get { return email; } set { email = value; } }
    }
}
