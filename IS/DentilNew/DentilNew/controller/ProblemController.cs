using DentilNew.model.dao;
using DentilNew.model.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentilNew.controller
{
    internal class ProblemController
    {
        private ProblemDAO dao = new ProblemDAO();

        public List<ProblemDTO> selectWithIdVisit(int idVisit)
        {
            return dao.selectWithIdVisit(idVisit);
        }

        public bool insert(List<ProblemDTO> arrProblem)
        {
            bool flag = true;
            Task<bool> []arrTask = new Task<bool>[arrProblem.Count];
            for (int i = 0; i < arrProblem.Count; i++)
            {
                Object arg = i;
                arrTask[i] = Task<bool>.Factory.StartNew((Object obj) => {
                    bool flagRes = dao.insert(arrProblem[(int)obj]);
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
