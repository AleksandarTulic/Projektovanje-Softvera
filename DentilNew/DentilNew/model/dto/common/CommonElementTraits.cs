using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentilNew.model.dto
{
    internal abstract class CommonElementTraits
    {
        protected int id;
        protected string name;

        public CommonElementTraits(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
