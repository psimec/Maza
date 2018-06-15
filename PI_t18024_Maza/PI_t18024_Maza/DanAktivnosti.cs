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
        public DateTime datum;
        public List<Kontrola> ListaKontrola = new List<Kontrola>();

        public DanAktivnosti(DayOfWeek dan, Kontrola kontrola)
        {
            this.Dan = dan;
            ListaKontrola.Add(kontrola);
        }

        public void DodajAktivnost(Kontrola kontrola)
        {
            ListaKontrola.Add(kontrola);
        }

        public void SortirajListuAktivnosti()
        {
            ListaKontrola = ListaKontrola.OrderBy(k => k.datum_kontrole).ToList();
        }
    }
}
