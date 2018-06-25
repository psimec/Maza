using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_t18024_Maza
{
    public partial class frmDodajDijagnozu : Form
    {
        #region Varijable
        Vlasnik vlasnik;
        Zivotinja zivotinja;
        Kontrola kontrola;
        public Dijagnoza dijagnoza;
        bool status;

        List<string> listaNapomenaZaLijekove;

        #endregion

        #region Konstruktori
        /// <summary>
        /// Konstruktor forme Dodaj dijagnozu u slučaju dodavanje nove dijagnoze
        /// </summary>
        /// <param name="vlasnik">Proslijeđeni vlasnik životinje</param>
        /// <param name="zivotinja">Proslijeđena životinja na kontroli</param>
        /// <param name="kontrola">Proslijeđena kontrola</param>
        public frmDodajDijagnozu(Vlasnik vlasnik, Zivotinja zivotinja, Kontrola kontrola)
        {
            InitializeComponent();

            this.vlasnik = vlasnik;
            this.zivotinja = zivotinja;
            this.kontrola = kontrola;
            this.listaNapomenaZaLijekove = new List<string>();
        }

        /// <summary>
        /// Konstruktor forme Dodaj dijagnozu u slučaju pregleda ili ažuriranja postojeće dijagnoze
        /// </summary>
        /// <param name="vlasnik">Proslijeđeni vlasnik životinje</param>
        /// <param name="zivotinja">Proslijeđena životinja na kontroli</param>
        /// <param name="kontrola">Proslijeđena kontrola</param>
        /// <param name="dijagnoza">Postojeća dijagnoza</param>
        /// <param name="status">Status kontrole</param>
        public frmDodajDijagnozu(Vlasnik vlasnik, Zivotinja zivotinja, Kontrola kontrola, Dijagnoza dijagnoza, bool status)
        {
            InitializeComponent();

            this.vlasnik = vlasnik;
            this.zivotinja = zivotinja;
            this.kontrola = kontrola;
            this.dijagnoza = dijagnoza;
            this.status = status;
            this.listaNapomenaZaLijekove = new List<string>();
            CheckForIllegalCrossThreadCalls = false;
        }
        #endregion

        #region Funkcije
        /// <summary>
        /// Popunjava osnovne podatke o dijagnozi
        /// </summary>
        private void PopuniOsnovnePodatke()
        {
            uiVlasnikZivotinje.Text += vlasnik.ime + " " + vlasnik.prezime;
            uiImeZivotinje.Text += zivotinja.ime;
            uiVrstaZivotinje.Text += zivotinja.vrsta;
            uiDatumRodenjaZivotinje.Text += zivotinja.datum_rodenja.ToShortDateString();
        }

        /// <summary>
        /// Popunjava preostale podatke o dijagnozi
        /// </summary>
        private void PopuniPodatkeODijagnozi()
        {
            uiNapomena.Text = dijagnoza.napomena;
            uiTerapija.Text = dijagnoza.terapija;
            uiSimptomi.Text = dijagnoza.simptomi;

            List<PropisaniLijek> propisaniLijekovi = null;
            using (var db = new MazaEntities())
            {
                propisaniLijekovi = db.PropisaniLijek.Where(s => s.ID_dijagnoza == dijagnoza.ID_dijagnoza).ToList();

                foreach (var lijek in db.PropisaniLijek)
                {
                    if (lijek.ID_dijagnoza == dijagnoza.ID_dijagnoza)
                    {
                        uiPropisaniLijekovi.Items.Add(db.Lijek.Where(s => s.ID_lijek == lijek.ID_lijek).FirstOrDefault());
                    }
                }

                Bolest bolest = null;
                bolest = db.Bolest.Where(s => s.ID_bolest == dijagnoza.ID_bolest).FirstOrDefault();
                uiActionOdaberiBolest.SelectedValue = bolest.ID_bolest;
            }
            foreach (PropisaniLijek propisaniLijek in propisaniLijekovi)
            {
                listaNapomenaZaLijekove.Add(propisaniLijek.napomena);
            }
        }

        /// <summary>
        /// Popunjava combobox za odabir lijeka sa svim postojećim lijekovima
        /// </summary>
        private void PopuniLijekove()
        {
            using (var db = new MazaEntities())
            {
                uiActionOdaberiLijek.DataSource = db.Lijek.ToList();
            }
        }

        /// <summary>
        /// Popunjava combobox za odabir bolesti sa svim postojećim bolestima
        /// </summary>
        private void PopuniBolesti()
        {
            using (var db = new MazaEntities())
            {
                uiActionOdaberiBolest.DataSource = db.Bolest.ToList();
            }
        }

        /// <summary>
        /// Dodaje odabrane lijekove u bazu podataka
        /// </summary>
        public void DodajLijekove()
        {
            using (var db = new MazaEntities())
            {
                Bolest bolest = uiActionOdaberiBolest.SelectedItem as Bolest;

                db.Bolest.Attach(bolest);
                db.Kontrola.Attach(this.kontrola);
                db.Dijagnoza.Attach(this.dijagnoza);

                //Ažuriranje
                //Dohvaća stari popis lijekova
                List<Lijek> listaLijekova = new List<Lijek>();
                foreach (var propisaniLijek in db.PropisaniLijek)
                {
                    Lijek lijek = null;
                    lijek = db.Lijek.Where(s => s.ID_lijek == propisaniLijek.ID_lijek && propisaniLijek.ID_dijagnoza == this.dijagnoza.ID_dijagnoza).FirstOrDefault();

                    if (lijek != null)
                    {
                        listaLijekova.Add(lijek);
                    }
                }

                //Provjerava da li se koji novi lijek podudara sa starim lijekovima 
                foreach (Lijek lijekIzListe in listaLijekova)
                {
                    bool pronadjen = false;
                    PropisaniLijek propisaniLijek = null;
                    for (int i = 0; i < uiPropisaniLijekovi.Items.Count; i++)
                    {
                        Lijek lijek = uiPropisaniLijekovi.Items[i] as Lijek;
                        if (lijekIzListe.ID_lijek == lijek.ID_lijek)
                        {
                            propisaniLijek = db.PropisaniLijek.Where(s => s.ID_lijek == lijek.ID_lijek && s.ID_dijagnoza == this.dijagnoza.ID_dijagnoza).FirstOrDefault();
                            db.PropisaniLijek.Attach(propisaniLijek);
                            propisaniLijek.napomena = listaNapomenaZaLijekove[i];
                            //Pamti da je ažurirana napomena za pronađeni lijek
                            listaNapomenaZaLijekove[i] = "#343";
                            pronadjen = true;
                        }
                    }

                    //Ako lijek nije pronađen onda ga makni iz baze
                    if (!pronadjen)
                    {
                        propisaniLijek = db.PropisaniLijek.Where(s => s.ID_lijek == lijekIzListe.ID_lijek && s.ID_dijagnoza == this.dijagnoza.ID_dijagnoza).FirstOrDefault();
                        db.PropisaniLijek.Attach(propisaniLijek);
                        db.PropisaniLijek.Remove(propisaniLijek);
                    }
                }

                //Dodavanje novih lijekova
                for (int i = 0; i < uiPropisaniLijekovi.Items.Count; i++)
                {
                    Lijek lijek = uiPropisaniLijekovi.Items[i] as Lijek;
                    //Dodaj samo one lijekove koji nisu bili ažurirani
                    if (listaNapomenaZaLijekove[i] != "#343")
                    {
                        PropisaniLijek propisaniLijek = new PropisaniLijek
                        {
                            ID_dijagnoza = this.dijagnoza.ID_dijagnoza,
                            ID_lijek = lijek.ID_lijek,
                            napomena = listaNapomenaZaLijekove[i]
                        };

                        db.PropisaniLijek.Add(propisaniLijek);
                    }
                }
                db.SaveChanges();
            }
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

        /// <summary>
        /// Onemogućuje unos novih podataka
        /// </summary>
        private void OnemoguciUnos()
        {
            uiNapomena.ReadOnly = true;
            uiTerapija.ReadOnly = true;
            uiNapomenaLijekUnos.ReadOnly = true;
            uiSimptomi.ReadOnly = true;

            uiActionOdaberiLijek.Enabled = false;
            uiActionOdaberiBolest.Enabled = false;

            uiActionDodajDijagnozu.Hide();
            uiActionObrisiLijek.Hide();
            uiActionDodajLijek.Hide();
        }
        #endregion

        #region Događaji
        /// <summary>
        /// Popunjava podatke o kontroli i dijagnozi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDodajDijagnozu_Load(object sender, EventArgs e)
        {
            PopuniOsnovnePodatke();

            uiPropisaniLijekovi.DisplayMember = "naziv";
            uiPropisaniLijekovi.ValueMember = "ID_lijek";

            PopuniLijekove();
            PopuniBolesti();
            ProvjeriVeterinara();
            if(!status && this.dijagnoza!=null)
            {
                PopuniPodatkeODijagnozi();
                uiActionDodajDijagnozu.Text = "Ažuriraj dijagnozu";
            }
            else if(status)
            {
                PopuniPodatkeODijagnozi();
                uiActionOdustani.Text = "Zatvori";
                OnemoguciUnos();
            }
        }

        private void uiActionOdustani_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Pohranjuje novu dijagnozu ili ažurira postojeću
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiActionDodajDijagnozu_Click(object sender, EventArgs e)
        {
            if(uiSimptomi.Text == "")
            {
                MessageBox.Show("Potrebno je unesti simptome dijagnoze.");
                return;
            }

            if(uiTerapija.Text=="")
            {
                MessageBox.Show("Potrebno je unesti terapiju za dijagnozu.");
                return;
            }

            //Nova dijagnoza
            if (this.dijagnoza == null)
            {
                using (var db = new MazaEntities())
                {
                    Bolest bolest = uiActionOdaberiBolest.SelectedItem as Bolest;

                    db.Bolest.Attach(bolest);
                    db.Kontrola.Attach(this.kontrola);

                    dijagnoza = new Dijagnoza
                    {
                        simptomi = uiSimptomi.Text,
                        terapija = uiTerapija.Text,
                        napomena = uiNapomena.Text,
                        ID_kontrola = this.kontrola.ID_kontrola,
                        ID_bolest = bolest.ID_bolest
                    };
                    db.Dijagnoza.Add(dijagnoza);

                    int idDijagnoza = dijagnoza.ID_dijagnoza;
                    for (int i = 0; i < uiPropisaniLijekovi.Items.Count; i++)
                    {
                        Lijek lijek = uiPropisaniLijekovi.Items[i] as Lijek;
                        db.Lijek.Attach(lijek);

                        PropisaniLijek propisaniLijek = new PropisaniLijek
                        {
                            ID_dijagnoza = idDijagnoza,
                            ID_lijek = lijek.ID_lijek,
                            napomena = listaNapomenaZaLijekove[i]
                        };

                        db.PropisaniLijek.Add(propisaniLijek);
                    }
                    db.SaveChanges();
                }
                this.DialogResult = DialogResult.OK;

            }
            else
            {
                //Ažuriraj postojeću dijagnozu
                using (var db = new MazaEntities())
                {
                    Bolest bolest = uiActionOdaberiBolest.SelectedItem as Bolest;
                    db.Dijagnoza.Attach(this.dijagnoza);

                    this.dijagnoza.simptomi = uiSimptomi.Text;
                    this.dijagnoza.terapija = uiTerapija.Text;
                    this.dijagnoza.napomena = uiNapomena.Text;
                    this.dijagnoza.ID_kontrola = this.kontrola.ID_kontrola;
                    this.dijagnoza.ID_bolest = bolest.ID_bolest;

                    db.SaveChanges();
                }
                Thread dretvaZaAzuriranje = new Thread(new ThreadStart(DodajLijekove));
                dretvaZaAzuriranje.Start();
            }
            this.Close();
        }

        /// <summary>
        /// Dodaje novi lijek u listu propisanih lijekova ukoliko je napomena ispunjena
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiActionDodajLijek_Click(object sender, EventArgs e)
        {

            if(uiNapomenaLijekUnos.Text == "")
            {
                MessageBox.Show("Potrebno je unesti napomenu za odabrani lijek.");
                return;
            }

            Lijek odabraniLijek = uiActionOdaberiLijek.SelectedItem as Lijek;
            listaNapomenaZaLijekove.Add(uiNapomenaLijekUnos.Text);
            uiPropisaniLijekovi.Items.Add(odabraniLijek);
            uiNapomenaLijekUnos.Text = "";
        }        

        /// <summary>
        /// Popunjava napomenu temeljem odabranog propisanog lijeka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiPropisaniLijekovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = uiPropisaniLijekovi.SelectedIndex;
            
            try
            {
                uiNapomenaLijekUnos.Text = listaNapomenaZaLijekove[index];
            }
            catch(ArgumentOutOfRangeException)
            {
                uiNapomenaLijekUnos.Text = "";
            }
        }

        /// <summary>
        /// Briše napomenu prilikom odabira novog lijeka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiActionOdaberiLijek_SelectedIndexChanged(object sender, EventArgs e)
        {
            uiNapomenaLijekUnos.Text = "";
        }        

        /// <summary>
        /// Obriši lijek iz liste propisanih lijekova i njegovu napomenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiActionObrisiLijek_Click(object sender, EventArgs e)
        {
            int index = uiPropisaniLijekovi.SelectedIndex;
            
            if(index != -1)
            {
                uiPropisaniLijekovi.Items.RemoveAt(index);
                listaNapomenaZaLijekove.RemoveAt(index);
            }
        }

        #endregion        
    }
}
