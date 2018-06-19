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

        List<string> listaNapomenaZaLijekove;

        public frmDodajDijagnozu(Vlasnik vlasnik, Zivotinja zivotinja)
        {
            InitializeComponent();

            this.vlasnik = vlasnik;
            this.zivotinja = zivotinja;
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
    }
}
