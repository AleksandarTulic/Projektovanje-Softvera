using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentil.fileManagement
{
    public class FileOperations
    {
        public static List<String> getAllLines(string path)
        {
            List<string> res = new List<string>();

            foreach (string line in System.IO.File.ReadLines(path))
                res.Add(line);

            return res;
        }

        public static void writeAllLines(List<string> arr, string path)
        {
            try {
                File.WriteAllLines(path, arr);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Data + "\nPath: " + ex.StackTrace);
            }
        }

        public static bool copyFile(string src, string dest)
        {
            if ( File.Exists(src))
            {
                File.Copy(src, dest, true);
                return true;
            }

            return false;
        }
    }
}
