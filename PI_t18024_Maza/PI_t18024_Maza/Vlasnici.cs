using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_t18024_Maza
{
    public partial class Vlasnici : Dizajn
    {
        public Vlasnici()
        {
            InitializeComponent();
        }

        public void PopuniVlasnike()
        {

        }
        public void PopuniZivotinje(Vlasnik vlasnik)
        {
            BindingList<Zivotinja> listaZivotinja = null;
            using (var db = new MazaEntities())
            {
                db.Vlasnik.Attach(vlasnik);
                listaZivotinja = new BindingList<Zivotinja>(vlasnik.Zivotinja.ToList<Zivotinja>());
            }
            zivotinjaBindingSource.DataSource = listaZivotinja;
        }
        private void Vlasnici_Load(object sender, EventArgs e)
        {
            PopuniVlasnike();
        }

        private void uiPrikazVlasnika_SelectionChanged(object sender, EventArgs e)
        {
            Vlasnik selektiraniVlasnik = vlasnikBindingSource.Current as Vlasnik;
            if (selektiraniVlasnik != null)
            {
                PopuniZivotinje(selektiraniVlasnik);
            }
        }
    }
}
