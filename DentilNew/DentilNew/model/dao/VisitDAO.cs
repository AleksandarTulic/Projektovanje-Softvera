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
    internal class VisitDAO
    {
        private static readonly string SQL_SELECT = "select v.id, v.idPatient, v.date, v.idDentist, d.name, d.surname from visit as v inner join working as d on d.id=v.idDentist where v.idPatient=@idPatient";
        private static readonly string SQL_INSERT = "insert into patient(id, idPatient, date, idDentist) values(@id, @idPatient, @date, @idDentist)";

        public static List<VisitDTO> select()
        {
            List<VisitDTO> arr = new List<VisitDTO>();
            try
            {
                using (MySqlConnection con = new MySqlConnection(Connection.Conn.ConString))
                {
                    con.Open();

                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = SQL_SELECT;
                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            Object[] values = new Object[reader.FieldCount];
                            int fieldCount = reader.GetValues(values);

                            arr.Add(new VisitDTO((int)values[0], (string)values[1], (string)values[2], (string)values[3], (string)values[4], (string)values[5]));
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

        public static bool insert(VisitDTO dto)
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
                        cmd.Parameters.AddWithValue("@id", dto.Id);
                        cmd.Parameters["@id"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@idPatient", dto.IdPatient);
                        cmd.Parameters["@idPatient"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@date", dto.Date);
                        cmd.Parameters["@date"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@idDentist", dto.IDDentist);
                        cmd.Parameters["@idDentist"].Direction = System.Data.ParameterDirection.Input;
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
