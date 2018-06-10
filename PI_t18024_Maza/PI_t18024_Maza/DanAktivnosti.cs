using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_t18024_Maza
{
    public class DanAktivnosti
    {
        public DayOfWeek Dan;
        public List<Button> ListaAktivnosti;

        public DanAktivnosti(DayOfWeek dan)
        {
            this.Dan = dan;
            ListaAktivnosti = new List<Button>();
        }
    }
}
