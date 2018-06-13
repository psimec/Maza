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
            this.uiDatumKontrole.Text = kontrola.datum_kontrole.ToString();
            this.uiStatusKontrole.Text = kontrola.status;
            this.uiOpisKontrole.Text = kontrola.opis;
        }
    }
}
