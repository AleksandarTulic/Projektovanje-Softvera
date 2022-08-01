using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentil.dbManagement
{
    public class Insert
    {
        public static bool insertElement(elements.Elements element)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(Program.defaultCon.ConString))
                {
                    con.Open();

                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = "insertElement";
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
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
                return false;
            }
            return true;
        }

        public static bool insertShift(string Shours, string Sminute, string Ehours, string Eminute)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(Program.defaultCon.ConString))
                {
                    con.Open();

                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = "insertShift";
                        cmd.Parameters.AddWithValue("@begin", Shours + Sminute + "00");
                        cmd.Parameters["@begin"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@end", Ehours + Eminute + "00");
                        cmd.Parameters["@end"].Direction = System.Data.ParameterDirection.Input;
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

        public static bool insertSchedule(List <user.User> arrUser, List<elements.helpElements.Date> arrDate, elements.Shift shift)
        {
            //Console.WriteLine(arrDate.Count + " " + arrUser.Count);
            bool flag = true;
            try
            {

                    for (int i = 0; i < arrUser.Count; i++)
                    {
                        for (int j = 0; j < arrDate.Count; j++)
                        {
                            using (MySqlConnection con = new MySqlConnection(Program.defaultCon.ConString))
                            {
                                con.Open();
                                using (MySqlCommand cmd = con.CreateCommand())
                                {
                                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                                    cmd.CommandText = "insertSchedule";
                                    cmd.Parameters.AddWithValue("@idAdmin", Program.user.Id);
                                    cmd.Parameters["@idAdmin"].Direction = System.Data.ParameterDirection.Input;
                                    cmd.Parameters.AddWithValue("@idPersonal", arrUser[i].Id);
                                    cmd.Parameters["@idPersonal"].Direction = System.Data.ParameterDirection.Input;
                                    cmd.Parameters.AddWithValue("@id", shift.Id);
                                    cmd.Parameters["@id"].Direction = System.Data.ParameterDirection.Input;
                                    //Console.WriteLine("INSERT: " + arrDate[j].getWithZero());
                                    cmd.Parameters.AddWithValue("@dateWhen", arrDate[j].getWithZero());
                                    cmd.Parameters["@dateWhen"].Direction = System.Data.ParameterDirection.Input;
                                    cmd.Parameters.AddWithValue("@flag", MySqlDbType.Bit);
                                    cmd.Parameters["@flag"].Direction = System.Data.ParameterDirection.Output;
                                    cmd.ExecuteNonQuery();

                                    //Console.WriteLine($"{Admin.user.Id} : {arrUser[i].Id} : {shift.Id} : {arrDate[j].ToString()} : {cmd.Parameters["@flag"].Value}");

                                    if (flag)
                                        flag = "1".Equals(cmd.Parameters["@flag"].Value.ToString());
                                }
                            }
                        }
                    }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
            }

            return flag;
        }

        public static bool insertPersonal(string id, string name, string surname, string gender, string city, string street, int streetNum, string email, string phone,
            string bank, string bankAccount, string title, string educationPlace, string userName, string password)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(Program.defaultCon.ConString))
                {
                    con.Open();

                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = "insertPersonal";
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
                        cmd.Parameters.AddWithValue("@hash", security.Security.numHash(3, password));
                        cmd.Parameters["@hash"].Direction = System.Data.ParameterDirection.Input;
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

                        Console.WriteLine("Education: " + educationPlace + " " + educationPlace.Length);
                        Console.WriteLine("Title: " + title + " " + title.Length);

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

        public static bool insertPatient(string jmb, string name, string surname, string email, string phone, string city, string street, string streetNum, string gender)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(Program.defaultCon.ConString))
                {
                    con.Open();

                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = "insertPatient";
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

        public static bool insertTypeProblem(string name, string desc, string picturePath)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(Program.defaultCon.ConString))
                {
                    con.Open();

                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = "insertTypeProblem";
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters["@name"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@descr", desc);
                        cmd.Parameters["@descr"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@picturePath", picturePath);
                        cmd.Parameters["@picturePath"].Direction = System.Data.ParameterDirection.Input;
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

        public static bool insertAppointment(elements.helpElements.Date date, elements.helpElements.Time time, int howLong, string dentistJmb, string patientJmb, string note)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(Program.defaultCon.ConString))
                {
                    con.Open();

                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = "insertAppointment";
                        cmd.Parameters.AddWithValue("@startDate", date.ToString());
                        cmd.Parameters["@startDate"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@startTime", time.ToString());
                        cmd.Parameters["@startTime"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@howLong", howLong);
                        cmd.Parameters["@howLong"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@personalJmb", dentistJmb);
                        cmd.Parameters["@personalJmb"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@patientJmb", patientJmb);
                        cmd.Parameters["@patientJmb"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@note", note);
                        cmd.Parameters["@note"].Direction = System.Data.ParameterDirection.Input;
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

        public static int insertVisit(string pJmb, string dJmb, List<problem.Problem> pr)
        {
            bool flag = true;
            int idOut = -1;
            try
            {
                using (MySqlConnection con = new MySqlConnection(Program.defaultCon.ConString))
                {
                    con.Open();

                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = "insertVisit";
                        cmd.Parameters.AddWithValue("@pJmb", pJmb);
                        cmd.Parameters["@pJmb"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@dJmb", dJmb);
                        cmd.Parameters["@dJmb"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@idOut", MySqlDbType.Int32);
                        cmd.Parameters["@idOut"].Direction = System.Data.ParameterDirection.Output;
                        cmd.ExecuteNonQuery();

                        int id = int.Parse(cmd.Parameters["@idOut"].Value.ToString());
                        idOut = id;
                        foreach (problem.Problem i in pr)
                        {
                            bool flagBuf = insertProblem(id, i);
                            if (flag && !flagBuf)
                            {
                                flag = false;
                                idOut = -1;
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
                flag = false;
                idOut = -1;
            }

            return idOut;
        }

        private static bool insertProblem(int id, problem.Problem i)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(Program.defaultCon.ConString))
                {
                    con.Open();

                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = "insertVisitProblems";
                        cmd.Parameters.AddWithValue("@visitId", id);
                        cmd.Parameters["@visitId"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@numTeeth", i.Teeth);
                        cmd.Parameters["@numTeeth"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@name", i.Name);
                        cmd.Parameters["@name"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@flag", MySqlDbType.Bit);
                        cmd.Parameters["@flag"].Direction = System.Data.ParameterDirection.Output;
                        cmd.ExecuteNonQuery();

                        if ("0".Equals(cmd.Parameters["@flag"].Value.ToString()))
                            return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
            }

            return true;
        }

        public static void insertLastSeen(string dentistJmb, int visitId)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(Program.defaultCon.ConString))
                {
                    con.Open();

                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = "insertLastSeen";
                        cmd.Parameters.AddWithValue("@jmb", dentistJmb);
                        cmd.Parameters["@jmb"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@visitId", visitId);
                        cmd.Parameters["@visitId"].Direction = System.Data.ParameterDirection.Input;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
            }
        }

        public static bool insertBill(int id, bill.Bill bill)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(Program.defaultCon.ConString))
                {
                    con.Open();

                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = "insertBill";
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters["@id"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@cost", bill.Cost());
                        cmd.Parameters["@cost"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@personalJmb", Program.user.Id);
                        cmd.Parameters["@personalJmb"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@flag", MySqlDbType.Bit);
                        cmd.Parameters["@flag"].Direction = System.Data.ParameterDirection.Output;
                        cmd.ExecuteNonQuery();

                        if ("1".Equals(cmd.Parameters["@flag"].Value.ToString()))
                        {
                            foreach (bill.ISBill i in bill.Arr)
                                insertBillItem(id, i.Id);
                                
                            return true;
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
            }

            return false;
        }

        private static void insertBillItem(int id, int idIS)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(Program.defaultCon.ConString))
                {
                    con.Open();

                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = "insertBillItem";
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters["@id"].Direction = System.Data.ParameterDirection.Input;
                        cmd.Parameters.AddWithValue("@idIS", idIS);
                        cmd.Parameters["@idIS"].Direction = System.Data.ParameterDirection.Input;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
            }
        }
    }
}
