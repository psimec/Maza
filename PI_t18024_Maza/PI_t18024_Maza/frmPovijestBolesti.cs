using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_t18024_Maza
{
    public partial class frmPovijestBolesti : Form
    {
        private Zivotinja zivotinja;

        public frmPovijestBolesti(Zivotinja zivotinja)
        {
            InitializeComponent();
            this.zivotinja = zivotinja;
        }

        private void povijestBolesti_Load(object sender, EventArgs e)
        {
            _18024_DBDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the '_18024_DBDataSet.PovijestBolesti' table. You can move, or remove it, as needed.
            this.PovijestBolestiTableAdapter.FillByZivotinjaID(this._18024_DBDataSet.PovijestBolesti, zivotinja.ID_zivotinja);
            // TODO: This line of code loads data into the '_18024_DBDataSet.vlasnik' table. You can move, or remove it, as needed.
            this.vlasnikTableAdapter.FillByZivotinjaId(this._18024_DBDataSet.vlasnik, zivotinja.ID_zivotinja);
            // TODO: This line of code loads data into the '_18024_DBDataSet.zivotinja' table. You can move, or remove it, as needed.
            this.zivotinjaTableAdapter.FillByZivotinjaId(this._18024_DBDataSet.zivotinja, zivotinja.ID_zivotinja);

            this.reportViewer1.RefreshReport();
        }
    }
}
