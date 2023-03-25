using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentilNew.model.dto
{
    public class VisitServiceDTO
    {
        private int idVisit;
        private ServiceDTO treatmentDTO;
        private string description;

        public VisitServiceDTO(int idVisit, ServiceDTO treatmentDTO, string description)
        {
            this.idVisit = idVisit;
            this.treatmentDTO = treatmentDTO;
            this.description = description;
        }

        public VisitServiceDTO(ServiceDTO treatmentDTO, string description)
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

        public ServiceDTO TreatmentDTO
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

            VisitServiceDTO p = obj as VisitServiceDTO;
            if ((System.Object)p == null)
                return false;

            return p.description == description && ((p.idVisit == -1 && idVisit == -1) || p.idVisit == idVisit) && p.treatmentDTO.Id == treatmentDTO.Id;
        }
    }
}
