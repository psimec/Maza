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
    public partial class frmVlasnici : frmDizajn
    {
        public frmVlasnici()
        {
            InitializeComponent();
            PopuniVlasnike();
        }

        public void PopuniVlasnike()
        {
            BindingList<Vlasnik> listaVlasnika = null;
            using (var db = new MazaEntities())
            {
                listaVlasnika = new BindingList<Vlasnik>(db.Vlasnik.ToList());
            }
            vlasnikBindingSource.DataSource = listaVlasnika;
        }

        public void PopuniZivotinje(Vlasnik oznaceni)
        {
            BindingList<Zivotinja> listaZivotinja = null;
            using (var db = new MazaEntities())
            {
                db.Vlasnik.Attach(oznaceni);
                listaZivotinja = new BindingList<Zivotinja>(oznaceni.Zivotinja.ToList());
            }
            zivotinjaBindingSource.DataSource = listaZivotinja;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Vlasnik oznaceni = vlasnikBindingSource.Current as Vlasnik;
            if (oznaceni != null)
            {
                PopuniZivotinje(oznaceni);
            }
        }
    }
}
