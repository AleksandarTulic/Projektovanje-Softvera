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
    internal class ScheduleDAO
    {
        private static readonly string SQL_SELECT = "select sh.id, sh.begin, sh.end, s.date, w.name, w.surname from schedule as s inner join shift sh on sh.id=s.idShift " +
            "inner join working as w on w.id=s.idPersonal where s.date=@date";

        //http://net-informations.com/q/faq/stringdate.html
        public static List<ScheduleDTO> select(DateTime dateTime)
        {
            List<ScheduleDTO> arr = new List<ScheduleDTO>();
            try
            {
                using (MySqlConnection con = new MySqlConnection(Connection.Conn.ConString))
                {
                    con.Open();

                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = SQL_SELECT;
                        cmd.Parameters.AddWithValue("@date", dateTime.ToString("yyyy-MM-dd"));
                        cmd.Parameters["@date"].Direction = System.Data.ParameterDirection.Input;
                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            Object[] values = new Object[reader.FieldCount];
                            int fieldCount = reader.GetValues(values);

                            arr.Add(new ScheduleDTO(new ShiftDTO((int)values[0], (string)values[1], (string)values[2]), (string)values[3], (string)values[4], (string)values[5]));
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
