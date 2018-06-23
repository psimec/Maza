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
        #region Globalne varijable
        Vlasnik vlasnik;
        Zivotinja zivotinja;
        #endregion

        #region Konstruktor forme frmDodajZivotinju
        /// <summary>
        /// Kontruktor klase za dodavanje nove životinje odabranom vlasniku
        /// </summary>
        /// <param name="vlasnik">Odabrani vlasnik kojemu se dodaje nova životinja</param>
        public frmDodajZivotinju(Vlasnik vlasnik)
        {
            this.vlasnik = vlasnik;
            InitializeComponent();
        }

        /// <summary>
        /// Konstruktor klase ukoliko se žele ažurirati podaci o životinji
        /// </summary>
        /// <param name="vlasnik">Odabrani vasnik životinje</param>
        /// <param name="zivotinja">Odabrana životinja</param>
        public frmDodajZivotinju(Vlasnik vlasnik, Zivotinja zivotinja)
        {
            this.vlasnik = vlasnik;
            this.zivotinja = zivotinja;
            InitializeComponent();
        }
        #endregion

        #region Funkcije
        /// <summary>
        /// Funkcija za prikaz, odnosno sakrivanje labele uiLblDatumUginuca i datetimepicker uiDatumUginuca
        /// </summary>
        private void PrikaziDatumUginuca()
        {
            if(uiZiv.Checked == true)
            {
                uiLblDatumUginuca.Visible = false;
                uiDatumUginuca.Visible = false;
            }
            else
            {
                uiLblDatumUginuca.Visible = true;
                uiDatumUginuca.Visible = true;
            }
        }
        /// <summary>
        /// Validacija unešenih podataka o zivotinji
        /// </summary>
        /// <returns>True ukoliko su unešeni podaci ispravni, u suprotnome Flase</returns>
        public bool Provjera()
        {
            if (!(int.TryParse(uiIme.Text, out int ime) && int.TryParse(uiVrsta.Text, out int vrsta)) && int.TryParse(uiBrojCipa.Text, out int brCipa))
            {
                return true;
            }
            else return false;
        }
        #endregion

        #region Događaji


        private void DodajZivotinjuForm_Load(object sender, EventArgs e)
        {
            uiImeVlasnika.Text = vlasnik.ime;
            uiPrezimeVlasnika.Text = vlasnik.prezime;
            uiAdresa.Text = vlasnik.adresa_stavnovanja;
            uiBrojMobitela.Text = vlasnik.broj_telefona1;
            uiBrojTelefona.Text = vlasnik.broj_telefona2;
            uiEmail.Text = vlasnik.email;
            uiMusko.Checked = true;

           
            //Provjerava se da li je životinja prenesena konstruktorom, ukoliko je podaci o njoj se prosljeđuju u za njih
            // predviđene kontrole i priprema se za ažuriranje označene životinje, u suprotnom se priprema za unos nove životinje
            if (zivotinja != null)
            {
                if(zivotinja.datum_uginuca != null)
                {
                    uiZiv.Checked = false;
                    uiDatumUginuca.Text = zivotinja.datum_uginuca.ToString();
                }
                else
                {
                    uiZiv.Checked = true;
                }
                uiIme.Text = zivotinja.ime;
                uiVrsta.Text = zivotinja.vrsta;

                if(zivotinja.vrsta == "pas" || zivotinja.vrsta == "Pas")
                {
                    uiBrojCipa.Text = zivotinja.broj_cipa.ToString();
                }

                if(zivotinja.spol == "m")
                {
                    uiMusko.Checked = true;
                }
                else
                {
                    uiZensko.Checked = true;
                }
                uiTezina.Text = zivotinja.tezina.ToString();
                uiDatumRodenja.Text = zivotinja.datum_rodenja.ToString();
                if (uiZiv.Checked == false)
                {
                    uiDatumUginuca.Visible = true;
                    uiLblDatumUginuca.Visible = true;
                }
            }
            else
            {
                uiZiv.Checked = true;
            }
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

        //Ažuriranje postojeće, odnosno dodavanje nove životinje
        private void uiZavrsi_Click(object sender, EventArgs e)
        {
            if(zivotinja == null)
            {
                if (Provjera())
                {
                    string spol = "";
                    if (uiMusko.Checked == true)
                    {
                        spol = "m";
                    }
                    else
                    {
                        spol = "ž";
                    }
                    //Ako je životinja vrste pas onda se prikazuje textbox za unos broja cipa
                    if (uiVrsta.Text == "pas" || uiVrsta.Text == "Pas")
                    {
                        using (var db = new MazaEntities())
                        {
                            db.Vlasnik.Attach(vlasnik);

                            Zivotinja novaZivotinja = new Zivotinja()
                            {
                                ime = uiIme.Text,
                                spol = spol,
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
                                spol = spol,
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
            else
            {
                using (var db = new MazaEntities())
                {
                    if (Provjera())
                    {
                        db.Zivotinja.Attach(zivotinja);
                        zivotinja.ime = uiIme.Text;
                        zivotinja.tezina = int.Parse(uiTezina.Text);
                        if (uiMusko.Checked == true)
                        {
                            zivotinja.spol = "m";
                        }
                        else
                        {
                            zivotinja.spol = "ž";
                        }
                        zivotinja.vrsta = uiVrsta.Text;
                        if (uiVrsta.Text == "pas" || uiVrsta.Text == "Pas")
                        {
                            zivotinja.broj_cipa = int.Parse(uiBrojCipa.Text);
                        }
                        zivotinja.datum_rodenja = DateTime.Parse(uiDatumRodenja.Text);
                        if(uiZiv.Checked == false)
                        {
                            zivotinja.datum_uginuca = DateTime.Parse(uiDatumUginuca.Text);
                        }
                        db.SaveChanges();
                        this.Close();
                    }                   
                    else
                    {
                        MessageBox.Show("Unešeni podaci nisu u dobrom formatu!");
                    }
                }               
            }
        }

        private void uiZiv_CheckedChanged(object sender, EventArgs e)
        {
            PrikaziDatumUginuca();
        }
    }
    #endregion
}
