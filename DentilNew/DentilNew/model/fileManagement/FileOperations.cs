﻿using DentilNew.model.logger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentilNew.model.fileManagement
{
    internal class FileOperations
    {
        public static List<String> getAllLines(string path)
        {
            List<string> res = new List<string>();

            foreach (string line in System.IO.File.ReadLines(path))
                res.Add(line);

            return res;
        }

        public static bool saveLines(List<string> arr, string path)
        {
            bool flag = false;
            
            try
            {
                File.WriteAllLines(path, arr);
                flag = true;
            }
            catch (Exception ex)
            {
                MyLogger.Logger.log(ex.Message);
            }

            return flag;
        }
    }
}
