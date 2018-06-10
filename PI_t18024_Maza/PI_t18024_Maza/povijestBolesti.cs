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
    public partial class povijestBolesti : Dizajn
    {
        public povijestBolesti()
        {
            InitializeComponent();
        }

        private void povijestBolesti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_18024_DBDataSet.bolest' table. You can move, or remove it, as needed.
            this.bolestTableAdapter.FillByZivotinjaId(this._18024_DBDataSet.bolest, 3);
            // TODO: This line of code loads data into the '_18024_DBDataSet.dijagnoza' table. You can move, or remove it, as needed.
            this.dijagnozaTableAdapter.FillByZivotinjaId(this._18024_DBDataSet.dijagnoza, 3);
            // TODO: This line of code loads data into the '_18024_DBDataSet.vlasnik' table. You can move, or remove it, as needed.
            this.vlasnikTableAdapter.FillByZivotinjaId(this._18024_DBDataSet.vlasnik, 3);
            // TODO: This line of code loads data into the '_18024_DBDataSet.zivotinja' table. You can move, or remove it, as needed.
            this.zivotinjaTableAdapter.FillByZivotinjaId(this._18024_DBDataSet.zivotinja, 3);

            this.reportViewer1.RefreshReport();
        }
    }
}
