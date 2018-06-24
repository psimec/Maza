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
    public partial class frmKontrola : frmDizajn
    {
        #region Globalne varijable

        Kontrola kontrola;
        int zadnjiKliknutiStupac;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Konstruktor forme Kontrola
        /// </summary>

        public frmKontrola()
        {
            InitializeComponent();          
            this.zadnjiKliknutiStupac = 0;
            uiPrikazKontrola.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
            this.kontrola = null;
        }

        #endregion

        #region Sortiranje

        /// <summary>
        /// Sortiranje tablice uzlazno temeljem odabranog stupca
        /// </summary>
        /// <param name="stupac"> Odabrani stupac </param>

        private void sortirajKontroleUzlazno(int stupac)
        {
            BindingList<viewKontrola> viewKontrola;
            using (var db = new MazaEntities())
            {
                switch (stupac)
                {
                    case 1:
                        viewKontrola = new BindingList<viewKontrola>(db.viewKontrola.OrderBy(k => k.zivotinja).ToList());
                        break;
                    case 2:
                        viewKontrola = new BindingList<viewKontrola>(db.viewKontrola.OrderBy(k => k.veterinar).ToList());
                        break;
                    case 3:
                        viewKontrola = new BindingList<viewKontrola>(db.viewKontrola.OrderBy(k => k.opis).ToList());
                        break;
                    case 4:
                        viewKontrola = new BindingList<viewKontrola>(db.viewKontrola.OrderBy(k => k.status).ToList());
                        break;
                    case 5:
                        viewKontrola = new BindingList<viewKontrola>(db.viewKontrola.OrderBy(k => k.datum_kontrole).ToList());
                        break;
                    default:
                        viewKontrola = new BindingList<viewKontrola>(db.viewKontrola.ToList());
                        break;
                }               
            }

            uiPrikazKontrola.DataSource = viewKontrola;
        }

        /// <summary>
        /// Sortiranje tablice silazno temeljem odabranog stupca
        /// </summary>
        /// <param name="stupac"> Odabrani stupac </param>

        private void sortirajKontroleSilazno(int stupac)
        {
            BindingList<viewKontrola> viewKontrola;
            using (var db = new MazaEntities())
            {
                switch (stupac)
                {
                    case 1:
                        viewKontrola = new BindingList<viewKontrola>(db.viewKontrola.OrderByDescending(k => k.zivotinja).ToList());
                        break;
                    case 2:
                        viewKontrola = new BindingList<viewKontrola>(db.viewKontrola.OrderByDescending(k => k.veterinar).ToList());
                        break;
                    case 3:
                        viewKontrola = new BindingList<viewKontrola>(db.viewKontrola.OrderByDescending(k => k.opis).ToList());
                        break;
                    case 4:
                        viewKontrola = new BindingList<viewKontrola>(db.viewKontrola.OrderByDescending(k => k.status).ToList());
                        break;
                    case 5:
                        viewKontrola = new BindingList<viewKontrola>(db.viewKontrola.OrderByDescending(k => k.datum_kontrole).ToList());
                        break;
                    default:
                        viewKontrola = new BindingList<viewKontrola>(db.viewKontrola.ToList());
                        break;
                }
            }

            uiPrikazKontrola.DataSource = viewKontrola;
        }

        #endregion

        #region Filtriranje

        /// <summary>
        /// Filtrira tablicu temeljem upisanog pojma
        /// </summary>
        /// <param name="pojam"> Upisani pojam </param>

        private void filtriraj(string pojam)
        {     
            BindingList<viewKontrola> viewKontrola;
            using (var db = new MazaEntities())
            {
                if (DateTime.TryParse(pojam, out DateTime datum))
                {
                    viewKontrola = new BindingList<viewKontrola>(db.viewKontrola.Where
                    (
                        k => (k.datum_kontrole.Year == datum.Year || k.datum_kontrole.Month == datum.Month || k.datum_kontrole.Day == datum.Day)
                    ).ToList());
                }
                else
                {
                    viewKontrola = new BindingList<viewKontrola>(db.viewKontrola.Where
                    (
                        k => (k.zivotinja.Contains(pojam) || k.veterinar.Contains(pojam) || k.opis.Contains(pojam) ||
                             k.status.Contains(pojam))
                    ).ToList());
                }

            }
            uiPrikazKontrola.DataSource = viewKontrola;
        }

        #endregion

        #region Funkcije

        /// <summary>
        /// Prikaz kontrola iz baze podataka
        /// </summary>

        private void PrikaziKontrole()
        {
            BindingList<viewKontrola> viewKontrola;
            using (var db = new MazaEntities())
            {
                viewKontrola = new BindingList<viewKontrola>(db.viewKontrola.ToList());
            }
            uiPrikazKontrola.DataSource = viewKontrola;
        }

        #endregion

        #region Dogadaji

        private void KontrolaForm_Load(object sender, EventArgs e)
        {
            PrikaziKontrole();
            uiPrikazKontrola.Rows[0].Selected = true;
        }

        private void uiActonDodajKontrolu_Click(object sender, EventArgs e)
        {
            Form kreirajKontrolu = new frmNovaKontrola();
            kreirajKontrolu.StartPosition = FormStartPosition.CenterScreen;
            kreirajKontrolu.ShowDialog();
            PrikaziKontrole();
        }

        private void uiActionAzurirajKontrolu_Click(object sender, EventArgs e)
        {
            Form kreirajKontrolu = new frmNovaKontrola(this.kontrola);
            kreirajKontrolu.StartPosition = FormStartPosition.CenterScreen;
            kreirajKontrolu.ShowDialog();
            PrikaziKontrole();
        }

        private void uiActionDetaljiKontrole_Click(object sender, EventArgs e)
        {
            if(this.kontrola != null)
            {
                Form detaljiKontrole = new frmDetaljiKontrole(this.kontrola);
                detaljiKontrole.StartPosition = FormStartPosition.CenterScreen;
                this.Hide();
                detaljiKontrole.ShowDialog();
                this.Show();
            }
        }

        /// <summary>
        /// Odabirom stupca poziva se funkcija za sortiranje istog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void uiPrikazKontrola_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int brojStupca = e.ColumnIndex;
            if (zadnjiKliknutiStupac != brojStupca)
            {
                sortirajKontroleUzlazno(brojStupca);
                zadnjiKliknutiStupac = brojStupca;
            }
            else
            {
                sortirajKontroleSilazno(brojStupca);
                zadnjiKliknutiStupac = 0;
            }         
        }

        private void uiPretrazi_TextChanged(object sender, EventArgs e)
        {
            filtriraj(uiPretrazi.Text);
        }

        private void uiPrikazKontrola_SelectionChanged(object sender, EventArgs e)
        {
            int idKontrola = (int)uiPrikazKontrola.CurrentRow.Cells[0].Value;
            using (var db = new MazaEntities())
            {
                kontrola = db.Kontrola.Where(k => k.ID_kontrola == idKontrola).FirstOrDefault();
            }
        }

        #endregion
    }
}
