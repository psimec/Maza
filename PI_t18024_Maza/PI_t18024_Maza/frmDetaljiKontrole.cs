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

            ProvjeriStatus();

            DohvatiDijagnoze();
            PopuniStavkeDijagnozama();

            //ovisno o statusu prikazi stavke kontrole ukoliko ih ima <- taj dio kasnije
        }

        private void uiActionDodajOperaciju_Click(object sender, EventArgs e)
        {

        }

        private void uiActionDodajDijagnozu_Click(object sender, EventArgs e)
        {
            frmDodajDijagnozu novaDijagnoza = new frmDodajDijagnozu(this.vlasnik,this.zivotinja,this.kontrola);
            var rezultat = novaDijagnoza.ShowDialog();

            if(rezultat == DialogResult.OK)
            {
                //listaDijagnoza.Add(novaDijagnoza.Dijagnoza);

                //kreiraj gumb
                Button kreiranaDijagnoza = new Button();
                kreiranaDijagnoza.Width = 75;
                kreiranaDijagnoza.Height = 25;
                kreiranaDijagnoza.Text = "Dijagnoza 1";
                //kreiranaDijagnoza.Click += dodaj funkcionalnost ispunjavanja forme za dijagnozu temeljem podataka u listi dijagnoza
                uiStavkeKontrole.Controls.Add(kreiranaDijagnoza);
                kreiranaDijagnoza.Location = new Point(kreiranaDijagnoza.Location.X + 25, kreiranaDijagnoza.Location.Y+25);

            }
        }

        public void ProvjeriStatus()
        {
            if (this.kontrola.status == "Obavljen")
            {
                this.status = true;
                this.uiStatusTekst.ForeColor = Color.Green;
            }
            else
            {
                this.status = false;
                this.uiStatusTekst.ForeColor = Color.Red;
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

        public void PopuniStavkeDijagnozama()
        {
            if(this.listaDijagnoza.Count>0)
            {
                for(int i=1;i<=listaDijagnoza.Count;i++)
                {
                    Button kreiranaDijagnoza = new Button();
                    kreiranaDijagnoza.Width = 75;
                    kreiranaDijagnoza.Height = 25;
                    kreiranaDijagnoza.Text = "Dijagnoza " + i;
                    kreiranaDijagnoza.Click += new EventHandler(OtvoriDijagnozu);
                    uiStavkeKontrole.Controls.Add(kreiranaDijagnoza);
                    kreiranaDijagnoza.Location = new Point(kreiranaDijagnoza.Location.X + 25, kreiranaDijagnoza.Location.Y + 25 + (30*(i-1)));
                }
            }
        }

        public void OtvoriDijagnozu(object sender, EventArgs e)
        {
            Button gumb = (Button)sender;
            string[] polje = gumb.Text.Split(' ');
            int indexDijagnoze = int.Parse(polje[1]);
            Dijagnoza dijagnoza = listaDijagnoza[indexDijagnoze - 1];

            frmDodajDijagnozu postojecaDijagnoza = new frmDodajDijagnozu(this.vlasnik, this.zivotinja, this.kontrola, dijagnoza, this.status);
            var rezultat = postojecaDijagnoza.ShowDialog();
        }
    }
}
