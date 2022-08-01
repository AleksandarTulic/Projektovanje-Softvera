using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Dentil.dbManagement
{
    public class Query
    {
        public const string allShift = "select * from Shift;";
        public const string allPersonal = "select * from Personal;";
        public const string allUserSpecificInfo = "select * from getuserspecificinfo;";
        public const string allPatients = "select * from patient;";
        public const string allDentist = "select * from getAllDentist";
        public const string allTypeProblem = "select * from typeproblem;";
        public const string allTeeth = "select * from teeth;";
        public const string allVisits = "select * from getallvisits;";
        public const string allItemAndServices = "select * from itemandservices;";
        
        public static List<List<string>> query(string q)
        {
            List<List<string>> arr = new List<List<string>>();

            try
            {
                using (MySqlConnection con = new MySqlConnection(Program.defaultCon.ConString))
                {
                    con.Open();

                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = q;

                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            List<string> arrBuff = new List<string>();
                            for (int i = 0; i < reader.FieldCount; i++)
                                if (!reader.IsDBNull(i))
                                    arrBuff.Add(reader.GetString(i));
                                else
                                    arrBuff.Add("0");

                            arr.Add(arrBuff);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
            }

            return arr;
        }

        public static bool checkLogIn(string hash, string userName, string type)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(Program.defaultCon.ConString))
                {
                    con.Open();

                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = "checkHash";
                        cmd.Parameters.AddWithValue("@hash", hash);
                        cmd.Parameters["@hash"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@userName", userName);
                        cmd.Parameters["@userName"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@typePersonal", type);
                        cmd.Parameters["@typePersonal"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@flag", MySqlDbType.Bit);
                        cmd.Parameters["@flag"].Direction = System.Data.ParameterDirection.Output;
                        cmd.ExecuteNonQuery();

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

        public static List<user.User> getUser(string id, string name, string surname, string email, string phone, string city, string hash, string userName, string gender)
        {
            List <user.User> arr = new List<user.User>();
            
            try
            {
                using (MySqlConnection con = new MySqlConnection(Program.defaultCon.ConString))
                {
                    con.Open();

                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = "getUser1";
                        cmd.Parameters.AddWithValue("@hash", hash);
                        cmd.Parameters["@hash"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@userName", userName);
                        cmd.Parameters["@userName"].Direction = System.Data.ParameterDirection.Input;
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
                        cmd.Parameters.AddWithValue("@testGender", "Male".Equals(gender) ? 0 : "Female".Equals(gender) ? 1 : -1 ); ;
                        cmd.Parameters["@testGender"].Direction = System.Data.ParameterDirection.Input;

                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            List <string> elements = new List<string>();
                            for (int i = 0; i < reader.FieldCount; i++)
                                elements.Add(reader.GetString(i));

                            arr.Add(new user.User(elements));
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
            }

            return arr;
        }

        public static user.User getUser(string id)
        {
            return getUser(id, "", "", "", "", "", "", "", "-")[0];
        }

        public static List<elements.helpElements.Date> getUserScheduleDates(string id)
        {
            List <elements.helpElements.Date> arrDate = new List<elements.helpElements.Date>();

            try
            {
                using (MySqlConnection con = new MySqlConnection(Program.defaultCon.ConString))
                {
                    con.Open();

                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = "getUserScheduleDates";
                        cmd.Parameters.AddWithValue("@idPersonal", id);
                        cmd.Parameters["@idPersonal"].Direction = System.Data.ParameterDirection.Input;
                        MySqlDataReader reader = cmd.ExecuteReader();
                    
                        while (reader.Read())
                                arrDate.Add(new elements.helpElements.Date(reader.GetString(0)));
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
            }

            return arrDate;
        }

        public static List<string> getUserScheduleDateShifts(string id, string date)
        {
            List<string> arrShift = new List<string>();

            try
            {
                using (MySqlConnection con = new MySqlConnection(Program.defaultCon.ConString))
                {
                    con.Open();

                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = "getUserScheduleDatesShifts";
                        cmd.Parameters.AddWithValue("@idPersonal", id);
                        cmd.Parameters["@idPersonal"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@dateWhen", date);
                        cmd.Parameters["@dateWhen"].Direction = System.Data.ParameterDirection.Input;
                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                                arrShift.Add(Program.lang.translate("Shift", Program.defaultLang, Program.lang.CurrLang) + " " + reader.GetString(0) + " , " + reader.GetString(1) + " - " + reader.GetString(1));
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
            }

            return arrShift;
        }

        public static List<string> getShiftAdmin(string idPersonal, string id, string dateWhen)
        {
            List<string> arr = new List<string>();

            try
            {
                using (MySqlConnection con = new MySqlConnection(Program.defaultCon.ConString))
                {
                    con.Open();

                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = "getShiftAdmin";
                        cmd.Parameters.AddWithValue("@idPersonal", idPersonal);
                        cmd.Parameters["@idPersonal"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters["@id"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@dateWhen", dateWhen);
                        cmd.Parameters["@dateWhen"].Direction = System.Data.ParameterDirection.Input;
                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            arr.Add(reader.GetString(0));
                            arr.Add(reader.GetString(1));
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
            }

            return arr;
        }

        public static List<user.Patient> getPatients(string id, string name, string surname)
        {
            List<user.Patient> arr = new List<user.Patient>();

            try
            {
                using (MySqlConnection con = new MySqlConnection(Program.defaultCon.ConString))
                {
                    con.Open();

                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = "getUser2";
                        cmd.Parameters.AddWithValue("@jmb", id);
                        cmd.Parameters["@jmb"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters["@name"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@surname", surname);
                        cmd.Parameters["@surname"].Direction = System.Data.ParameterDirection.Input;

                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            List<string> elements = new List<string>();
                            for (int i = 0; i < reader.FieldCount; i++)
                                if (reader.IsDBNull(i))
                                    elements.Add("0");
                                else
                                    elements.Add(reader.GetString(i));

                            arr.Add(new user.Patient(elements));
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
            }

            return arr;
        }

        public static List<appointment.Appointment> getAppointments(string date, string personalJmb, string patientJmb, string name, string surname)
        {
            //Console.WriteLine(date);
            List<appointment.Appointment> arr = new List<appointment.Appointment>();

            try
            {
                using (MySqlConnection con = new MySqlConnection(Program.defaultCon.ConString))
                {
                    con.Open();

                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = "getAppointments";
                        cmd.Parameters.AddWithValue("@startDate", date == null ? "" : date);
                        cmd.Parameters["@startDate"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@personalJmb", personalJmb);
                        cmd.Parameters["@personalJmb"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@jmb", patientJmb);
                        cmd.Parameters["@jmb"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters["@name"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@surname", surname);
                        cmd.Parameters["@surname"].Direction = System.Data.ParameterDirection.Input;

                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            List<string> elements = new List<string>();
                            for (int i = 0; i < reader.FieldCount; i++)
                                if (reader.IsDBNull(i))
                                    elements.Add("0");
                                else
                                    elements.Add(reader.GetString(i));

                            arr.Add(new appointment.Appointment(elements));
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
            }

            return arr;
        }

        public static bool checkDentistWorks(string dentistJmb, elements.helpElements.Date date, elements.helpElements.Time time, int howLong)
        {
            Console.WriteLine($"{date.ToString()}, {time.ToString()}");
            try
            {
                using (MySqlConnection con = new MySqlConnection(Program.defaultCon.ConString))
                {
                    con.Open();

                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = "checkDentistWorks";
                        cmd.Parameters.AddWithValue("@personalJmb", dentistJmb);
                        cmd.Parameters["@personalJmb"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@startDate", date.ToString());
                        cmd.Parameters["@startDate"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@startTime", time.ToString());
                        cmd.Parameters["@startTime"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@howLong", howLong);
                        cmd.Parameters["@howLong"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@flag", MySqlDbType.Bit);
                        cmd.Parameters["@flag"].Direction = System.Data.ParameterDirection.Output;
                        cmd.ExecuteNonQuery();

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

        public static List<List<string> > getLastSeen(int visitId)
        {
            List<List<string>> arr = new List<List<string>>();
            try
            {
                using (MySqlConnection con = new MySqlConnection(Program.defaultCon.ConString))
                {
                    con.Open();

                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = "getLastSeen";
                        cmd.Parameters.AddWithValue("@visitId", visitId);
                        cmd.Parameters["@visitId"].Direction = System.Data.ParameterDirection.Input;
                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            List<string> elements = new List<string>();
                            for (int i = 0; i < reader.FieldCount; i++)
                                if (reader.IsDBNull(i))
                                    elements.Add("0");
                                else
                                    elements.Add(reader.GetString(i));

                            arr.Add(elements);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
            }

            return arr;
        }

        public static List<string> getDateTimeBill(int id)
        {
            List<string> arr = new List<string>();
            try
            {
                using (MySqlConnection con = new MySqlConnection(Program.defaultCon.ConString))
                {
                    con.Open();

                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = "getDateTimeBill";
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters["@id"].Direction = System.Data.ParameterDirection.Input;
                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                                    arr.Add(reader.GetString(i));
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
            }

            return arr;
        }
    }
}
