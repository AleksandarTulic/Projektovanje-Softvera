using DentilNew.model.dao.connection;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DentilNew.model.logger;
using DentilNew.model.dto;

namespace DentilNew.model.dao
{
    internal class LastSeenDAO
    {
        private static readonly string SQL_INSERT = "insert into LastSeen(idVisit, dateWhen, timeWhen, idDentist) values(@idVisit, date(now()), time(now()), @idDentist)";
        private static readonly string SQL_SELECT = "select ls.idVisit, ls.dateWhen, ls.timeWhen, ls.idDentist, w.name, w.surname from LastSeen as ls inner join working as w on w.id=ls.idDentist where ls.idVisit=@idVisit";

        public static bool insert(string idVisit, string idDentist)
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
                        cmd.CommandText = SQL_INSERT;
                        cmd.Parameters.AddWithValue("@idDentist", idDentist);
                        cmd.Parameters["@idDentist"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@idVisit", idVisit);
                        cmd.Parameters["@idVisit"].Direction = System.Data.ParameterDirection.Input;
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

        public static List<LastSeenDTO> select(int idVisit)
        {
            List<LastSeenDTO> arr = new List<LastSeenDTO>();
            try
            {
                using (MySqlConnection con = new MySqlConnection(Connection.Conn.ConString))
                {
                    con.Open();

                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = SQL_SELECT;
                        cmd.Parameters.AddWithValue("@idVisit", idVisit);
                        cmd.Parameters["@idVisit"].Direction = System.Data.ParameterDirection.Input;
                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            Object[] values = new Object[reader.FieldCount];
                            int fieldCount = reader.GetValues(values);

                            arr.Add(new LastSeenDTO((int)values[0], (string)values[1], (string)values[2], (int)values[3], (string)values[4], (string)values[5]));
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MyLogger.Logger.log(ex.Message);
            }

            return arr;
        }
    }
}
