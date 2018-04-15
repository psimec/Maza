using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PI_t18024_Maza
{
    public class PropisaniLijek
    {
        private string kolicina;

        public Dijagnoza Dijagnoza
        {
            get => default(Dijagnoza);
            set
            {
            }
        }

        public Lijek Lijek
        {
            get => default(Lijek);
            set
            {
            }
        }

        public void DodajLijek()
        {
            //U objekt Lijek se dodaje lijek
        }

        public void DodajDijagnozu()
        {
            //U objekt Dijagnoza se dodaje dijagnoza
        }
    }
}