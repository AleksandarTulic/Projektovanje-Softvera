using DentilNew.model.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentilNew.controller
{
    internal class LoginController
    {
        private DentistDAO dao = new DentistDAO();

        public bool select(string username, string password)
        {
            password = Program.crypt.sha256(password.Trim());
            Program.dto = dao.select(username, password);
            return !(Program.dto == null);
        }
    }
}
