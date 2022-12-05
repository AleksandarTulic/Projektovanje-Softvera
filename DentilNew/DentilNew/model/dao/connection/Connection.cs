using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace DentilNew.model.dao.connection
{
    internal class Connection
    {
        private static readonly string WHERE = $"{Directory.GetCurrentDirectory()}\\..\\..\\model\\dao\\connection\\conf.txt";
        private static Connection conn = new Connection();
        private string conString = "";
        
        private Connection()
        {
            List<string> conf = fileManagement.FileOperations.getAllLines(WHERE);

            foreach (string i in conf)
                conString += i;
        }

        public string ConString
        {
            get { return conString; }
            set { conString = value; }
        }

        public static Connection Conn
        {
            get { return conn; }
        }
    }
}
