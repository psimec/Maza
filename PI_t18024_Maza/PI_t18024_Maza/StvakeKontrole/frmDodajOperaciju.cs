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
    public partial class frmDodajOperaciju : Form
    {
        #region Varijable
        Vlasnik vlasnik;
        Zivotinja zivotinja;
        Kontrola kontrola;
        public Operacija operacija;
        bool status;
        #endregion

        #region Konstruktori

        /// <summary>
        /// Konstruktor forme Dodaj operaciju u slučaju dodavanja nove operacije
        /// </summary>
        /// <param name="vlasnik">Proslijeđeni vlasnik životinje</param>
        /// <param name="zivotinja">Proslijeđena životinja na kontroli</param>
        /// <param name="kontrola">Proslijeđena kontrola</param>
        public frmDodajOperaciju(Vlasnik vlasnik, Zivotinja zivotinja, Kontrola kontrola)
        {
            InitializeComponent();

            this.vlasnik = vlasnik;
            this.zivotinja = zivotinja;
            this.kontrola = kontrola;
        }

        /// <summary>
        /// Konstruktor forme Dodaj operaciju u slučaju pregleda ili ažuriranja postojeće operacije
        /// </summary>
        /// <param name="vlasnik">Proslijeđeni vlasnik životinje</param>
        /// <param name="zivotinja">Proslijeđena životinja na kontroli</param>
        /// <param name="kontrola">Proslijeđena kontrola</param>
        /// <param name="operacija">Proslijeđena postojeća operacija</param>
        /// <param name="status">Proslijeđeni status kontrole</param>
        public frmDodajOperaciju(Vlasnik vlasnik, Zivotinja zivotinja, Kontrola kontrola, Operacija operacija, bool status)
        {
            InitializeComponent();

            this.vlasnik = vlasnik;
            this.zivotinja = zivotinja;
            this.kontrola = kontrola;
            this.operacija = operacija;
            this.status = status;
        }

        #endregion

        #region Funkcije
        /// <summary>
        /// Popunjava osnovne podatke o operaciji
        /// </summary>
        private void PopuniOsnovnePodatke()
        {
            uiVlasnikZivotinje.Text += vlasnik.ime + " " + vlasnik.prezime;
            uiImeZivotinje.Text += zivotinja.ime;
            uiVrstaZivotinje.Text += zivotinja.vrsta;
            uiDatumRodenjaZivotinje.Text += zivotinja.datum_rodenja.ToShortDateString();

            uiDatumZahvataTekst.Text = this.kontrola.datum_kontrole.ToShortDateString();
        }

        /// <summary>
        /// Popunjava preostale podatke o operaciji
        /// </summary>
        private void PopuniPodatkeOOperaciji()
        {
            uiNapomenaUnos.Text = this.operacija.napomena;
            uiVrstaZahvataUnos.Text = this.operacija.vrsta_zahvata;

            TimeSpan vrijeme;
            if (!TimeSpan.TryParse(this.operacija.trajanje_zahtjeva.ToString(), out vrijeme))
            {
                MessageBox.Show("Neispravan format trajanja zahtjeva! Molimo Vas da kontaktirate Administratora.");
                this.Close();
            }
            else
            {
                uiTrajanjeZahvataUnos.Value = uiTrajanjeZahvataUnos.Value + vrijeme;
            }
        }

        /// <summary>
        /// Onemogućuje unos podataka
        /// </summary>
        private void OnemoguciUnos()
        {
            uiNapomenaUnos.ReadOnly = true;
            uiVrstaZahvataUnos.ReadOnly = true;

            uiTrajanjeZahvataUnos.Enabled = false;

            uiActionDodajOperaciju.Hide();
        }

        /// <summary>
        /// Provjerava da li je trenutačno prijavljeni veterinar isti kao i veterinar zadužen za trenutačno aktivnu kontrolu
        /// </summary>
        private void ProvjeriVeterinara()
        {
            if (this.kontrola.ID_veterinar != PrijavljeniVeterinar.Veterinar.ID_veterinar)
            {
                OnemoguciUnos();
            }
        }

        #endregion

        #region Događaji

        /// <summary>
        /// Popunjava podatke za prikaz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDodajOperaciju_Load(object sender, EventArgs e)
        {
            PopuniOsnovnePodatke();

            ProvjeriVeterinara();

            if (!status && this.operacija != null)
            {
                PopuniPodatkeOOperaciji();
                uiActionDodajOperaciju.Text = "Ažuriraj operaciju";
            }
            else if(status)
            {
                PopuniPodatkeOOperaciji();
                uiActionOdustani.Text = "Zatvori";
                OnemoguciUnos();
            }
        }        

        private void uiActionOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }        

        /// <summary>
        /// Dodavanje nove stavke operacije ili ažuriranje postojeće
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiActionDodajOperaciju_Click(object sender, EventArgs e)
        {
            if(uiVrstaZahvataUnos.Text == "")
            {
                MessageBox.Show("Potrebno je unesti vrstu zahvata operacije.");
                return;
            }

            using (var db = new MazaEntities())
            {
                if(this.operacija==null)
                {
                    db.Kontrola.Attach(this.kontrola);                    
                    TimeSpan vrijemeSati = TimeSpan.Parse(uiTrajanjeZahvataUnos.Value.ToLongTimeString());

                    this.operacija = new Operacija
                    {
                        vrsta_zahvata = uiVrstaZahvataUnos.Text,
                        datum_zahvata = DateTime.Parse(uiDatumZahvataTekst.Text),
                        ID_kontrola = this.kontrola.ID_kontrola,
                        napomena = uiNapomenaUnos.Text,
                        trajanje_zahtjeva = vrijemeSati
                    };
                    db.Operacija.Add(this.operacija);

                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    db.Kontrola.Attach(this.kontrola);
                    db.Operacija.Attach(this.operacija);
                    TimeSpan vrijemeSati = TimeSpan.Parse(uiTrajanjeZahvataUnos.Value.ToLongTimeString());

                    this.operacija.vrsta_zahvata = uiVrstaZahvataUnos.Text;
                    this.operacija.datum_zahvata = DateTime.Parse(uiDatumZahvataTekst.Text);
                    this.operacija.ID_kontrola = this.kontrola.ID_kontrola;
                    this.operacija.napomena = uiNapomenaUnos.Text;
                    this.operacija.trajanje_zahtjeva = vrijemeSati;
                }
                db.SaveChanges();
            }
            this.Close();
        }

        #endregion
    }
}
