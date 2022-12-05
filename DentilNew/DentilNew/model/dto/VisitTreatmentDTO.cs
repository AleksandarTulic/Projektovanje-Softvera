using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentilNew.model.dto
{
    public class VisitTreatmentDTO
    {
        private int idVisit;
        private TreatmentDTO treatmentDTO;
        private string description;

        public VisitTreatmentDTO(int idVisit, TreatmentDTO treatmentDTO, string description)
        {
            this.idVisit = idVisit;
            this.treatmentDTO = treatmentDTO;
            this.description = description;
        }

        public VisitTreatmentDTO(TreatmentDTO treatmentDTO, string description)
        {
            this.idVisit = -1;
            this.treatmentDTO = treatmentDTO;
            this.description = description;
        }

        public int IdVisit
        {
            get { return idVisit; }
            set { idVisit = value; }
        }

        public TreatmentDTO TreatmentDTO
        {
            get { return treatmentDTO; }
        }

        public string Description
        {
            get { return description; }
        }

        public override bool Equals(System.Object obj)
        {
            if (obj == null)
                return false;

            VisitTreatmentDTO p = obj as VisitTreatmentDTO;
            if ((System.Object)p == null)
                return false;

            return p.description == description && ((p.idVisit == -1 && idVisit == -1) || p.idVisit == idVisit) && p.treatmentDTO.Id == treatmentDTO.Id;
        }
    }
}
