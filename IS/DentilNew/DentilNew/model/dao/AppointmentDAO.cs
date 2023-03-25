using DentilNew.model.dao.connection;
using DentilNew.model.logger;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentilNew.model.dao
{
    public class AppointmentDAO
    {
        private static readonly string SQL_UPDATE = "update appointment as a set a.active=@recoverValue where a.idPatient=@idPatient";

        public bool change(string idPatient, bool active)
        {
            bool flag = false;
            try
            {
                using (MySqlConnection con = new MySqlConnection(Connection.Conn.ConString))
                {
                    con.Open();

                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = SQL_UPDATE;
                        cmd.Parameters.AddWithValue("@idPatient", idPatient);
                        cmd.Parameters["@idPatient"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@recoverValue", active);
                        cmd.Parameters["@recoverValue"].Direction = System.Data.ParameterDirection.Input;
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
