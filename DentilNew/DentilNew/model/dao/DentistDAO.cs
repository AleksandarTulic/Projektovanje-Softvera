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
    internal class DentistDAO
    {
        private static readonly string SQL_SELECT = "select w.id, w.name, w.surname, w.address, w.phone, w.email, w.username, p.jobStart, p.jobEnd " +
            "from dentist as d inner join personal as p on p.id=d.id " +
            "inner join working as w on w.id=d.id " +
            "where w.username=@username and w.password=@password and p.jobEnd is null";

        public DentistDTO select(String username, String password)
        {
            DentistDTO dto = null;
            try
            {
                using (MySqlConnection con = new MySqlConnection(Connection.Conn.ConString))
                {
                    con.Open();

                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = SQL_SELECT;
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters["@username"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters["@password"].Direction = System.Data.ParameterDirection.Input;
                        MySqlDataReader reader = cmd.ExecuteReader();


                        while (reader.Read())
                        {
                            Object[] values = new Object[reader.FieldCount];
                            int fieldCount = reader.GetValues(values);

                            dto = new DentistDTO((string)values[0], (string)values[1], (string)values[2], (string)values[3],
                                (string)values[4], (string)values[5], (string)values[6], ((DateTime)values[7]).ToString("yyyy-MM-dd"), values[8] + "" == "" ? null : ((DateTime)values[8]).ToString("yyyy-MM-dd"));
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MyLogger.Logger.log(ex.Message);
            }

            return dto;
        }
    }
}
