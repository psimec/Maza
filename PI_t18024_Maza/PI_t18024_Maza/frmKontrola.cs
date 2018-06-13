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
        public frmKontrola()
        {
            InitializeComponent();
        }


        private void KontrolaForm_Load(object sender, EventArgs e)
        {
            BindingList<viewKontrola> viewKontrola;
            using (var db = new MazaEntities())
            {
                viewKontrola = new BindingList<viewKontrola>(db.viewKontrola.ToList());
            }
            uiPrikazKontrola.DataSource = viewKontrola;
        }

        private void uiActonDodajKontrolu_Click(object sender, EventArgs e)
        {
            Form kreirajKontrolu = new frmNovaKontrola();
            kreirajKontrolu.StartPosition = FormStartPosition.CenterScreen;
            kreirajKontrolu.ShowDialog();
        }
    }
}
