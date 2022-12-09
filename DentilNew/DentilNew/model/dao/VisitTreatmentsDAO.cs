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
    public class VisitTreatmentsDAO
    {
        private static readonly string SQL_SELECT_WITH_IDVISIT = "select t.id, t.name, vt.description from visittreatment as vt inner join treatment as t on vt.idTreatment=t.id where vt.idVisit=@idVisit";
        private static readonly string SQL_INSERT = "insert into visittreatment(idVisit, idTreatment, description) values(@idVisit, @idTreatment, @description)";
        private static readonly string SQL_DELETE = "delete from visittreatment as vt where vt.idVisit=@idVisit";

        public List<VisitTreatmentDTO> selectWithIdVisit(int idVisit)
        {
            List<VisitTreatmentDTO> arr = new List<VisitTreatmentDTO>();
            try
            {
                using (MySqlConnection con = new MySqlConnection(Connection.Conn.ConString))
                {
                    con.Open();

                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = SQL_SELECT_WITH_IDVISIT;
                        cmd.Parameters.AddWithValue("@idVisit", idVisit);
                        cmd.Parameters["@idVisit"].Direction = System.Data.ParameterDirection.Input;
                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            Object[] values = new Object[reader.FieldCount];
                            int fieldCount = reader.GetValues(values);

                            arr.Add(new VisitTreatmentDTO(new TreatmentDTO((int)values[0], (string)values[1]), (string)values[2]));
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

        public bool insert(VisitTreatmentDTO dto)
        {
            bool flag = true;
            try
            {
                using (MySqlConnection con = new MySqlConnection(Connection.Conn.ConString))
                {
                    con.Open();
                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = SQL_INSERT;
                        cmd.Parameters.AddWithValue("@idVisit", dto.IdVisit);
                        cmd.Parameters["@idVisit"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@idTreatment", dto.TreatmentDTO.Id);
                        cmd.Parameters["@idTreatment"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@description", dto.Description);
                        cmd.Parameters["@description"].Direction = System.Data.ParameterDirection.Input;
                        flag = flag && cmd.ExecuteNonQuery() >= 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MyLogger.Logger.log(ex.Message);
            }

            return flag;
        }

        public bool delete(int idVisit)
        {
            bool flag = true;
            try
            {
                using (MySqlConnection con = new MySqlConnection(Connection.Conn.ConString))
                {
                    con.Open();
                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = SQL_DELETE;
                        cmd.Parameters.AddWithValue("@idVisit", idVisit);
                        cmd.Parameters["@idVisit"].Direction = System.Data.ParameterDirection.Input;
                        flag = flag && cmd.ExecuteNonQuery() >= 1;
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
