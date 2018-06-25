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
        public Cjepivo cjepivo;
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

                    //this.cjepivo.Kontrola.Remove(this.kontrola);
                    //this.kontrola.Cjepivo.Remove(this.cjepivo);

                    //db.Entry(this.kontrola).Collection("Cjepivo").Load();
                    this.kontrola.Cjepivo.Remove(this.cjepivo);

                    db.Cjepivo.Attach(cjepivo);
                    this.kontrola.Cjepivo.Add(cjepivo);
                    //cjepivo.Kontrola.Add(this.kontrola);
                }
                db.SaveChanges();
            }
            this.Close();
        }

        private void PopuniOsnovnePodatke()
        {
            uiVlasnikZivotinje.Text += vlasnik.ime + " " + vlasnik.prezime;
            uiImeZivotinje.Text += zivotinja.ime;
            uiVrstaZivotinje.Text += zivotinja.vrsta;
            uiDatumRodenjaZivotinje.Text += zivotinja.datum_rodenja.ToShortDateString();
        }

        private void PopuniCjepiva()
        {
            using (var db = new MazaEntities())
            {
                uiActionOdaberiCjepivo.DataSource = db.Cjepivo.ToList();
            }

            uiActionOdaberiCjepivo.DisplayMember = "ime";
            uiActionOdaberiCjepivo.ValueMember = "ID_cjepivo";
        }

        private void PopuniPodatkeOCjepivu(Cjepivo cjepivo)
        {
            if(cjepivo != null)
            {
                uiImeCjepivaTekst.Text = cjepivo.ime;
                uiProizvodacTekst.Text = cjepivo.proizvodac;
                uiRokTrajanjaTekst.Text = cjepivo.rok_trajanja.ToShortDateString();
                uiCijenaCjepivaTekst.Text = cjepivo.cijena + " kn";
                uiDozaCjepivaTekst.Text = cjepivo.doza + " mg";
            }
        }

        private void ProvjeriVeterinara()
        {
            if(this.kontrola.ID_veterinar != PrijavljeniVeterinar.Veterinar.ID_veterinar)
            {
                OnemoguciUnos();
            }
        }

        private void OnemoguciUnos()
        {
            uiActionOdaberiCjepivo.Enabled = false;

            uiActionDodajCjepivo.Hide();
        }
    }
}
