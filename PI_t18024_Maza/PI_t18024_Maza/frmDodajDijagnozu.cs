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
    public partial class frmDodajDijagnozu : Form
    {
        Vlasnik vlasnik;
        Zivotinja zivotinja;
        Kontrola kontrola;
        Dijagnoza dijagnoza;

        List<string> listaNapomenaZaLijekove;

        public frmDodajDijagnozu(Vlasnik vlasnik, Zivotinja zivotinja, Kontrola kontrola)
        {
            InitializeComponent();

            this.vlasnik = vlasnik;
            this.zivotinja = zivotinja;
            this.kontrola = kontrola;
            this.listaNapomenaZaLijekove = new List<string>();
        }

        public frmDodajDijagnozu(Vlasnik vlasnik, Zivotinja zivotinja, Kontrola kontrola, Dijagnoza dijagnoza)
        {
            InitializeComponent();

            this.vlasnik = vlasnik;
            this.zivotinja = zivotinja;
            this.kontrola = kontrola;
            this.dijagnoza = dijagnoza;
            this.listaNapomenaZaLijekove = new List<string>();
        }

        private void frmDodajDijagnozu_Load(object sender, EventArgs e)
        {
            uiVlasnikZivotinje.Text += vlasnik.ime + " " + vlasnik.prezime;
            uiImeZivotinje.Text += zivotinja.ime;
            uiVrstaZivotinje.Text += zivotinja.vrsta;
            uiDatumRodenjaZivotinje.Text += zivotinja.datum_rodenja;

            uiPropisaniLijekovi.DisplayMember = "naziv";
            uiPropisaniLijekovi.ValueMember = "ID_lijek";

            PopuniLijekove();
            PopuniBolesti();
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

            using (var db = new MazaEntities())
            {
                //Nova dijagnoza
                if (this.dijagnoza == null)
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
            }

            this.DialogResult = DialogResult.OK;
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

        private void uiActionObrisiLijek_Click(object sender, EventArgs e)
        {
            int index = uiPropisaniLijekovi.SelectedIndex;
            
            if(index != -1)
            {
                uiPropisaniLijekovi.Items.RemoveAt(index);
                listaNapomenaZaLijekove.RemoveAt(index);
            }
        }
    }
}
