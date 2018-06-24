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
    public partial class frmStatistike : frmDizajn
    {
        public frmStatistike()
        {
            InitializeComponent();
        }

        private void uiActionPrikaziGraf_Click(object sender, EventArgs e)
        {
            List<Zivotinja> listaZivotinja = null;
            using (var db = new MazaEntities())
            {
                listaZivotinja = db.Zivotinja.ToList();
            }

            var brojZivotinja = listaZivotinja.GroupBy(n => n.vrsta).Select(group => new
            {
                vrsta = group.Key,
                broj = group.Count()
            });

            foreach (var item in brojZivotinja)
            {
                this.uiGraf.Series["Broj životinja"].Points.AddXY(item.vrsta, item.broj);
            }
        }
    }
}
