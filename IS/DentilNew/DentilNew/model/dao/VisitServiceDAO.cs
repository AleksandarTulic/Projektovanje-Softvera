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
    public class VisitServiceDAO
    {
        private static readonly string SQL_SELECT_WITH_IDVISIT = "select s.id, s.name, vt.description from visitservice as vt inner join service as s on vt.idService=s.id where vt.idVisit=@idVisit and s.active=1";
        private static readonly string SQL_INSERT = "insert into visitservice(idVisit, idService, description) values(@idVisit, @idService, @description)";

        public List<VisitServiceDTO> selectWithIdVisit(int idVisit)
        {
            List<VisitServiceDTO> arr = new List<VisitServiceDTO>();
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

                            arr.Add(new VisitServiceDTO(new ServiceDTO((int)values[0], (string)values[1]), (string)values[2]));
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

        public bool insert(VisitServiceDTO dto)
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
                        cmd.Parameters.AddWithValue("@idService", dto.TreatmentDTO.Id);
                        cmd.Parameters["@idService"].Direction = System.Data.ParameterDirection.Input;
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
    }
}
