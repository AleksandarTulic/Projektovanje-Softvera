using DentilNew.model.dao;
using DentilNew.model.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentilNew.controller
{
    public class LastSeenController
    {
        private LastSeenDAO dao = new LastSeenDAO();

        public List<LastSeenDTO> select(int idVisit)
        {
            return dao.select(idVisit);
        }

        public bool insert(LastSeenDTO dto)
        {
            return dao.insert(dto);
        }

        public bool delete(int idVisit)
        {
            return dao.delete(idVisit);
        }
    }
}
