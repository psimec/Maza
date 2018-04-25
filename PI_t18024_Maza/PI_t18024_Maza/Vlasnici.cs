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
    public partial class Vlasnici : Form
    {
        public Vlasnici()
        {
            InitializeComponent();
            dataGridView1.Rows.Add("Marko", "Marić", "Samobor", "0911231233", null, "mmaric@mail.com");
            dataGridView1.Rows.Add("Ivan", "Ivić", "Zagreb", "0955511152", null, "iivic@mail.com");
            dataGridView1.Rows.Add("Luka", "Marinkov", "Zagreb", "0955422121", null, "lmarinkov@mail.com");
            dataGridView1.Rows.Add("Marko", "Štuka", "Zaprešić", "0977875555", null, "mstuka@mail.com");
            dataGridView1.Rows.Add("Marija", "Petrić", "Samobor", "0996932252", null, "mpetric@mail.com");
            dataGridView1.Rows.Add("Ana", "Anić", "Zagreb", "0922177787", null, "aanic@mail.com");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form popisZivotinja = new PopisZivotinja();
            this.Hide();
            popisZivotinja.ShowDialog();
            this.Close();
        }
    }
}
