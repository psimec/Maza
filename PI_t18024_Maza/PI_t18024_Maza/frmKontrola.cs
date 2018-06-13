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

        private void uiPrikazKontrola_SelectionChanged(object sender, EventArgs e)
        {       
            int idKontrola = (int)uiPrikazKontrola.CurrentRow.Cells[0].Value;
            using (var db = new MazaEntities())
            {
                kontrola = db.Kontrola.Where(k => k.ID_kontrola == idKontrola).FirstOrDefault();
            }
        }
    }
}
