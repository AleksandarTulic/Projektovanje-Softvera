using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentil.dbManagement
{
    public class Delete
    {
        public static bool deleteElement(int id)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(Program.defaultCon.ConString))
                {
                    con.Open();

                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = "deleteElement";
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters["@id"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@flag", MySqlDbType.Bit);
                        cmd.Parameters["@flag"].Direction = System.Data.ParameterDirection.Output;
                        cmd.ExecuteNonQuery();

                        if ("1".Equals(cmd.Parameters["@flag"].Value.ToString()))
                            return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
            }

            return false;
        }

        public static bool deletePatient(string id)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(Program.defaultCon.ConString))
                {
                    con.Open();

                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = "deletePatient";
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters["@id"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@flag", MySqlDbType.Bit);
                        cmd.Parameters["@flag"].Direction = System.Data.ParameterDirection.Output;
                        cmd.ExecuteNonQuery();

                        if ("1".Equals(cmd.Parameters["@flag"].Value.ToString()))
                            return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
            }

            return false;
        }

        public static bool deleteShift(int id)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(Program.defaultCon.ConString))
                {
                    con.Open();

                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = "deleteShift";
                        cmd.Parameters.AddWithValue("@id", id-1);
                        cmd.Parameters["@id"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@flag", MySqlDbType.Bit);
                        cmd.Parameters["@flag"].Direction = System.Data.ParameterDirection.Output;
                        cmd.ExecuteNonQuery();

                        if ("1".Equals(cmd.Parameters["@flag"].Value.ToString()))
                            return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
            }

            return false;
        }

        public static bool deleteSchedule(string idPersonal, string id, string date)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(Program.defaultCon.ConString))
                {
                    con.Open();

                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = "deleteSchedule";
                        cmd.Parameters.AddWithValue("@idPersonal", idPersonal);
                        cmd.Parameters["@idPersonal"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters["@id"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@dateWhen", date);
                        cmd.Parameters["@dateWhen"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@flag", MySqlDbType.Bit);
                        cmd.Parameters["@flag"].Direction = System.Data.ParameterDirection.Output;
                        cmd.ExecuteNonQuery();

                        if ("1".Equals(cmd.Parameters["@flag"].Value.ToString()))
                            return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
            }

            return false;
        }

        public static bool deletePersonal(string idPersonal)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(Program.defaultCon.ConString))
                {
                    con.Open();

                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        Console.WriteLine("PERSONAL: " + idPersonal);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = "deletePersonal";
                        cmd.Parameters.AddWithValue("@id", idPersonal);
                        cmd.Parameters["@id"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@flag", MySqlDbType.Bit);
                        cmd.Parameters["@flag"].Direction = System.Data.ParameterDirection.Output;
                        cmd.ExecuteNonQuery();

                        if ("1".Equals(cmd.Parameters["@flag"].Value.ToString()))
                            return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
            }

            return false;
        }

        public static bool deleteAppointment(elements.helpElements.Date date, elements.helpElements.Time time, string dentistJmb)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(Program.defaultCon.ConString))
                {
                    con.Open();

                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = "deleteAppointment";
                        cmd.Parameters.AddWithValue("@startDate", date.ToString());
                        cmd.Parameters["@startDate"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@startTime", time.ToString());
                        cmd.Parameters["@startTime"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@personalJmb", dentistJmb);
                        cmd.Parameters["@personalJmb"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@flag", MySqlDbType.Bit);
                        cmd.Parameters["@flag"].Direction = System.Data.ParameterDirection.Output;
                        cmd.ExecuteNonQuery();

                        if ("1".Equals(cmd.Parameters["@flag"].Value.ToString()))
                            return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
            }

            return false;
        }
    }
}
