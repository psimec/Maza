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
        #region Globalne varijable
        Vlasnik vlasnik;
        Vlasnik noviVlasnik;
        #endregion

        #region Konstruktori forme frmAzurirajVlasnike
        /// <summary>
        /// Kontruktor klase za dodavanje novog vlasnika
        /// </summary>
        public frmAzurirajVlasnike()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Konstruktor klase za ažuriranje vlasnika
        /// </summary>
        /// <param name="vlasnik">Odabrani vlasnik za ažuriranje</param>
        public frmAzurirajVlasnike(Vlasnik vlasnik)
        {
            this.vlasnik = vlasnik;
            InitializeComponent();
        }
        #endregion

        #region Funkcije
        /// <summary>
        /// Ažurira postojećeg, odnosno dodaje novog vlasnika u bazu podataka
        /// </summary>
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
        /// <summary>
        /// Validacija unešenih podataka o vlasniku
        /// </summary>
        /// <param name="ime">Ime vlasnika</param>
        /// <param name="prezime">Prezime vlasnika</param>
        /// <param name="adresa">Adresa stanovanja vlasnika</param>
        /// <returns>Ukoliko su unešeni podaci ispravni vraća True, u suprotnom vraća False</returns>
        public bool ValidacijaVlasnika(string ime, string prezime, string adresa)
        {
            if (!(int.TryParse(ime, out int Ime) || int.TryParse(prezime, out int Prezime) || int.TryParse(adresa, out int Adresa)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region Događaji

        private void frmAzurirajVlasnike_Load(object sender, EventArgs e)
        {
            if (vlasnik != null)
            {
                uiImeVlasnika.Text = vlasnik.ime;
                uiPrezimeVlasnika.Text = vlasnik.prezime;
                uiAdresa.Text = vlasnik.adresa_stavnovanja;
                uiBrojMobitela.Text = vlasnik.broj_telefona1;
                uiBrojTelefona.Text = vlasnik.broj_telefona2;
                uiEmail.Text = vlasnik.email;
            }
        }

        private void uiZavrsi_Click(object sender, EventArgs e)
        {
            if (ValidacijaVlasnika(uiImeVlasnika.Text, uiPrezimeVlasnika.Text, uiAdresa.Text))
            {
                UrediVlasnika();
            }
            else
            {
                MessageBox.Show("Podaci nisu ispravni.");
            }
            this.Close();
        }

        private void uiDodijeliZivotinju_Click(object sender, EventArgs e)
        {
            UrediVlasnika();
            if (vlasnik == null)
            {
                frmDodajZivotinju dodajZivotinju = new frmDodajZivotinju(noviVlasnik);
                dodajZivotinju.ShowDialog();
            }
            else
            {
                frmDodajZivotinju dodajZivotinju = new frmDodajZivotinju(vlasnik);
                dodajZivotinju.ShowDialog();
            }
        }
        #endregion

    }
}
