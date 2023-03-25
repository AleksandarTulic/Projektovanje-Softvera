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
        private static readonly string SQL_SELECT_WITH_ID = "select id, name, surname, address, phone, email from patient as p where p.id=@id and p.active=1";
        private static readonly string SQL_SELECT = "select id, name, surname, email, phone, address from patient p where p.active=1";
        private static readonly string SQL_INSERT = "insert into patient(id, name, surname, address, phone, email) values(@id, @name, @surname, @address, @phone, @email)";
        private static readonly string SQL_UPDATE = "update patient as p set p.id=@idNew,p.name=@name,p.surname=@surname,p.address=@address,p.phone=@phone,p.email=@email where p.id=@idOld and p.active=1";
        private static readonly string SQL_DELETE = "update patient as p set p.active=0 where p.id=@id";
        private static readonly string SQL_RECOVER_PATIENT = "update patient as p set p.active=1 where p.id=@id";

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

                            arr.Add(new PatientDTO((string)values[0], (string)values[1], (string)values[2], 
                                values[3] != DBNull.Value ? (string)values[3] : null,
                                values[4] != DBNull.Value ? (string)values[4] : null,
                               values[5] != DBNull.Value ? (string)values[5] : null));
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

        public PatientDTO selectWithId(string id)
        {
            PatientDTO res = null;
            try
            {
                using (MySqlConnection con = new MySqlConnection(Connection.Conn.ConString))
                {
                    con.Open();

                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = SQL_SELECT_WITH_ID;
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters["@id"].Direction = System.Data.ParameterDirection.Input;
                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {

                            Object[] values = new Object[reader.FieldCount];
                            int fieldCount = reader.GetValues(values);

                            res = new PatientDTO((string)values[0], (string)values[1], (string)values[2], (string)values[3], (string)values[4], (string)values[5]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MyLogger.Logger.log(ex.Message);
            }

            return res;
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

        public bool recoverPatient(string id)
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
                        cmd.CommandText = SQL_RECOVER_PATIENT;
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
