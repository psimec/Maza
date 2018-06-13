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
            uiPrikazZivotinja.DataSource = listaZivotinja;

            uiPrikazZivotinja.Columns[0].Visible = false;

            
        }
               
        private void Zivotinje_Load(object sender, EventArgs e)
        {
            PrikaziZivotinje();
            foreach (DataGridViewColumn item in uiPrikazZivotinja.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.Automatic;
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
    }
}
