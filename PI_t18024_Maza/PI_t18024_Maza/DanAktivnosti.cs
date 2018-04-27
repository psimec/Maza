using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_t18024_Maza
{
    public class DanAktivnosti
    {
        public DayOfWeek Dan;
        public int BrojAktivnosti;

        public DanAktivnosti(DayOfWeek dan, int brojAktivnosti)
        {
            this.Dan = dan;
            this.BrojAktivnosti = brojAktivnosti;
        }
    }
}
