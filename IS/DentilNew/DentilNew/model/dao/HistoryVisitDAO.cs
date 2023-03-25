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
    public class HistoryVisitDAO
    {
        private static readonly string SQL_INSERT = "insert into HistoryVisit(idVisit, dateWhen, timeWhen, idDentist) values(@idVisit, date(now()), time(now()), @idDentist)";
        private static readonly string SQL_SELECT = "select hv.idVisit, hv.dateWhen, hv.timeWhen, hv.idDentist, w.name, w.surname from HistoryVisit as hv inner join worker as w on w.id=hv.idDentist where hv.idVisit=@idVisit";

        public bool insert(HistoryVisitDTO dto)
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
                        cmd.CommandText = SQL_INSERT;
                        cmd.Parameters.AddWithValue("@idDentist", dto.IdDentist);
                        cmd.Parameters["@idDentist"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@idVisit", dto.IdVisit);
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

        public List<HistoryVisitDTO> select(int idVisit)
        {
            List<HistoryVisitDTO> arr = new List<HistoryVisitDTO>();
            try
            {
                using (MySqlConnection con = new MySqlConnection(Connection.Conn.ConString))
                {
                    con.Open();

                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = SQL_SELECT;
                        cmd.Parameters.AddWithValue("@idVisit", idVisit);
                        cmd.Parameters["@idVisit"].Direction = System.Data.ParameterDirection.Input;
                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            Object[] values = new Object[reader.FieldCount];
                            int fieldCount = reader.GetValues(values);
                            arr.Add(new HistoryVisitDTO((int)values[0], ((DateTime)values[1]).ToString("yyyy-MM-dd"), (string)(values[2] + ""), (string)values[3], (string)values[4], (string)values[5]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MyLogger.Logger.log(ex.Message);
            }

            return arr;
        }
    }
}
