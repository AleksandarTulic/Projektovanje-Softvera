using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentil.dbManagement
{
    public class Connection
    {
        string conString = "";

        public Connection()
        {
            List <string> conf = fileManagement.FileOperations.getAllLines($"{Directory.GetCurrentDirectory()}\\..\\..\\conf.txt");

            foreach (string i in conf)
                conString += i;
        }

        public string ConString 
        {
            get { return conString; }
            set { conString = value; }
        }
    }
}
