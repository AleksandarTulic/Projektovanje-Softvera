using DentilNew.model.dao;
using DentilNew.model.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentilNew.controller
{
    internal class VisitController
    {
        private VisitDAO dao = new VisitDAO();

        public List<VisitDTO> select()
        {
            return dao.select();
        }

        public bool insert(VisitDTO dto, List<VisitTreatmentDTO> arrVisitTreatment, List<ProblemDTO> arrProblem)
        {
            dto.Id = dao.selectLastID() + 1;
            bool flag = dao.insert(dto);

            if (flag)
            {
                foreach (VisitTreatmentDTO i in arrVisitTreatment)
                    i.IdVisit = dto.Id;

                foreach (ProblemDTO i in arrProblem)
                    i.IdVisit = dto.Id;

                flag = flag && Program.problemController.insert(arrProblem);
                flag = flag && Program.visitTreatmentController.insert(arrVisitTreatment);
                Program.lastSeenController.insert(new LastSeenDTO(dto.Id, Program.dto.Id));
            }

            return flag;
        }

        public bool delete(int id)
        {
            Program.lastSeenController.delete(id);
            Program.visitTreatmentController.delete(id);
            Program.problemController.deleteWithIdVisit(id);
            return dao.delete(id);
        }

        public bool deleteWithIdPatient(string idPatient)
        {
            List<int> arrIdVisit = dao.selectWithIdPatient(idPatient);
            bool flag = true;

            foreach (int i in arrIdVisit)
                flag = flag && delete(i);

            return flag;
        }
    }
}
