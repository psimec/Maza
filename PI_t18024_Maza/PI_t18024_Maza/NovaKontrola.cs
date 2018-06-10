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
    public partial class NovaKontrola : Form
    {
        public NovaKontrola()
        {
            InitializeComponent();
        }

        private void NovaKontrola_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_18024_DBDataSet.veterinar' table. You can move, or remove it, as needed.
            this.veterinarTableAdapter.Fill(this._18024_DBDataSet.veterinar);
            // TODO: This line of code loads data into the '_18024_DBDataSet.zivotinja' table. You can move, or remove it, as needed.
            this.zivotinjaTableAdapter.Fill(this._18024_DBDataSet.zivotinja);
        }

        private void uiActionOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
