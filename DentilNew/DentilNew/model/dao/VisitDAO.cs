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
        private static readonly string SQL_SELECT = "select v.id, v.idPatient, v.date, v.idDentist, p.name, p.surname, d.name, d.surname from visit as v inner join working as d on d.id=v.idDentist inner join patient as p on v.idPatient=p.id order by v.date desc";
        private static readonly string SQL_SELECT_WITH_IDPATIENT = "select v.id from visit as v where v.idPatient=@idPatient";
        private static readonly string SQL_INSERT = "insert into visit(idPatient, date, idDentist) values(@idPatient, @date, @idDentist);select last_insert_id()";
        private static readonly string SQL_DELETE = "delete from visit as v where v.id=@id";

        public List<VisitDTO> select()
        {
            List<VisitDTO> arr = new List<VisitDTO>();
            try
            {
                using (MySqlConnection con = new MySqlConnection(Connection.Conn.ConString))
                {
                    con.Open();

                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = SQL_SELECT;
                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            Object[] values = new Object[reader.FieldCount];
                            int fieldCount = reader.GetValues(values);
                            DateTime dt = (DateTime)values[2];
                            arr.Add(new VisitDTO((int)values[0], (string)values[1], dt.ToString("yyyy-MM-dd"), (string)values[3], (string)values[4], (string)values[5], (string)values[6], (string)values[7]));
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

        public List<int> selectWithIdPatient(string idPatient)
        {
            List<int> arr = new List<int>();
            try
            {
                using (MySqlConnection con = new MySqlConnection(Connection.Conn.ConString))
                {
                    con.Open();

                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = SQL_SELECT_WITH_IDPATIENT;
                        cmd.Parameters.AddWithValue("@idPatient", idPatient);
                        cmd.Parameters["@idPatient"].Direction = System.Data.ParameterDirection.Input;
                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            Object[] values = new Object[reader.FieldCount];
                            int fieldCount = reader.GetValues(values);

                            arr.Add((int)values[0]);
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

        public int insert(VisitDTO dto)
        {
            int res = -1;
            try
            {
                using (MySqlConnection con = new MySqlConnection(Connection.Conn.ConString))
                {
                    con.Open();

                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = SQL_INSERT;
                        cmd.Parameters.AddWithValue("@idPatient", dto.IdPatient);
                        cmd.Parameters["@idPatient"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@date", dto.Date);
                        cmd.Parameters["@date"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@idDentist", dto.IDDentist);
                        cmd.Parameters["@idDentist"].Direction = System.Data.ParameterDirection.Input;
                        res = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MyLogger.Logger.log(ex.Message);
            }

            return res;
        }

        public bool delete(int id)
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
                        cmd.CommandText = SQL_DELETE;
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters["@id"].Direction = System.Data.ParameterDirection.Input;
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
