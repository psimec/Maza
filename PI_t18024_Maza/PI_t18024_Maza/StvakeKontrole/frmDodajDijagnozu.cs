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
        Vlasnik vlasnik;
        Zivotinja zivotinja;
        Kontrola kontrola;
        public Dijagnoza dijagnoza;
        bool status;

        List<string> listaNapomenaZaLijekove;

        public frmDodajDijagnozu(Vlasnik vlasnik, Zivotinja zivotinja, Kontrola kontrola)
        {
            InitializeComponent();

            this.vlasnik = vlasnik;
            this.zivotinja = zivotinja;
            this.kontrola = kontrola;
            this.listaNapomenaZaLijekove = new List<string>();
        }

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

        private void frmDodajDijagnozu_Load(object sender, EventArgs e)
        {
            PopuniOsnovnePodatke();

            //status true, onemoguci azuriranje
            //status false, omoguci azuriranje

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

        private void uiActionDodajDijagnozu_Click(object sender, EventArgs e)
        {
            // TODO: 
            // Spremi podatke u bazu
            // Promijeni funkcionalnost gumba temeljem moda u kojem je forma
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
                //Azuriraj jednostavne podatke
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
                Thread dretvaZaBrisanje = new Thread(new ThreadStart(DodajLijekove));
                dretvaZaBrisanje.Start();
            }
            this.Close();
        }



        private void uiActionDodajLijek_Click(object sender, EventArgs e)
        {
            //dohvati lijek iz comboboxa
            //upisi napomenu
            //prebaci lijek u listbox
            // upisi lijek u bazu
            // upisi napomenu u bazu
            //isprazni polje za napomenu

            Lijek odabraniLijek = uiActionOdaberiLijek.SelectedItem as Lijek;
            listaNapomenaZaLijekove.Add(uiNapomenaLijekUnos.Text);
            uiPropisaniLijekovi.Items.Add(odabraniLijek);
            uiNapomenaLijekUnos.Text = "";
        }

        private void PopuniOsnovnePodatke()
        {
            uiVlasnikZivotinje.Text += vlasnik.ime + " " + vlasnik.prezime;
            uiImeZivotinje.Text += zivotinja.ime;
            uiVrstaZivotinje.Text += zivotinja.vrsta;
            uiDatumRodenjaZivotinje.Text += zivotinja.datum_rodenja.ToShortDateString();
        }

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
                    if(lijek.ID_dijagnoza == dijagnoza.ID_dijagnoza)
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

        private void PopuniLijekove()
        {
            using (var db = new MazaEntities())
            {
                uiActionOdaberiLijek.DataSource = db.Lijek.ToList();                
            }
        }

        private void PopuniBolesti()
        {
            using (var db = new MazaEntities())
            {
                uiActionOdaberiBolest.DataSource = db.Bolest.ToList();
            }
        }

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

        private void uiActionOdaberiLijek_SelectedIndexChanged(object sender, EventArgs e)
        {
            uiNapomenaLijekUnos.Text = "";
        }

        public void ObrisiLijekove()
        {
            using (var db = new MazaEntities())
            {
                Bolest bolest = uiActionOdaberiBolest.SelectedItem as Bolest;

                db.Bolest.Attach(bolest);
                db.Kontrola.Attach(this.kontrola);
                db.Dijagnoza.Attach(this.dijagnoza);

                foreach (var propisaniLijek in db.PropisaniLijek)
                {
                    if (propisaniLijek.ID_dijagnoza == this.dijagnoza.ID_dijagnoza)
                    {
                        db.PropisaniLijek.Attach(propisaniLijek);
                        db.PropisaniLijek.Remove(propisaniLijek);
                    }
                }
                db.SaveChanges();
            }

            Thread.Sleep(500);
            Thread dretva = new Thread(new ThreadStart(DodajLijekove));
            dretva.Start();
        }

        public void DodajLijekove()
        {
            using (var db = new MazaEntities())
            {
                Bolest bolest = uiActionOdaberiBolest.SelectedItem as Bolest;

                db.Bolest.Attach(bolest);
                db.Kontrola.Attach(this.kontrola);
                db.Dijagnoza.Attach(this.dijagnoza);

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
                            listaNapomenaZaLijekove[i] = "#343";
                            pronadjen = true;
                        }
                    }

                    if (!pronadjen)
                    {
                        propisaniLijek = db.PropisaniLijek.Where(s => s.ID_lijek == lijekIzListe.ID_lijek && s.ID_dijagnoza == this.dijagnoza.ID_dijagnoza).FirstOrDefault();
                        db.PropisaniLijek.Attach(propisaniLijek);
                        db.PropisaniLijek.Remove(propisaniLijek);
                    }
                }

                for (int i = 0; i < uiPropisaniLijekovi.Items.Count; i++)
                {
                    Lijek lijek = uiPropisaniLijekovi.Items[i] as Lijek;
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

        private void uiActionObrisiLijek_Click(object sender, EventArgs e)
        {
            int index = uiPropisaniLijekovi.SelectedIndex;
            
            if(index != -1)
            {
                uiPropisaniLijekovi.Items.RemoveAt(index);
                listaNapomenaZaLijekove.RemoveAt(index);
            }
        }

        private void ProvjeriVeterinara()
        {
            if (this.kontrola.ID_veterinar != PrijavljeniVeterinar.Veterinar.ID_veterinar)
            {
                OnemoguciUnos();
            }
        }

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
    }
}
