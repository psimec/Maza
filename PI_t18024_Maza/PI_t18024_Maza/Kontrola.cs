using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PI_t18024_Maza
{
    public class Kontrola
    {
        private DateTime datumKontrole;
        private string opis;

        //Lista cijepiva za zivotinju

        public Veterinar Veterinar
        {
            get => default(Veterinar);
            set
            {
            }
        }

        public Zivotinja Zivotinja
        {
            get => default(Zivotinja);
            set
            {
            }
        }

        public StatusAktivnosti StatusAktivnosti
        {
            get => default(StatusAktivnosti);
            set
            {
            }
        }

        public void DodajZivotinju()
        {
            //Dodavaj trenutacno selektiranu zivotinju iz liste
        }
    }
}