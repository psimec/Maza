﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_t18024_Maza
{
    public class DanAktivnosti
    {
        #region Varijable

        public DayOfWeek Dan;
        public DateTime datum;
        public List<Kontrola> ListaKontrola = new List<Kontrola>();

        #endregion

        #region Konstruktor

        /// <summary>
        /// Konstruktor klase dan aktivnosti
        /// </summary>
        /// <param name="dan"> Proslijedeni dan u tjednu </param>
        /// <param name="kontrola"> Proslijedena kontrola </param>

        public DanAktivnosti(DayOfWeek dan, Kontrola kontrola)
        {
            this.Dan = dan;
            ListaKontrola.Add(kontrola);
        }

        #endregion

        #region Metode

        /// <summary>
        /// Dodaje kontrolu u listu kontrola
        /// </summary>
        /// <param name="kontrola"> Kontrola za dodati u listu </param>

        public void DodajAktivnost(Kontrola kontrola)
        {
            ListaKontrola.Add(kontrola);
        }

        /// <summary>
        /// Sortira kontrole u listi kontrola prema datumu kontrole
        /// </summary>

        public void SortirajListuAktivnosti()
        {
            ListaKontrola = ListaKontrola.OrderBy(k => k.datum_kontrole).ToList();
        }

        #endregion
    }
}
