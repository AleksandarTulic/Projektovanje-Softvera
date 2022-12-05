using DentilNew.model.dao;
using DentilNew.model.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentilNew.controller
{
    public class VisitTreatmentController
    {
        private VisitTreatmentsDAO dao = new VisitTreatmentsDAO();

        public List<VisitTreatmentDTO> selectWithIdvisit(int idVisit)
        {
            return dao.selectWithIdVisit(idVisit);
        }

        public bool insert(List<VisitTreatmentDTO> arrVisitTreatment)
        {
            bool flag = true;

            foreach (VisitTreatmentDTO i in arrVisitTreatment)
                flag = flag && dao.insert(i);

            return flag;
        }

        public bool delete(int idVisit)
        {
            return dao.delete(idVisit);
        }
    }
}
