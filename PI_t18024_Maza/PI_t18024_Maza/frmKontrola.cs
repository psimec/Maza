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
        private int idKontrola;

        public frmKontrola()
        {
            InitializeComponent();
            this.idKontrola = -1; // ako se na formu normalno dode
        }

        public frmKontrola(int idKontrola)
        {
            InitializeComponent();
            this.idKontrola = idKontrola; // ako se na formu dode preko kalendara
        }

        private void kontrolaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kontrolaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._18024_DBDataSet);

        }

        private void KontrolaForm_Load(object sender, EventArgs e)
        {
            if (idKontrola == -1)
            {
                // TODO: This line of code loads data into the '_18024_DBDataSet.kontrola' table. You can move, or remove it, as needed.
                this.kontrolaTableAdapter.Fill(this._18024_DBDataSet.kontrola);
            }
            else // preko kalendara
            {
                _18024_DBDataSet.EnforceConstraints = false;
                this.kontrolaTableAdapter.FillByKontrolaId(this._18024_DBDataSet.kontrola, idKontrola);
            }


        }
    }
}
