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

        public bool deleteWithIdTooth(int id)
        {
            return dao.deleteWithIdTooth(id);
        }

        public bool insert(List<ProblemDTO> arrProblem)
        {
            bool flag = true;
            foreach (ProblemDTO i in arrProblem)
                flag = flag && dao.insert(i);

            return flag;
        }

        public bool deleteWithIdTypeProblem(int id)
        {
            return dao.deleteWithIdTypeProblem(id);
        }

        public bool deleteWithIdVisit(int idVisit)
        {
            return dao.deleteWithIdVisit(idVisit);
        }
    }
}
