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
    public partial class frmZivotinje : frmDizajn
    {
        #region Globalne varijable
        int zadnjiKliknutiStupac;
        #endregion

        #region Konstruktor forme frmZivotinje
        public frmZivotinje()
        {
            InitializeComponent();
            zadnjiKliknutiStupac = 0;
        }
        #endregion

        #region Funkcije        
        
        /// <summary>
        /// Funkcija za prikaz životinja u datagridview
        /// </summary>
        public void PrikaziZivotinje()
        {
            BindingList<ViewPrikazZivotinja> listaZivotinja = null;
            using (var db = new MazaEntities())
            {
                listaZivotinja = new BindingList<ViewPrikazZivotinja>(db.ViewPrikazZivotinja.ToList());
            }
            uiPrikazZivotinja.DataSource = listaZivotinja;

            uiPrikazZivotinja.Columns[0].Visible = false;
        }

        /// <summary>
        /// Funkcija za filtriranje životinja po unesenom parametru
        /// </summary>
        /// <param name="zivotinja">Unešeni parametar u textboxu po kojem se filtrira datagridview</param>
        private void Filtriraj(string zivotinja)
        {
            BindingList<ViewPrikazZivotinja> viewZivotinja;
            using (var db = new MazaEntities())
            {
                if (DateTime.TryParse(zivotinja, out DateTime datum))
                {
                    viewZivotinja = new BindingList<ViewPrikazZivotinja>(db.ViewPrikazZivotinja.Where
                        (
                            z => (z.Datum_Rođenja.Year == datum.Year || z.Datum_Rođenja.Month == datum.Month || z.Datum_Rođenja.Day == datum.Day)
                        ).ToList());
                }
                else
                {
                    viewZivotinja = new BindingList<ViewPrikazZivotinja>(db.ViewPrikazZivotinja.Where
                        (
                            z => (z.Ime.Contains(zivotinja) || z.Ime_Vlasnika.Contains(zivotinja) || z.Prezime_Vlasnika.Contains(zivotinja) || z.Vrsta.Contains(zivotinja))
                        ).ToList());
                }
                uiPrikazZivotinja.DataSource = viewZivotinja;
            }
        }
        
        
        /// <summary>
        /// Funkcija za sortiranje zivotinja uzlazno
        /// </summary>
        /// <param name="stupac">Odabrani stupac po kojemu se sortira</param>
        private void SortirajZivotinjeUzlazno(int stupac)
        {
            BindingList<ViewPrikazZivotinja> zivotinje;
            using (var db = new MazaEntities())
            {
                switch (stupac)
                {
                    case 1:
                        zivotinje = new BindingList<ViewPrikazZivotinja>(db.ViewPrikazZivotinja.OrderBy(z => z.Ime).ToList());
                        break;
                    case 2:
                        zivotinje = new BindingList<ViewPrikazZivotinja>(db.ViewPrikazZivotinja.OrderBy(z => z.Spol).ToList());
                        break;
                    case 3:
                        zivotinje = new BindingList<ViewPrikazZivotinja>(db.ViewPrikazZivotinja.OrderBy(z => z.Vrsta).ToList());
                        break;
                    case 4:
                        zivotinje = new BindingList<ViewPrikazZivotinja>(db.ViewPrikazZivotinja.OrderBy(z => z.Datum_Rođenja).ToList());
                        break;
                    case 5:
                        zivotinje = new BindingList<ViewPrikazZivotinja>(db.ViewPrikazZivotinja.OrderBy(z => z.Broj_Čipa).ToList());
                        break;
                    case 6:
                        zivotinje = new BindingList<ViewPrikazZivotinja>(db.ViewPrikazZivotinja.OrderBy(z => z.Težina).ToList());
                        break;
                    case 7:
                        zivotinje = new BindingList<ViewPrikazZivotinja>(db.ViewPrikazZivotinja.OrderBy(z => z.Datum_Uginuća).ToList());
                        break;
                    case 8:
                        zivotinje = new BindingList<ViewPrikazZivotinja>(db.ViewPrikazZivotinja.OrderBy(z => z.Ime_Vlasnika).ToList());
                        break;
                    case 9:
                        zivotinje = new BindingList<ViewPrikazZivotinja>(db.ViewPrikazZivotinja.OrderBy(z => z.Prezime_Vlasnika).ToList());
                        break;
                    default:
                        zivotinje = new BindingList<ViewPrikazZivotinja>(db.ViewPrikazZivotinja.ToList());
                        break;
                }
            }
            uiPrikazZivotinja.DataSource = zivotinje;
        }

        /// <summary>
        /// Funkcija za sortiranje zivotinja silazno
        /// </summary>
        /// <param name="stupac">Odabrani stupac po kojemu se sortira</param>
        private void SortirajZivotinjeSilazno(int stupac)
        {
            BindingList<ViewPrikazZivotinja> zivotinje;
            using (var db = new MazaEntities())
            {
                switch (stupac)
                {
                    case 1:
                        zivotinje = new BindingList<ViewPrikazZivotinja>(db.ViewPrikazZivotinja.OrderByDescending(z => z.Ime).ToList());
                        break;
                    case 2:
                        zivotinje = new BindingList<ViewPrikazZivotinja>(db.ViewPrikazZivotinja.OrderByDescending(z => z.Spol).ToList());
                        break;
                    case 3:
                        zivotinje = new BindingList<ViewPrikazZivotinja>(db.ViewPrikazZivotinja.OrderByDescending(z => z.Vrsta).ToList());
                        break;
                    case 4:
                        zivotinje = new BindingList<ViewPrikazZivotinja>(db.ViewPrikazZivotinja.OrderByDescending(z => z.Datum_Rođenja).ToList());
                        break;
                    case 5:
                        zivotinje = new BindingList<ViewPrikazZivotinja>(db.ViewPrikazZivotinja.OrderByDescending(z => z.Broj_Čipa).ToList());
                        break;
                    case 6:
                        zivotinje = new BindingList<ViewPrikazZivotinja>(db.ViewPrikazZivotinja.OrderByDescending(z => z.Težina).ToList());
                        break;
                    case 7:
                        zivotinje = new BindingList<ViewPrikazZivotinja>(db.ViewPrikazZivotinja.OrderByDescending(z => z.Datum_Uginuća).ToList());
                        break;
                    case 8:
                        zivotinje = new BindingList<ViewPrikazZivotinja>(db.ViewPrikazZivotinja.OrderByDescending(z => z.Ime_Vlasnika).ToList());
                        break;
                    case 9:
                        zivotinje = new BindingList<ViewPrikazZivotinja>(db.ViewPrikazZivotinja.OrderByDescending(z => z.Prezime_Vlasnika).ToList());
                        break;
                    default:
                        zivotinje = new BindingList<ViewPrikazZivotinja>(db.ViewPrikazZivotinja.ToList());
                        break;
                }
            }
            uiPrikazZivotinja.DataSource = zivotinje;
        }
        #endregion

        #region Događaji

        private void Zivotinje_Load(object sender, EventArgs e)
        {
            PrikaziZivotinje();
        }

        private void uiFiltrirajZivotinje_TextChanged(object sender, EventArgs e)
        {
            Filtriraj(uiFiltrirajZivotinje.Text);
        }

        
        private void uiPrikazZivotinja_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int brojStupaca = e.ColumnIndex;
            if (zadnjiKliknutiStupac != brojStupaca)
            {
                SortirajZivotinjeUzlazno(brojStupaca);
                zadnjiKliknutiStupac = brojStupaca;
            }
            else
            {
                SortirajZivotinjeSilazno(brojStupaca);
                zadnjiKliknutiStupac = 0;
            }

        }


        private void uiActionDodajZivotinju_Click(object sender, EventArgs e)
        {
            if (uiPrikazZivotinja.CurrentRow != null)
            {
                int idZivotinja = int.Parse(uiPrikazZivotinja.CurrentRow.Cells[0].Value.ToString());
                Vlasnik vlasnik;
                using (var db = new MazaEntities())
                {
                    Zivotinja zivotinja = db.Zivotinja.Where(z => z.ID_zivotinja == idZivotinja).FirstOrDefault();
                    vlasnik = db.Vlasnik.Where(v => v.ID_vlasnik == zivotinja.ID_vlasnika).FirstOrDefault();
                }
                frmDodajZivotinju dodajZivotinju = new frmDodajZivotinju(vlasnik);
                dodajZivotinju.ShowDialog();
            }
            PrikaziZivotinje();
        }

        private void uiActionPovijestBolesti_Click(object sender, EventArgs e)
        {
            if (uiPrikazZivotinja.CurrentRow != null)
            {
                int idZivotinja = int.Parse(uiPrikazZivotinja.CurrentRow.Cells[0].Value.ToString());
                Zivotinja oznacenaZivotinja;
                using (var db = new MazaEntities())
                {
                    oznacenaZivotinja = db.Zivotinja.Where(z => z.ID_zivotinja == idZivotinja).FirstOrDefault();
                }

                if (oznacenaZivotinja != null)
                {
                    frmPovijestBolesti povijestBolesti = new frmPovijestBolesti(oznacenaZivotinja);
                    povijestBolesti.ShowDialog();
                }

            }
        }
        #endregion
    }
}
