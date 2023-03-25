using DentilNew.model.logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DentilNew.model.validation
{
    internal class Validation : IValidation
    {
        public bool check(string text, string pattern)
        {
            try {
                return Regex.IsMatch(text, pattern);
            }
            catch(Exception e)
            {
                MyLogger.Logger.log(e.Message);
            }

            return false;
        }
    }
}
