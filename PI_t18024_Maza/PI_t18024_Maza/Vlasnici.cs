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
            uiTablicaVlasnika.Rows.Add("Marko", "Marić", "Samobor", "0911231233", null, "mmaric@mail.com");
            uiTablicaVlasnika.Rows.Add("Ivan", "Ivić", "Zagreb", "0955511152", null, "iivic@mail.com");
            uiTablicaVlasnika.Rows.Add("Luka", "Marinkov", "Zagreb", "0955422121", null, "lmarinkov@mail.com");
            uiTablicaVlasnika.Rows.Add("Marko", "Štuka", "Zaprešić", "0977875555", null, "mstuka@mail.com");
            uiTablicaVlasnika.Rows.Add("Marija", "Petrić", "Samobor", "0996932252", null, "mpetric@mail.com");
            uiTablicaVlasnika.Rows.Add("Ana", "Anić", "Zagreb", "0922177787", null, "aanic@mail.com");
        }

        private void uiActionPopisZivotinja_Click(object sender, EventArgs e)
        {
            Form popisZivotinja = new PopisZivotinja();
            this.Hide();
            popisZivotinja.ShowDialog();
            this.Close();
        }
    }
}
