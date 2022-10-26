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
    internal class PatientDAO
    {
        private static readonly string SQL_SELECT = "select id, name, surname, address, phone, email from patient";
        private static readonly string SQL_INSERT = "insert into patient(id, name, surname, address, phone, email) values(@id, @name, @surname, @address, @phone, @email)";
        private static readonly string SQL_UPDATE = "update patient as p set p.id=@idNew,p.name=@name,p.surname=@surname,p.address=@address,p.phone=@phone,p.email=@email where p.id=@idOld";
        private static readonly string SQL_DELETE = "delete from patient as p where p.id=@id";

        public List<PatientDTO> select()
        {
            List<PatientDTO> arr = new List<PatientDTO>();
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

                            arr.Add(new PatientDTO((string)values[0], (string)values[1], (string)values[2], (string)values[3], (string)values[4], (string)values[5]));
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

        public bool insert(PatientDTO dto)
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
                        cmd.Parameters.AddWithValue("@id", dto.Id);
                        cmd.Parameters["@id"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@name", dto.Name);
                        cmd.Parameters["@name"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@surname", dto.Surname);
                        cmd.Parameters["@surname"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@address", dto.Address);
                        cmd.Parameters["@address"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@phone", dto.Phone);
                        cmd.Parameters["@phone"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@email", dto.Email);
                        cmd.Parameters["@email"].Direction = System.Data.ParameterDirection.Input;
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

        public bool update(PatientDTO dto, string oldId)
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
                        cmd.Parameters.AddWithValue("@idNew", dto.Id);
                        cmd.Parameters["@idNew"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@name", dto.Name);
                        cmd.Parameters["@name"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@surname", dto.Surname);
                        cmd.Parameters["@surname"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@address", dto.Address);
                        cmd.Parameters["@address"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@phone", dto.Phone);
                        cmd.Parameters["@phone"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@email", dto.Email);
                        cmd.Parameters["@email"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@idOld", oldId);
                        cmd.Parameters["@idOld"].Direction = System.Data.ParameterDirection.Input;
                        Console.WriteLine(cmd);
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

        public bool delete(string id)
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
