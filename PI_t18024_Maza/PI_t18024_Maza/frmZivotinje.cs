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
        public frmZivotinje()
        {
            InitializeComponent();
        }

        public void PrikaziZivotinje()
        {
            BindingList<ViewPrikazZivotinja> listaZivotinja = null;
            using (var db = new MazaEntities())
            {
                listaZivotinja = new BindingList<ViewPrikazZivotinja>(db.ViewPrikazZivotinja.ToList());
            }
            dataGridView1.DataSource = listaZivotinja;

            dataGridView1.Columns[0].Visible = false;
        }
               
        private void Zivotinje_Load(object sender, EventArgs e)
        {
            PrikaziZivotinje();
        }

        private void uiActionDodajZivotinju_Click(object sender, EventArgs e)
        {
            frmDodajZivotinju dodaj = new frmDodajZivotinju();

        }
    }
}
