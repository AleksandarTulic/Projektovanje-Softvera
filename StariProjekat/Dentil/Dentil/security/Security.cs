using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentil.security
{
    public class Security
    {
        public static string getHash(string input)
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(input);
            using (var hash = System.Security.Cryptography.SHA512.Create())
            {
                var hashedInputBytes = hash.ComputeHash(bytes);

                var hashedInputStringBuilder = new System.Text.StringBuilder(128);
                foreach (var b in hashedInputBytes)
                    hashedInputStringBuilder.Append(b.ToString("x2"));

                return hashedInputStringBuilder.ToString();
            }
        }

        public static string numHash(int num, string password)
        {
            string hash = password;
            for (int i=0;i<num;i++)
                hash = getHash(hash);

            return hash;
        }
    }
}
