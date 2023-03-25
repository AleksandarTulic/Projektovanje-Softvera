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
    internal class ProblemDAO
    {
        private static readonly string SQL_SELECT_WITH_IDVISIT = "select tp.id, tp.name, p.idTooth from problem as p inner join typeproblem as tp on p.idTypeProblem=tp.id where p.idVisit=@idVisit";
        private static readonly string SQL_INSERT = "insert into problem(idTypeProblem, idTooth, idVisit) values(@idTypeProblem, @idTooth, @idVisit)";

        public List<ProblemDTO> selectWithIdVisit(int idVisit)
        {
            List<ProblemDTO> arr = new List<ProblemDTO>();
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

                            Console.WriteLine("Dosao [1]");
                            foreach (Object value in values)
                            {
                                Console.WriteLine(value);
                            }

                            arr.Add(new ProblemDTO(new TypeProblemDTO(int.Parse(values[0] + ""), (string)values[1]), values[2] == DBNull.Value ? -1 : int.Parse(values[2] + "")));

                            Console.WriteLine("Dosao [2]");
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

        public bool insert(ProblemDTO dto)
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
                        cmd.Parameters.AddWithValue("@idTypeProblem", dto.TypeProblemDto.Id);
                        cmd.Parameters["@idTypeProblem"].Direction = System.Data.ParameterDirection.Input;
                        if (dto.Tooth == -1)
                            cmd.Parameters.AddWithValue("@idTooth", null);
                        else
                            cmd.Parameters.AddWithValue("@idTooth", dto.Tooth);
                        cmd.Parameters["@idTooth"].Direction = System.Data.ParameterDirection.Input;
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
    }
}
