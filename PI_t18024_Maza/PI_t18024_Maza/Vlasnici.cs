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
        }

        public void PrikaziZivotinje(int id)
        {
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            PrikaziZivotinje(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
        }
    }
}
