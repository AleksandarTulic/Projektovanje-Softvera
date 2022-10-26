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
        private static readonly string SQL_DELETE_WITH_IDTOOTH = "delete from problem a p where p.idTooth=@idTooth";

        public bool deleteWithIdTooth(int id)
        {
            bool flag = false;
            try
            {
                using (MySqlConnection con = new MySqlConnection(Connection.Conn.ConString))
                {
                    con.Open();

                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = SQL_DELETE_WITH_IDTOOTH;
                        cmd.Parameters.AddWithValue("@idTooth", id);
                        cmd.Parameters["@idTooth"].Direction = System.Data.ParameterDirection.Input;
                        flag = cmd.ExecuteNonQuery() >= 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MyLogger.Logger.log(ex.Message);
            }

            return flag;
        }
    }
}
