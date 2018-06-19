using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Kriptografija
{
    public class Kriptiranje
    {
        private static string privatniKljuc = "7BDHFJ54";

        public static string kriptirajMD5(string input)
        {
            MD5 md5 = MD5.Create();
            byte[] podaci = ASCIIEncoding.UTF8.GetBytes(input);
            byte[] hash = md5.ComputeHash(podaci);
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                stringBuilder.Append(hash[i].ToString("x2"));
            }

            return stringBuilder.ToString();
        }

        public static bool usporediMD5(string rijec, string hash)
        {
            string rijecHash = kriptirajMD5(rijec + privatniKljuc);
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;

            if (stringComparer.Compare(rijecHash, hash) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
