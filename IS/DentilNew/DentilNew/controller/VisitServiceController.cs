using DentilNew.model.dao;
using DentilNew.model.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentilNew.controller
{
    public class VisitServiceController
    {
        private VisitServiceDAO dao = new VisitServiceDAO();

        public List<VisitServiceDTO> selectWithIdvisit(int idVisit)
        {
            return dao.selectWithIdVisit(idVisit);
        }

        public bool insert(List<VisitServiceDTO> arrVisitTreatment)
        {
            bool flag = true;

            Task<bool>[] arrTask = new Task<bool>[arrVisitTreatment.Count];
            for (int i = 0; i < arrVisitTreatment.Count; i++)
            {
                Object arg = arrVisitTreatment[i];
                arrTask[i] = Task<bool>.Factory.StartNew((Object obj) => {
                    bool flagRes = dao.insert((VisitServiceDTO)obj);
                    return flagRes;
                }, arg);
            }

            Task.WaitAll(arrTask);
            foreach (Task<bool> i in arrTask)
                flag = flag && i.Result;

            return flag;
        }
    }
}
