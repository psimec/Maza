using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_t18024_Maza
{
    class ExceptionNemaInterneta : Exception
    {
        public string Poruka;

        public ExceptionNemaInterneta(string poruka)
        {
            this.Poruka = poruka;
        }
    }
}
