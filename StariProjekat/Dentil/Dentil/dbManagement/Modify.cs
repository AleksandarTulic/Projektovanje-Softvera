using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentil.dbManagement
{
    public class Modify
    {
        public static bool modifyElement(elements.Elements element)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(Program.defaultCon.ConString))
                {
                    con.Open();

                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = "modifyElement";
                        cmd.Parameters.AddWithValue("@id", element.Id);
                        cmd.Parameters["@id"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@name", element.Name);
                        cmd.Parameters["@name"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@cost", element.Cost);
                        cmd.Parameters["@cost"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@descr", element.Description);
                        cmd.Parameters["@descr"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@path", element.Path);
                        cmd.Parameters["@path"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@type", element.Type.ToString());
                        cmd.Parameters["@type"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@flag", MySqlDbType.Bit);
                        cmd.Parameters["@flag"].Direction = System.Data.ParameterDirection.Output;
                        cmd.ExecuteNonQuery();

                        return "1".Equals(cmd.Parameters["@flag"].Value.ToString()) ? true : false;
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
                return false;
            }
        }

        public static bool modifyPersonal(string idOld, string id, string name, string surname, string gender, string city, string street, int streetNum, string email, string phone,
            string bank, string bankAccount, string title, string educationPlace, string userName)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(Program.defaultCon.ConString))
                {
                    con.Open();

                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = "modifyPersonal";
                        cmd.Parameters.AddWithValue("@jmbOld", idOld);
                        cmd.Parameters["@jmbOld"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@jmb", id);
                        cmd.Parameters["@jmb"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters["@name"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@surname", surname);
                        cmd.Parameters["@surname"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters["@email"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters["@phone"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@city", city);
                        cmd.Parameters["@city"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@street", street);
                        cmd.Parameters["@street"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@streetNum", streetNum);
                        cmd.Parameters["@streetNum"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@gender", "Male".Equals(gender) ? 0 : 1);
                        cmd.Parameters["@gender"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@userName", userName);
                        cmd.Parameters["@userName"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@bank", bank);
                        cmd.Parameters["@bank"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@numAccount", bankAccount);
                        cmd.Parameters["@numAccount"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@title", title);
                        cmd.Parameters["@title"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@educationPlace", educationPlace);
                        cmd.Parameters["@educationPlace"].Direction = System.Data.ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@flag", MySqlDbType.Bit);
                        cmd.Parameters["@flag"].Direction = System.Data.ParameterDirection.Output;
                        cmd.ExecuteNonQuery();

                        //Console.WriteLine("REZULTAT: " + cmd.Parameters["@flag"].Value);
                        if ("1".Equals(cmd.Parameters["@flag"].Value.ToString()))
                            return true;
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
            }

            return false;
        }

        public static bool modifyPatient(user.Patient patient, string jmb, string name, string surname, string email, string phone, string city, string street, string streetNum, string gender)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(Program.defaultCon.ConString))
                {
                    con.Open();

                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = "modifyPatient";
                        cmd.Parameters.AddWithValue("@jmbOld", patient.Id);
                        cmd.Parameters["@jmbOld"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@jmb", jmb);
                        cmd.Parameters["@jmb"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters["@name"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@surname", surname);
                        cmd.Parameters["@surname"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters["@email"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters["@phone"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@city", city);
                        cmd.Parameters["@city"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@street", street);
                        cmd.Parameters["@street"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@streetNum", "".Equals(streetNum) ? -1 : int.Parse(streetNum));
                        cmd.Parameters["@streetNum"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@gender", "Male".Equals(gender) ? 0 : 1);
                        cmd.Parameters["@gender"].Direction = System.Data.ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("@flag", MySqlDbType.Bit);
                        cmd.Parameters["@flag"].Direction = System.Data.ParameterDirection.Output;
                        cmd.ExecuteNonQuery();

                        return "1".Equals(cmd.Parameters["@flag"].Value.ToString()) ? true : false;
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
