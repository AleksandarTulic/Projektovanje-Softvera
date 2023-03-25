using DentilNew.model.dao;
using DentilNew.model.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentilNew.controller
{
    public class HistoryVisitController
    {
        private HistoryVisitDAO dao = new HistoryVisitDAO();

        public List<HistoryVisitDTO> select(int idVisit)
        {
            return dao.select(idVisit);
        }

        public bool insert(HistoryVisitDTO dto)
        {
            return dao.insert(dto);
        }
    }
}
