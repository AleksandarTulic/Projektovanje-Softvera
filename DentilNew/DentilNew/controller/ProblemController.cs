using DentilNew.model.dao;
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

        public bool deleteWithIdTooth(int id)
        {
            return dao.deleteWithIdTooth(id);
        }
    }
}
