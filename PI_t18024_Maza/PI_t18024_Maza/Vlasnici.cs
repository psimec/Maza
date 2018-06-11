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
    public partial class Vlasnici : Dizajn
    {
        public Vlasnici()
        {
            InitializeComponent();
        }

        private void Vlasnici_Load(object sender, EventArgs e)
        {
            //TODO: This line of code loads data into the '_18024_DBDataSet.vlasnik' table.You can move, or remove it, as needed.
            this.vlasnikTableAdapter.Fill(this._18024_DBDataSet.vlasnik);

        }

        public void PrikaziZivotinje(int id)
        {
            // TODO: This line of code loads data into the '_18024_DBDataSet.zivotinja' table. You can move, or remove it, as needed.
            this.zivotinjaTableAdapter.FillByVlasnikId(this._18024_DBDataSet.zivotinja,id);

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            PrikaziZivotinje(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
        }
    }
}
