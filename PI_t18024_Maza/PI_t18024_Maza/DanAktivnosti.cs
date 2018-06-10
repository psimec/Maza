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
        public List<Button> ListaAktivnosti = new List<Button>();

        public DanAktivnosti(DayOfWeek dan, Button aktivnost)
        {
            this.Dan = dan;
            ListaAktivnosti.Add(aktivnost);
        }

        public void DodajAktivnost(Button aktivnost)
        {
            ListaAktivnosti.Add(aktivnost);
        }
    }
}
