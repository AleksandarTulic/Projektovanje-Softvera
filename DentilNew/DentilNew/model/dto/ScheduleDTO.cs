using DentilNew.model.dto.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentilNew.model.dto
{
    public class ScheduleDTO : CommonNameSurname
    {
        private ShiftDTO shift;
        private string date;

        public ScheduleDTO(ShiftDTO dto, string date, string name, string surname) : base(name, surname)
        {
            this.shift = dto;
            this.date = date;
        } 

        public ShiftDTO Shift { get { return this.shift; } set { shift = value; } }
        public string Date { get { return this.date; } set { this.date = value; } }

    }
}
