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
        int zadnjiKliknutiStupac;
        public frmVlasnici()
        {
            InitializeComponent();
            zadnjiKliknutiStupac = 0;
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

        private void uiActionDodajZivotinju_Click(object sender, EventArgs e)
        {
            frmDodajZivotinju dodajZivotinju = new frmDodajZivotinju(vlasnikBindingSource.Current as Vlasnik);
            dodajZivotinju.ShowDialog();
            PopuniZivotinje(vlasnikBindingSource.Current as Vlasnik);
        }

        private void uiPrikazVlasnika_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int brojStupaca = e.ColumnIndex;
            if(zadnjiKliknutiStupac != brojStupaca)
            {
                SortirajVlasnikeUzlazno(brojStupaca);
                zadnjiKliknutiStupac = brojStupaca;
            }
            else
            {
                SortirajVlasnikeSilazno(brojStupaca);
                zadnjiKliknutiStupac = 0;
            }
        }

        private void uiActionAzurirajVlasnika_Click(object sender, EventArgs e)
        {
            frmAzurirajVlasnike azurirajVlasnika = new frmAzurirajVlasnike(vlasnikBindingSource.Current as Vlasnik);
            azurirajVlasnika.ShowDialog();
            PopuniVlasnike();
        }

        private void uiDodajVlasnika_Click(object sender, EventArgs e)
        {
            frmAzurirajVlasnike dodajVlasnika = new frmAzurirajVlasnike();
            dodajVlasnika.ShowDialog();
            PopuniVlasnike();
        }

        private void uiIzbrisiVlasnika_Click(object sender, EventArgs e)
        {
            Vlasnik selektiraniVlasnik = vlasnikBindingSource.Current as Vlasnik;
            if(selektiraniVlasnik != null)
            {
                if(MessageBox.Show("Da li ste sigurni?","Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new MazaEntities())
                    {
                        db.Vlasnik.Attach(selektiraniVlasnik);
                        if(selektiraniVlasnik.Zivotinja.Count == 0)
                        {
                            db.Vlasnik.Remove(selektiraniVlasnik);
                            db.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Nije moguće obrisati vlasnika jer sadrži životinje, prvo obriši životinje");
                        }
                    }
                }
                PopuniVlasnike();
            }
        }

        private void FiltrirajVlasnike(string vlasnik)
        {
            BindingList<Vlasnik> listaVlasnika;
            using (var db = new MazaEntities())
            {
                listaVlasnika = new BindingList<Vlasnik>(db.Vlasnik.Where
                    (v => (v.ime.Contains(vlasnik) || v.prezime.Contains(vlasnik) || v.adresa_stavnovanja.Contains(vlasnik) || v.broj_telefona1.Contains(vlasnik) || v.broj_telefona2.Contains(vlasnik) || v.email.Contains(vlasnik))).ToList());
            }
            vlasnikBindingSource.DataSource = listaVlasnika;
        }

        private void uiFiltrirajVlasnike_TextChanged(object sender, EventArgs e)
        {
            FiltrirajVlasnike(uiFiltrirajVlasnike.Text);
        }

        private void SortirajVlasnikeUzlazno(int stupac)
        {
            BindingList<Vlasnik> vlasnici;
            using (var db = new MazaEntities())
            {
                switch (stupac)
                {
                    case 1:
                        vlasnici = new BindingList<Vlasnik>(db.Vlasnik.OrderBy(v => v.ime).ToList());
                        break;
                    case 2:
                        vlasnici = new BindingList<Vlasnik>(db.Vlasnik.OrderBy(v => v.prezime).ToList());
                        break;
                    case 3:
                        vlasnici = new BindingList<Vlasnik>(db.Vlasnik.OrderBy(v => v.adresa_stavnovanja).ToList());
                        break;
                    case 4:
                        vlasnici = new BindingList<Vlasnik>(db.Vlasnik.OrderBy(v => v.broj_telefona1).ToList());
                        break;
                    case 5:
                        vlasnici = new BindingList<Vlasnik>(db.Vlasnik.OrderBy(v => v.broj_telefona2).ToList());
                        break;
                    case 6:
                        vlasnici = new BindingList<Vlasnik>(db.Vlasnik.OrderBy(v => v.email).ToList());
                        break;
                    default:
                        vlasnici = new BindingList<Vlasnik>(db.Vlasnik.ToList());
                        break;
                }
            }
            uiPrikazVlasnika.DataSource = vlasnici;
        }

        private void SortirajVlasnikeSilazno(int stupac)
        {
            BindingList<Vlasnik> vlasnici;
            using (var db = new MazaEntities())
            {
                switch (stupac)
                {
                    case 1:
                        vlasnici = new BindingList<Vlasnik>(db.Vlasnik.OrderByDescending(v => v.ime).ToList());
                        break;
                    case 2:
                        vlasnici = new BindingList<Vlasnik>(db.Vlasnik.OrderByDescending(v => v.prezime).ToList());
                        break;
                    case 3:
                        vlasnici = new BindingList<Vlasnik>(db.Vlasnik.OrderByDescending(v => v.adresa_stavnovanja).ToList());
                        break;
                    case 4:
                        vlasnici = new BindingList<Vlasnik>(db.Vlasnik.OrderByDescending(v => v.broj_telefona1).ToList());
                        break;
                    case 5:
                        vlasnici = new BindingList<Vlasnik>(db.Vlasnik.OrderByDescending(v => v.broj_telefona2).ToList());
                        break;
                    case 6:
                        vlasnici = new BindingList<Vlasnik>(db.Vlasnik.OrderByDescending(v => v.email).ToList());
                        break;
                    default:
                        vlasnici = new BindingList<Vlasnik>(db.Vlasnik.ToList());
                        break;
                }
            }
            uiPrikazVlasnika.DataSource = vlasnici;
        }
    }
}
