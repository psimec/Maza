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
    public partial class frmDetaljiKontrole : Form
    {
        Kontrola kontrola;
        Zivotinja zivotinja;
        public frmDetaljiKontrole(Kontrola kontrola)
        {
            InitializeComponent();
            this.kontrola = kontrola;
            // ukoliko je status obavljen onda ponudi pregled stavki kontrole
            // inace nudi dodavanje novih stavki

            //na vrh stavi podatke o kontroli
            // sredina mogucnosti
        }

        private void frmDetaljiKontrole_Load(object sender, EventArgs e)
        {
            Vlasnik vlasnik = null;
            using (var db = new MazaEntities())
            {
                this.zivotinja = db.Zivotinja.Where(s => s.ID_zivotinja == this.kontrola.ID_zivotinja).FirstOrDefault();
                vlasnik = db.Vlasnik.Where(s => s.ID_vlasnik == this.zivotinja.ID_vlasnika).FirstOrDefault() ;
            }
            this.uiImeZivotinje.Text += this.zivotinja.ime;
            this.uiVrstaZivotinje.Text += this.zivotinja.vrsta;
            this.uiDatumZivotinje.Text += this.zivotinja.datum_rodenja.ToShortDateString();
            this.uiVlasnikZivotinje.Text += vlasnik.ime + " " + vlasnik.prezime;

            this.uiDatumKontrole.Text += kontrola.datum_kontrole.ToString();
            this.uiStatusKontrole.Text += kontrola.status;
            this.uiOpisKontrole.Text += kontrola.opis;

            //ovisno o statusu prikazi stavke kontrole ukoliko ih ima <- taj dio kasnije
        }

        private void uiActionDodajOperaciju_Click(object sender, EventArgs e)
        {

        }
    }
}
