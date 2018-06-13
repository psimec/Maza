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

        private void button1_Click(object sender, EventArgs e)
        {
            if(uiVrsta.Text == "pas" ||uiVrsta.Text == "Pas")
            {
                using (var db = new MazaEntities())
                {
                    db.Vlasnik.Attach(vlasnik);

                    Zivotinja novaZivotinja = new Zivotinja()
                    {
                        ime = uiIme.Text,
                        spol = uiOdabirSpola.Text,
                        vrsta = uiVrsta.Text,
                        datum_rodenja = uiDatumRodenja.Value,
                        broj_cipa = int.Parse(uiBrojCipa.Text),
                        tezina = int.Parse(uiTezina.Text),
                        ID_vlasnika = vlasnik.ID_vlasnik,
                        Vlasnik = vlasnik
                    };
                    db.Zivotinja.Add(novaZivotinja);
                    db.SaveChanges();
                }
            }
            else
            {
                using (var db = new MazaEntities())
                {
                    db.Vlasnik.Attach(vlasnik);

                    Zivotinja novaZivotinja = new Zivotinja()
                    {
                        ime = uiIme.Text,
                        spol = uiOdabirSpola.Text,
                        vrsta = uiVrsta.Text,
                        datum_rodenja = uiDatumRodenja.Value,
                        tezina = int.Parse(uiTezina.Text),
                        ID_vlasnika = vlasnik.ID_vlasnik,
                        Vlasnik = vlasnik
                    };
                    db.Zivotinja.Add(novaZivotinja);
                    db.SaveChanges();
                }
            }
            this.Close();
        }
    }
}
