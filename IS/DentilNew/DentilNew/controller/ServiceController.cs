using DentilNew.model.dao;
using DentilNew.model.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentilNew.controller
{
    internal class ServiceController
    {
        private ServiceDAO dao = new ServiceDAO();

        public List<ServiceDTO> select()
        {
            return dao.select();
        }

        public bool insert(string name)
        {
            return dao.insert(name);
        }

        public bool delete(int id)
        {
            return dao.delete(id);
        }
    }
}
