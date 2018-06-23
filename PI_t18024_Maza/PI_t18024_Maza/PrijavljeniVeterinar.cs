using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_t18024_Maza
{
    public static class PrijavljeniVeterinar
    {
        #region Varijable

        public static Veterinar Veterinar { get; set; }

        #endregion

        #region Metode

        /// <summary>
        /// Pamcenje trenutacno prijavljenog veterinara
        /// </summary>
        /// <param name="veterinar"> Trenutno prijavljeni veterinar </param>

        public static void PrijaviVeterinara(Veterinar veterinar)
        {
            Veterinar = veterinar;
        }

        #endregion
    }
}
