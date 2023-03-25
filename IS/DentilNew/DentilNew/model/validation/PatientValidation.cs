using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Threading.Tasks;

namespace DentilNew.model.validation
{
    internal class PatientValidation : Validation
    {
        private static readonly string REGEX_PATTERN_ID = "^[0-9]{13}$";
        private static readonly string REGEX_PATTERN_NAME = "^[a-zA-Z]{2,100}$";
        private static readonly string REGEX_PATTERN_SURNAME = "^[a-zA-Z]{2,100}$";
        private static readonly string REGEX_PATTERN_EMAIL = "^$|^[a-zA-Z0-9_]+@[a-zA-Z0-9_]+\\.[a-zA-Z0-9_]{2,4}";
        private static readonly string REGEX_PATTERN_PHONE = "^$|^[0-9]{2,30}$";
        private static readonly string REGEX_PATTERN_ADDRESS = "^$|^.{2,250}$";

        public bool checkID(string id)
        {
            return check(id, REGEX_PATTERN_ID);
        }

        public bool checkName(string name)
        {
            return check(name, REGEX_PATTERN_NAME);
        }

        public bool checkSurname(string surname)
        {
            return check(surname, REGEX_PATTERN_SURNAME);
        }

        private bool checkEmail(string email)
        {
            //for more watch MailAddress class
            return check(email, REGEX_PATTERN_EMAIL);
        }

        private bool checkPhone(string phone)
        {
            return check(phone, REGEX_PATTERN_PHONE);
        }

        private bool checkAddress(string address)
        {
            return check(address, REGEX_PATTERN_ADDRESS);
        }

        public bool checkNotRequiredAttributes(string email, string phone, string address)
        {
            return checkEmail(email) && checkPhone(phone) && checkAddress(address);
        }
    }
}
