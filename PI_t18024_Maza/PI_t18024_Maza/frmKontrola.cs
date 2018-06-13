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
        Kontrola kontrola;

        public frmKontrola()
        {
            InitializeComponent();
            this.kontrola = null;
        }


        private void KontrolaForm_Load(object sender, EventArgs e)
        {
            PrikaziKontrole();
        }

        private void PrikaziKontrole()
        {
            BindingList<viewKontrola> viewKontrola;
            using (var db = new MazaEntities())
            {
                viewKontrola = new BindingList<viewKontrola>(db.viewKontrola.ToList());
            }
            uiPrikazKontrola.DataSource = viewKontrola;
            uiPrikazKontrola.Columns[0].Visible = false;
        }

        private void sortirajKontrole(int stupac)
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
            uiPrikazKontrola.Columns[0].Visible = false;
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

        private void uiPrikazKontrola_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idKontrola = (int)uiPrikazKontrola.CurrentRow.Cells[0].Value;
            using (var db = new MazaEntities())
            {
                kontrola = db.Kontrola.Where(k => k.ID_kontrola == idKontrola).FirstOrDefault();
            }
        }

        private void uiActionDetaljiKontrole_Click(object sender, EventArgs e)
        {
            Form detaljiKontrole = new frmDetaljiKontrole(this.kontrola);
            detaljiKontrole.StartPosition = FormStartPosition.CenterScreen;
            detaljiKontrole.ShowDialog();
        }

        private void uiPrikazKontrola_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int brojStupca = e.ColumnIndex;
            sortirajKontrole(brojStupca);
        }
    }
}
