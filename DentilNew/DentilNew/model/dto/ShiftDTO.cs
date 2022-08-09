using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentilNew.model.dto
{
    internal class ShiftDTO
    {
        private int id;
        private string begin;
        private string end;

        public ShiftDTO(int id, string begin, string end)
        {
            this.id = id;
            this.begin = begin;
            this.end = end;
        }

        public int Id { get { return id; } set { id = value; } }
        public string Begin { get { return begin; } set { begin = value; } }
        public string End { get { return end; } set { end = value; } }
    }
}
