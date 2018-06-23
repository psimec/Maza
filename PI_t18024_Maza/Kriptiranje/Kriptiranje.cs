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
        #region Varijable

        private static string privatniKljuc = "7BDHFJ54";

        #endregion

        #region Metode

        /// <summary>
        /// Kriptira proslijedene znakove pomocu MD5 algoritma
        /// </summary>
        /// <param name="input"> Proslijedeni znakovi </param>
        /// <returns> Kriptirani znakovi </returns>

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

        /// <summary>
        /// Usporeduje proslijedene znakove i proslijedene kriptirane znakove
        /// </summary>
        /// <param name="rijec"> Proslijedeni znakovi </param>
        /// <param name="hash"> Proslijedeni kriptirani znakovi </param>
        /// <returns> Rezultat usporedbe </returns>

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

        #endregion

    }
}
