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

        public bool insert(VisitDTO dto, List<VisitServiceDTO> arrVisitTreatment, List<ProblemDTO> arrProblem)
        {
            dto.Id = dao.insert(dto);
            bool flag = false;

            if (dto.Id >= 0)
            {
                foreach (VisitServiceDTO i in arrVisitTreatment)
                    i.IdVisit = dto.Id;

                foreach (ProblemDTO i in arrProblem)
                    i.IdVisit = dto.Id;

                Task<bool> task1 = Task<bool>.Factory.StartNew(() => { return Program.problemController.insert(arrProblem); });
                Task<bool> task2 = Task<bool>.Factory.StartNew(() => { return Program.visitTreatmentController.insert(arrVisitTreatment); });

                task1.Wait();
                task2.Wait();

                flag = true;
                flag = flag && task1.Result;
                flag = flag && task2.Result;

                Program.lastSeenController.insert(new HistoryVisitDTO(dto.Id, Program.dto.Id));
            }

            return flag;
        }

        public bool delete(int id)
        {
            return dao.delete(id);
        }

        public bool deleteWithIdPatient(string idPatient)
        {
            List<int> arrIdVisit = dao.selectWithIdPatient(idPatient);
            bool flag = true;

            Task<bool>[] arrTask = new Task<bool>[arrIdVisit.Count];

            for (int i = 0; i < arrIdVisit.Count; i++)
            {
                Object arg = i;
                arrTask[i] = Task<bool>.Factory.StartNew((Object obj) => {
                    bool flagRes = delete(arrIdVisit[(int)obj]);
                    return flagRes;
                }, arg);
            }

            Task.WaitAll(arrTask);
            foreach (Task<bool> i in arrTask)
                flag = flag && i.Result;

            return flag;
        }

        public bool recover(string idPatient)
        {
            return dao.recover(idPatient);
        }
    }
}
