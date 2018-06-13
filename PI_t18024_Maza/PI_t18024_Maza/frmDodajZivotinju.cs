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
    public partial class frmDodajZivotinju : Form
    {
        Vlasnik vlasnik;
        public frmDodajZivotinju(Vlasnik vlasnik)
        {
            this.vlasnik = vlasnik;
            InitializeComponent();
            uiOdabirSpola.Items.Add("m");
            uiOdabirSpola.Items.Add("ž");
        }

        private void DodajZivotinjuForm_Load(object sender, EventArgs e)
        {
            uiImeVlasnika.Text = vlasnik.ime;
            uiPrezimeVlasnika.Text = vlasnik.prezime;
            uiAdresa.Text = vlasnik.adresa_stavnovanja;
            uiBrojMobitela.Text = vlasnik.broj_telefona1;
            uiBrojTelefona.Text = vlasnik.broj_telefona2;
            uiEmail.Text = vlasnik.email;
        }

        private void uiVrsta_TextChanged(object sender, EventArgs e)
        {
            if(uiVrsta.Text == "Pas" || uiVrsta.Text == "pas")
            {
                lblBrojCipa.Visible = true;
                uiBrojCipa.Visible = true;
            }
            else
            {
                lblBrojCipa.Visible = false;
                uiBrojCipa.Visible = false;
            }
        }
    }
}
