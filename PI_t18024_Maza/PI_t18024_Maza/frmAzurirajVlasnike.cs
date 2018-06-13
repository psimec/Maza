﻿using System;
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
    public partial class frmAzurirajVlasnike : Form
    {
        Vlasnik vlasnik;
        Vlasnik noviVlasnik;
        public frmAzurirajVlasnike()
        {
            InitializeComponent();
        }
        public frmAzurirajVlasnike(Vlasnik vlasnik)
        {
            this.vlasnik = vlasnik;
            InitializeComponent();
        }

        private void frmAzurirajVlasnike_Load(object sender, EventArgs e)
        {
            if(vlasnik != null)
            {
                uiImeVlasnika.Text = vlasnik.ime;
                uiPrezimeVlasnika.Text = vlasnik.prezime;
                uiAdresa.Text = vlasnik.adresa_stavnovanja;
                uiBrojMobitela.Text = vlasnik.broj_telefona1;
                uiBrojTelefona.Text = vlasnik.broj_telefona2;
                uiEmail.Text = vlasnik.email;
            }
        }

        public void UrediVlasnika()
        {
            using (var db = new MazaEntities())
            {
                if (vlasnik == null)
                {
                    noviVlasnik = new Vlasnik
                    {
                        ime = uiImeVlasnika.Text,
                        prezime = uiPrezimeVlasnika.Text,
                        adresa_stavnovanja = uiAdresa.Text,
                        broj_telefona1 = uiBrojMobitela.Text,
                        broj_telefona2 = uiBrojTelefona.Text,
                        email = uiEmail.Text
                    };
                    db.Vlasnik.Add(noviVlasnik);
                    db.SaveChanges();
                }
                else
                {
                    db.Vlasnik.Attach(vlasnik);
                    vlasnik.ime = uiImeVlasnika.Text;
                    vlasnik.prezime = uiPrezimeVlasnika.Text;
                    vlasnik.adresa_stavnovanja = uiAdresa.Text;
                    vlasnik.broj_telefona1 = uiBrojMobitela.Text;
                    vlasnik.broj_telefona2 = uiBrojTelefona.Text;
                    vlasnik.email = uiEmail.Text;
                    db.SaveChanges();
                }
            }
            this.Close();
        }

        private void uiZavrsi_Click(object sender, EventArgs e)
        {
            UrediVlasnika();
            this.Close();
        }

        private void uiDodijeliZivotinju_Click(object sender, EventArgs e)
        {
            UrediVlasnika();
            if(vlasnik == null)
            {
                frmDodajZivotinju dodajZivotinju = new frmDodajZivotinju(noviVlasnik);
                this.Hide();
                dodajZivotinju.ShowDialog();
                this.Close();
            }
            else
            {
                frmDodajZivotinju dodajZivotinju = new frmDodajZivotinju(vlasnik);
                this.Hide();
                dodajZivotinju.ShowDialog();
                this.Close();
            }
        }
    }
}