using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DentilNew.model.dao.connection;
using MySql.Data.MySqlClient;
using DentilNew.model.dto;
using DentilNew.model.logger;

namespace DentilNew.model.dao
{
    internal class ProblemDAO
    {
        //need design for further implementation
        private static readonly string SQL_SELECT = "";
        private static readonly string SQL_INSERT = "insert into problem(idTypeProblem, idTooth, idVisit) values(@idTypeProblem, @idTooth, @idVisit)";
    }
}
