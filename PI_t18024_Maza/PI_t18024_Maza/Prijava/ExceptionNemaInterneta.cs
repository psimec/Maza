using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_t18024_Maza
{
    class ExceptionNemaInterneta : Exception
    {
        #region Varijable
   
        public string Poruka;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Kontruktor iznimke ExceptionNemaInterneta
        /// </summary>
        /// <param name="poruka"> Proslijedena poruka </param>

        public ExceptionNemaInterneta(string poruka)
        {
            this.Poruka = poruka;
        }

        #endregion
    }
}
