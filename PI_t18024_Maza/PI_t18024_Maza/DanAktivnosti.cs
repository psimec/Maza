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
        public static int X;
        public int Y;
        public int BrojAktivnosti;

        public DanAktivnosti(DayOfWeek dan, int Y, int brojAktivnosti)
        {
            this.Dan = dan;
            this.Y = Y;
            this.BrojAktivnosti = brojAktivnosti;
        }
    }
}
