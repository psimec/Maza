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
    public partial class frmDodajCijepljenje : Form
    {
        #region Varijable
        Vlasnik vlasnik;
        Zivotinja zivotinja;
        Kontrola kontrola;
        public Cjepivo cjepivo;
        bool status;
        #endregion

        #region Konstruktori
        /// <summary>
        /// Konstruktor forme Dodaj cijepljenje kada se dodaje novo cijepljenje
        /// </summary>
        /// <param name="vlasnik">Proslijeđeni vlasnik životinje</param>
        /// <param name="zivotinja">Proslijeđena životinja na kontroli</param>
        /// <param name="kontrola">Proslijeđena kontrola</param>
        public frmDodajCijepljenje(Vlasnik vlasnik, Zivotinja zivotinja, Kontrola kontrola)
        {
            InitializeComponent();

            this.vlasnik = vlasnik;
            this.zivotinja = zivotinja;
            this.kontrola = kontrola;
            korisnickaPodrska.SetShowHelp(this, true);
            korisnickaPodrska.HelpNamespace = "https://github.com/foivz/r18024/blob/master/Datoteke/Korisnicka_dokumentacija/Korisnicka_dokumentacija.pdf";
        }

        /// <summary>
        /// Konstruktor forme Dodaj cijepljenje kada se vrši pregled cijepljenja ili ažurira postojeće
        /// </summary>
        /// <param name="vlasnik">Proslijeđeni vlasnik životinje</param>
        /// <param name="zivotinja">Proslijeđena životinja na kontroli</param>
        /// <param name="kontrola">Proslijeđena kontrola</param>
        /// <param name="cjepivo">Proslijeđeno postojeće cijepljenje</param>
        /// <param name="status">Proslijeđeni status trenutno aktivne kontrole</param>
        public frmDodajCijepljenje(Vlasnik vlasnik, Zivotinja zivotinja, Kontrola kontrola, Cjepivo cjepivo, bool status)
        {
            InitializeComponent();

            this.vlasnik = vlasnik;
            this.zivotinja = zivotinja;
            this.kontrola = kontrola;
            this.cjepivo = cjepivo;
            this.status = status;
            korisnickaPodrska.SetShowHelp(this, true);
            korisnickaPodrska.HelpNamespace = "https://github.com/foivz/r18024/blob/master/Datoteke/Korisnicka_dokumentacija/Korisnicka_dokumentacija.pdf";
        }
        #endregion

        #region Funkcije
        /// <summary>
        /// Popunjava osnovne podatke o kontroli
        /// </summary>
        private void PopuniOsnovnePodatke()
        {
            uiVlasnikZivotinje.Text += vlasnik.ime + " " + vlasnik.prezime;
            uiImeZivotinje.Text += zivotinja.ime;
            uiVrstaZivotinje.Text += zivotinja.vrsta;
            uiDatumRodenjaZivotinje.Text += zivotinja.datum_rodenja.ToShortDateString();
        }

        /// <summary>
        /// Popunjava combobox sa cjepivima za mogućnost odabira cjepiva
        /// </summary>
        private void PopuniCjepiva()
        {
            using (var db = new MazaEntities())
            {
                uiActionOdaberiCjepivo.DataSource = db.Cjepivo.ToList();
            }

            uiActionOdaberiCjepivo.DisplayMember = "ime";
            uiActionOdaberiCjepivo.ValueMember = "ID_cjepivo";
        }

        /// <summary>
        /// Popunjava polja za prikaz podataka o odabranom cjepivu
        /// </summary>
        /// <param name="cjepivo">Odabrano cjepivo</param>
        private void PopuniPodatkeOCjepivu(Cjepivo cjepivo)
        {
            if (cjepivo != null)
            {
                uiImeCjepivaTekst.Text = cjepivo.ime;
                uiProizvodacTekst.Text = cjepivo.proizvodac;
                uiRokTrajanjaTekst.Text = cjepivo.rok_trajanja.ToShortDateString();
                uiCijenaCjepivaTekst.Text = cjepivo.cijena + " kn";
                uiDozaCjepivaTekst.Text = cjepivo.doza + " mg";
            }
        }

        /// <summary>
        /// Provjera da li je trenutačno prijavljeni veterinar isti kao i veterinar zadužen za trenutno aktivnu kontrolu
        /// </summary>
        private void ProvjeriVeterinara()
        {
            if (this.kontrola.ID_veterinar != PrijavljeniVeterinar.Veterinar.ID_veterinar)
            {
                OnemoguciUnos();
            }
        }

        /// <summary>
        /// Onemogućuje unos novih cjepljenja
        /// </summary>
        private void OnemoguciUnos()
        {
            uiActionOdaberiCjepivo.Enabled = false;

            uiActionDodajCjepivo.Hide();
        }
        #endregion

        #region Događaji
        /// <summary>
        /// Prikazuje podatke temeljem statusa kontrole
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDodajCijepljenje_Load(object sender, EventArgs e)
        {
            PopuniOsnovnePodatke();
            PopuniCjepiva();

            if(this.cjepivo != null)
            {
                uiActionOdaberiCjepivo.SelectedValue = this.cjepivo.ID_cjepivo;
                uiActionDodajCjepivo.Text = "Ažuriraj cjepljenje";
            }

            ProvjeriVeterinara();

            if(status)
            {
                uiActionOdustani.Text = "Zatvori";
                OnemoguciUnos();
            }
        }

        private void uiOdabirCjepiva_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cjepivo cjepivo = uiActionOdaberiCjepivo.SelectedItem as Cjepivo;

            PopuniPodatkeOCjepivu(cjepivo);
        }

        private void uiActionOdustani_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Ovisno o statusu kontrole dodaje novo cjepljenje ili ažurira postojeće
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiActionDodajCjepivo_Click(object sender, EventArgs e)
        {
            using (var db = new MazaEntities())
            {
                if(this.cjepivo==null)
                {
                    Cjepivo cjepivo = uiActionOdaberiCjepivo.SelectedItem as Cjepivo;

                    db.Cjepivo.Attach(cjepivo);
                    db.Kontrola.Attach(this.kontrola);

                    this.kontrola.Cjepivo.Add(cjepivo);
                    cjepivo.Kontrola.Add(this.kontrola);

                    this.cjepivo = cjepivo;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    Cjepivo cjepivo = uiActionOdaberiCjepivo.SelectedItem as Cjepivo;

                    db.Cjepivo.Attach(this.cjepivo);
                    db.Kontrola.Attach(this.kontrola);

                    this.kontrola.Cjepivo.Remove(this.cjepivo);

                    db.Cjepivo.Attach(cjepivo);
                    this.kontrola.Cjepivo.Add(cjepivo);
                }
                db.SaveChanges();
            }
            this.Close();
        }
        #endregion
    }
}
