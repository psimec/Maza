using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PI_t18024_Maza
{
    public class CijepivoZaZivotinju
    {
        private DateTime datum;

        public Kontrola Kontrola
        {
            get => default(Kontrola);
            set
            {
            }
        }

        public Cijepivo Cijepivo
        {
            get => default(Cijepivo);
            set
            {
            }
        }

        public void DodijelaCijepiva()
        {
            //Dodijela cijepiva u objekt Cijepivo
        }

        public void DodijelaKontrole()
        {
            //Dodijela kontrole u objekt Kontrola
        }
    }
}