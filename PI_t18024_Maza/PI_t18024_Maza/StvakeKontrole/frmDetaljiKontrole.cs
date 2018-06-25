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
    public partial class frmDetaljiKontrole : frmDizajnDijagnoza
    {
        Kontrola kontrola;
        Zivotinja zivotinja;
        Vlasnik vlasnik;
        bool status;

        List<Dijagnoza> listaDijagnoza;
        List<Operacija> listaOperacija;
        List<Cjepivo> listaCjepiva;
        public frmDetaljiKontrole(Kontrola kontrola)
        {
            InitializeComponent();
            this.kontrola = kontrola;

            listaDijagnoza = new List<Dijagnoza>();
            listaOperacija = new List<Operacija>();
            listaCjepiva = new List<Cjepivo>();
            // ukoliko je status obavljen onda ponudi pregled stavki kontrole
            // inace nudi dodavanje novih stavki

            //na vrh stavi podatke o kontroli
            // sredina mogucnosti
        }

        private void frmDetaljiKontrole_Load(object sender, EventArgs e)
        {
            this.vlasnik = null;
            using (var db = new MazaEntities())
            {
                this.zivotinja = db.Zivotinja.Where(s => s.ID_zivotinja == this.kontrola.ID_zivotinja).FirstOrDefault();
                this.vlasnik = db.Vlasnik.Where(s => s.ID_vlasnik == this.zivotinja.ID_vlasnika).FirstOrDefault() ;
            }
            this.uiImeZivotinjeTekst.Text = this.zivotinja.ime;
            this.uiVrstaZivotinjeTekst.Text = this.zivotinja.vrsta;
            this.uiDatumZivotinjeTekst.Text = this.zivotinja.datum_rodenja.ToShortDateString();
            this.uiVlasnikZivotinjeTekst.Text = this.vlasnik.ime + " " + this.vlasnik.prezime;
            
            this.uiDatumKontroleTekst.Text = this.kontrola.datum_kontrole.ToString();
            this.uiOpisTekst.Text = this.kontrola.opis;
            this.uiStatusTekst.Text = this.kontrola.status;

            ProvjeriVeterinara();
            ProvjeriStatus();

            DohvatiDijagnoze();
            PopuniStavkeDijagnozama();

            DohvatiCjepljenja();
            PopuniStavkeCjepljenjima();

            DohvatiOperacije();
            PopuniStavkeOperacijama();

            //ovisno o statusu prikazi stavke kontrole ukoliko ih ima <- taj dio kasnije
        }

        private void uiActionDodajOperaciju_Click(object sender, EventArgs e)
        {
            frmDodajOperaciju novaOperacija = new frmDodajOperaciju(this.vlasnik, this.zivotinja, this.kontrola);
            novaOperacija.StartPosition = FormStartPosition.CenterScreen;
            var rezultat = novaOperacija.ShowDialog();

            if (rezultat == DialogResult.OK)
            {
                listaOperacija.Add(novaOperacija.operacija);

                int i = listaOperacija.Count;
                Button kreiranaOperacija = new Button();
                kreiranaOperacija.Width = 75;
                kreiranaOperacija.Height = 25;
                kreiranaOperacija.Text = "Operacija " + i;
                kreiranaOperacija.Click += new EventHandler(OtvoriOperaciju);
                uiStavkeKontroleOperacije.Controls.Add(kreiranaOperacija);
                kreiranaOperacija.Location = new Point(kreiranaOperacija.Location.X + 175, kreiranaOperacija.Location.Y + 25 + (40 * (i - 1)));

            }
        }

        private void uiActionDodajDijagnozu_Click(object sender, EventArgs e)
        {
            frmDodajDijagnozu novaDijagnoza = new frmDodajDijagnozu(this.vlasnik,this.zivotinja,this.kontrola);
            novaDijagnoza.StartPosition= FormStartPosition.CenterScreen;
            var rezultat = novaDijagnoza.ShowDialog();

            if(rezultat == DialogResult.OK)
            {
                listaDijagnoza.Add(novaDijagnoza.dijagnoza);

                int i = listaDijagnoza.Count;
                Button kreiranaDijagnoza = new Button();
                kreiranaDijagnoza.Width = 75;
                kreiranaDijagnoza.Height = 25;
                kreiranaDijagnoza.Text = "Dijagnoza " + i;
                kreiranaDijagnoza.Click += new EventHandler(OtvoriDijagnozu);
                uiStavkeKontroleDijagnoze.Controls.Add(kreiranaDijagnoza);
                kreiranaDijagnoza.Location = new Point(kreiranaDijagnoza.Location.X + 25, kreiranaDijagnoza.Location.Y + 25 + (40 * (i - 1)));

            }
        }

        public void ProvjeriStatus()
        {
            if (this.kontrola.status == "Obavljen")
            {
                this.status = true;
                this.uiStatusTekst.ForeColor = Color.Green;
                this.uiActionDodajCijepljenje.Hide();
                this.uiActionDodajDijagnozu.Hide();
                this.uiActionDodajOperaciju.Hide();
            }
            else
            {
                this.status = false;
                this.uiStatusTekst.ForeColor = Color.Red;
                this.uiActionZatvoriDetaljeKontrole.Text = "Završi";
            }
        }

        public void ProvjeriVeterinara()
        {
            if(this.kontrola.ID_veterinar != PrijavljeniVeterinar.Veterinar.ID_veterinar)
            {
                this.uiActionDodajCijepljenje.Hide();
                this.uiActionDodajDijagnozu.Hide();
                this.uiActionDodajOperaciju.Hide();
                this.uiActionZatvoriDetaljeKontrole.Text = "Završi";
            }
        }

        public void DohvatiDijagnoze()
        {
            using (var db = new MazaEntities())
            {
                foreach (var dijagnoza in db.Dijagnoza)
                {
                    if(dijagnoza.ID_kontrola == this.kontrola.ID_kontrola)
                    {
                        this.listaDijagnoza.Add(dijagnoza);
                    }
                }
            }
        }

        public void DohvatiCjepljenja()
        {
            using (var db = new MazaEntities())
            {
                this.listaCjepiva=db.Cjepivo.Where(s => s.Kontrola.Any(c => c.ID_kontrola == this.kontrola.ID_kontrola)).ToList();
            }
        }

        public void DohvatiOperacije()
        {
            using (var db = new MazaEntities())
            {
                foreach (var operacija in db.Operacija)
                {
                    if(operacija.ID_kontrola == this.kontrola.ID_kontrola)
                    {
                        this.listaOperacija.Add(operacija);
                    }
                }
            }
        }

        public void PopuniStavkeDijagnozama()
        {
            if(this.listaDijagnoza.Count>0)
            {
                for(int i=1;i<=listaDijagnoza.Count;i++)
                {
                    Button kreiranaDijagnoza = new Button();
                    kreiranaDijagnoza.Width = 75;
                    kreiranaDijagnoza.Height = 25;
                    kreiranaDijagnoza.FlatStyle = FlatStyle.Flat;
                    kreiranaDijagnoza.BackColor = Color.FromArgb(89, 119, 183);
                    kreiranaDijagnoza.Text = "Dijagnoza " + i;
                    kreiranaDijagnoza.Click += new EventHandler(OtvoriDijagnozu);
                    uiStavkeKontroleDijagnoze.Controls.Add(kreiranaDijagnoza);
                    kreiranaDijagnoza.Location = new Point(kreiranaDijagnoza.Location.X + 25, kreiranaDijagnoza.Location.Y + 25 + (40*(i-1)));
                }
            }
        }

        public void PopuniStavkeCjepljenjima()
        {
            if(this.listaCjepiva.Count>0)
            {
                for (int i = 1; i <= listaCjepiva.Count; i++)
                {
                    Button kreiranoCjepljenje = new Button();
                    kreiranoCjepljenje.Width = 75;
                    kreiranoCjepljenje.Height = 25;
                    kreiranoCjepljenje.FlatStyle = FlatStyle.Flat;
                    kreiranoCjepljenje.BackColor = Color.FromArgb(89, 119, 183);
                    kreiranoCjepljenje.Text = "Cjepljenje " + i;
                    kreiranoCjepljenje.Click += new EventHandler(OtvoriCjepljenje);
                    uiStavkeKontroleCijepljenja.Controls.Add(kreiranoCjepljenje);
                    kreiranoCjepljenje.Location = new Point(kreiranoCjepljenje.Location.X + 25, kreiranoCjepljenje.Location.Y + 25 + (40 * (i - 1)));
                }
            }
        }

        public void PopuniStavkeOperacijama()
        {
            if(this.listaOperacija.Count>0)
            {
                for (int i = 1; i <= listaOperacija.Count; i++)
                {
                    Button kreiranaOperacija = new Button();
                    kreiranaOperacija.Width = 75;
                    kreiranaOperacija.Height = 25;
                    kreiranaOperacija.FlatStyle = FlatStyle.Flat;
                    kreiranaOperacija.BackColor = Color.FromArgb(89, 119, 183);
                    kreiranaOperacija.Text = "Operacija " + i;
                    kreiranaOperacija.Click += new EventHandler(OtvoriOperaciju);
                    uiStavkeKontroleOperacije.Controls.Add(kreiranaOperacija);
                    kreiranaOperacija.Location = new Point(kreiranaOperacija.Location.X + 25, kreiranaOperacija.Location.Y + 25 + (40 * (i - 1)));
                }
            }
        }

        private void OtvoriDijagnozu(object sender, EventArgs e)
        {
            Button gumb = (Button)sender;
            string[] polje = gumb.Text.Split(' ');
            int indexDijagnoze = int.Parse(polje[1]);
            Dijagnoza dijagnoza = listaDijagnoza[indexDijagnoze - 1];

            frmDodajDijagnozu postojecaDijagnoza = new frmDodajDijagnozu(this.vlasnik, this.zivotinja, this.kontrola, dijagnoza, this.status);
            postojecaDijagnoza.StartPosition = FormStartPosition.CenterScreen;
            var rezultat = postojecaDijagnoza.ShowDialog();
        }

        private void OtvoriCjepljenje(object sender, EventArgs e)
        {
            Button gumb = (Button)sender;
            string[] polje = gumb.Text.Split(' ');
            int indexCjepljenja = int.Parse(polje[1]);
            Cjepivo cjepivo = listaCjepiva[indexCjepljenja - 1];

            frmDodajCijepljenje postojeceCijepljenje = new frmDodajCijepljenje(this.vlasnik, this.zivotinja, this.kontrola, cjepivo, this.status);
            postojeceCijepljenje.StartPosition = FormStartPosition.CenterScreen;
            var rezultat = postojeceCijepljenje.ShowDialog();
        }

        private void OtvoriOperaciju(object sender, EventArgs e)
        {
            Button gumb = (Button)sender;
            string[] polje = gumb.Text.Split(' ');
            int indexOperacije = int.Parse(polje[1]);
            Operacija operacija = listaOperacija[indexOperacije - 1];

            frmDodajOperaciju postojecaOperacija = new frmDodajOperaciju(this.vlasnik, this.zivotinja, this.kontrola, operacija, this.status);
            postojecaOperacija.StartPosition = FormStartPosition.CenterScreen;
            var rezultat = postojecaOperacija.ShowDialog();
        }

        private void uiActionDodajCijepljenje_Click(object sender, EventArgs e)
        {
            frmDodajCijepljenje novoCijepljenje = new frmDodajCijepljenje(this.vlasnik, this.zivotinja, this.kontrola);
            novoCijepljenje.StartPosition = FormStartPosition.CenterScreen;
            var rezultat = novoCijepljenje.ShowDialog();

            if (rezultat == DialogResult.OK)
            {
                listaCjepiva.Add(novoCijepljenje.cjepivo);

                int i = listaCjepiva.Count;
                Button kreiranoCjepljenje = new Button();
                kreiranoCjepljenje.Width = 75;
                kreiranoCjepljenje.Height = 25;
                kreiranoCjepljenje.Text = "Cjepljenje " + i;
                kreiranoCjepljenje.Click += new EventHandler(OtvoriCjepljenje);
                uiStavkeKontroleCijepljenja.Controls.Add(kreiranoCjepljenje);
                kreiranoCjepljenje.Location = new Point(kreiranoCjepljenje.Location.X + 100, kreiranoCjepljenje.Location.Y + 25 + (40 * (i - 1)));
            }
        }

        private void uiActionZatvoriDetaljeKontrole_Click(object sender, EventArgs e)
        {

            if(this.kontrola.ID_veterinar == PrijavljeniVeterinar.Veterinar.ID_veterinar)
            {
                if(!this.status)
                {
                    if(MessageBox.Show("Da li ste stvarno završili sa kontrolom?", "Jeste li sigurni?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //promijeni status
                        this.Close();
                    }                    
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
            
        }
    }
}
