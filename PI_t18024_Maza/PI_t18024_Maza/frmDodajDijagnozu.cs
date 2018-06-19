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
    public partial class frmDodajDijagnozu : Form
    {
        Vlasnik vlasnik;
        Zivotinja zivotinja;

        public frmDodajDijagnozu(Vlasnik vlasnik, Zivotinja zivotinja)
        {
            InitializeComponent();

            this.vlasnik = vlasnik;
            this.zivotinja = zivotinja;
        }

        private void frmDodajDijagnozu_Load(object sender, EventArgs e)
        {
            uiVlasnikZivotinje.Text += vlasnik.ime + " " + vlasnik.prezime;
            uiImeZivotinje.Text += zivotinja.ime;
            uiVrstaZivotinje.Text += zivotinja.vrsta;
            uiDatumRodenjaZivotinje.Text += zivotinja.datum_rodenja;
        }

        private void uiActionOdustani_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void uiActionDodajDijagnozu_Click(object sender, EventArgs e)
        {

            // TODO: 
            // Spremi podatke u bazu
            // Promijeni funkcionalnost gumba temeljem moda u kojem je forma

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
