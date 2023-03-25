using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentilNew.model.security
{
    internal class Crypt
    {
        public string sha256(String value)
        {
            var crypt = new System.Security.Cryptography.SHA256Managed();
            var hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(value));

            foreach (byte theByte in crypto)
                hash.Append(theByte.ToString("x2"));

            return hash.ToString();
        }
    }
}
