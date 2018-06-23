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
        Vlasnik vlasnik;
        Zivotinja zivotinja;
        Kontrola kontrola;
        Cjepivo cjepivo;
        bool status;

        public frmDodajCijepljenje(Vlasnik vlasnik, Zivotinja zivotinja, Kontrola kontrola)
        {
            InitializeComponent();

            this.vlasnik = vlasnik;
            this.zivotinja = zivotinja;
            this.kontrola = kontrola;
        }

        public frmDodajCijepljenje(Vlasnik vlasnik, Zivotinja zivotinja, Kontrola kontrola, Cjepivo cjepivo, bool status)
        {
            InitializeComponent();

            this.vlasnik = vlasnik;
            this.zivotinja = zivotinja;
            this.kontrola = kontrola;
            this.cjepivo = cjepivo;
            this.status = status;
        }

        private void frmDodajCijepljenje_Load(object sender, EventArgs e)
        {
            PopuniOsnovnePodatke();
            PopuniCjepiva();

            if(this.cjepivo != null)
            {
                uiActionOdaberiCjepivo.SelectedValue = this.cjepivo.ID_cjepivo;
            }


            if (status != null && !status)
            {
                //PopuniPodatkeODijagnozi();
                uiActionDodajCjepivo.Text = "Ažuriraj cjepljenje";
            }
            else if (status != null && status)
            {
                //PopuniPodatkeODijagnozi();
                uiActionOdustani.Text = "Zatvori";
                //OnemoguciUnos();
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

        private void uiActionDodajCjepivo_Click(object sender, EventArgs e)
        {

        }

        private void PopuniOsnovnePodatke()
        {
            uiVlasnikZivotinje.Text += vlasnik.ime + " " + vlasnik.prezime;
            uiImeZivotinje.Text += zivotinja.ime;
            uiVrstaZivotinje.Text += zivotinja.vrsta;
            uiDatumRodenjaZivotinje.Text += zivotinja.datum_rodenja;
        }

        private void PopuniCjepiva()
        {
            using (var db = new MazaEntities())
            {
                uiActionOdaberiCjepivo.DataSource = db.Cjepivo.ToList();
            }
        }

        private void PopuniPodatkeOCjepivu(Cjepivo cjepivo)
        {
            if(cjepivo != null)
            {
                uiImeCjepiva.Text += cjepivo.ime;
                uiProizvodac.Text += cjepivo.proizvodac;
                uiRokTrajanja.Text += cjepivo.rok_trajanja;
                uiCijenaCjepiva.Text += cjepivo.cijena + " kn";
                uiDozaCjepiva.Text += cjepivo.doza + " mg";
            }
        }
    }
}
