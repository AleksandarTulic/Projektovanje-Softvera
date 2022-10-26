using DentilNew.model.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentilNew.controller
{
    internal class ToothController
    {
        private ToothDAO dao = new ToothDAO();

        public bool insert(int id)
        {
            return dao.insert(id);
        }

        public bool delete(int id)
        {
            Program.problemController.deleteWithIdTooth(id);
            return dao.delete(id);
        }

        public List<int> select()
        {
            return dao.select();
        }
    }
}
