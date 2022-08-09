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
    internal class VisitTreatmentsDAO
    {
        private static readonly string SQL_INSERT = "insert into visittreatment(idVisit, idTreatment, description) values(@idVisit, @idTreatment, @description)";

        //arr[0].item1 - idTreatment, arr[0].item2 - description
        public static bool insert(int idVisit, List<Tuple<int, string>> arr)
        {
            bool flag = true;
            try
            {
                using (MySqlConnection con = new MySqlConnection(Connection.Conn.ConString))
                {
                    con.Open();
                    foreach (Tuple<int, string> i in arr) 
                    {
                        using (MySqlCommand cmd = con.CreateCommand())
                        {
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            cmd.CommandText = SQL_INSERT;
                            cmd.Parameters.AddWithValue("@idVisit", idVisit);
                            cmd.Parameters["@idVisit"].Direction = System.Data.ParameterDirection.Input;
                            cmd.Parameters.AddWithValue("@idTreatment", i.Item1);
                            cmd.Parameters["@idTreatment"].Direction = System.Data.ParameterDirection.Input;
                            cmd.Parameters.AddWithValue("@description", i.Item2);
                            cmd.Parameters["@description"].Direction = System.Data.ParameterDirection.Input;
                            flag = flag && cmd.ExecuteNonQuery() >= 1;
                        }
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
