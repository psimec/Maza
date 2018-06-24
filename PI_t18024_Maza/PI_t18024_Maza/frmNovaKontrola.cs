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
    public partial class frmNovaKontrola : Form
    {
        #region Globalne varijable

        Kontrola kontrola;

        #endregion

        #region Konstruktori

        public frmNovaKontrola()
        {
            InitializeComponent();
            this.kontrola = null;
        }

        public frmNovaKontrola(Kontrola kontrola)
        {
            InitializeComponent();
            this.kontrola = kontrola;
        }

        #endregion

        #region Funkcije

        private void PopuniZivotinje(int idVlasnik)
        {
            using (var db = new MazaEntities())
            {
                List<Zivotinja> listaTrazenihZivotinja = db.Zivotinja.Where(z => z.ID_vlasnika == idVlasnik).ToList();

                uiOdabirZivotinja.DataSource = listaTrazenihZivotinja;
                uiOdabirZivotinja.DisplayMember = "ime";
                uiOdabirZivotinja.ValueMember = "ID_zivotinja";
            }
        }

        #endregion

        #region Dogadaji

        private void NovaKontrola_Load(object sender, EventArgs e)
        {
            uiOdabirStatusObavljen.Checked = true;
            uiOdabirDatum.Format = DateTimePickerFormat.Custom;
            uiOdabirDatum.CustomFormat = "dd-MM-yyyy H:mm:ss";

            using (var db = new MazaEntities())
            {
                List<KeyValuePair<int, string>> listaVlasnika = new List<KeyValuePair<int, string>>();
                List<KeyValuePair<int, string>> listaVeterinara = new List<KeyValuePair<int, string>>();

                foreach (Vlasnik item in db.Vlasnik)
                {
                    listaVlasnika.Add(new KeyValuePair<int, string>(item.ID_vlasnik, item.ime + " " + item.prezime));
                }

                foreach (Veterinar item in db.Veterinar)
                {
                    listaVeterinara.Add(new KeyValuePair<int, string>(item.ID_veterinar, item.ime + " " + item.prezime));
                }

                uiOdabirVlasnik.DataSource = listaVlasnika;
                uiOdabirVlasnik.DisplayMember = "Value";
                uiOdabirVlasnik.ValueMember = "Key";

                uiOdabirVeterinar.DataSource = listaVeterinara;
                uiOdabirVeterinar.DisplayMember = "Value";
                uiOdabirVeterinar.ValueMember = "Key";
               
                uiOdabirVeterinar.SelectedValue = PrijavljeniVeterinar.Veterinar.ID_veterinar;
            }

            // Popuni elemente forme temeljem podataka kontrole

            if (this.kontrola != null)
            {
                this.uiOdabirZivotinja.SelectedValue = kontrola.ID_zivotinja;
                this.uiOdabirVeterinar.SelectedValue = kontrola.ID_veterinar;
                this.uiOdabirDatum.Value = kontrola.datum_kontrole;
                this.uiUnosOpis.Text = kontrola.opis;

                if (kontrola.status == "Obavljen")
                {
                    uiOdabirStatusObavljen.Checked = true;
                }
                else
                {
                    uiOdabirStatusNijeObavljen.Checked = true;
                }
            }
        }

        private void uiOdabirVlasnik_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyValuePair<int, string> oznaceniVlasnik = (KeyValuePair<int, string>)uiOdabirVlasnik.SelectedItem;
            PopuniZivotinje(oznaceniVlasnik.Key);          
        }

        private void uiActionOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uiActionUredu_Click(object sender, EventArgs e)
        {
            if (uiUnosOpis.Text != "" )
            {

                string status = "";

                if (uiOdabirStatusObavljen.Checked)
                {
                    status = "Obavljen";
                }
                else
                {
                    status = "Nije obavljen";
                }

                // Dodaj novu kontrolu u bazu podataka

                using (var db = new MazaEntities())
                {
                    KeyValuePair<int, string> oznaceniVeterinar = (KeyValuePair<int, string>)uiOdabirVeterinar.SelectedItem;
                    Veterinar veterinar = db.Veterinar.Where(v => v.ID_veterinar == oznaceniVeterinar.Key).FirstOrDefault();
                    
                    if (this.kontrola == null)
                    {          
                        Zivotinja zivotinja = uiOdabirZivotinja.SelectedItem as Zivotinja;

                        db.Zivotinja.Attach(zivotinja);
                        db.Veterinar.Attach(veterinar);

                        Kontrola kontrola = new Kontrola
                        {
                            ID_veterinar = veterinar.ID_veterinar,
                            ID_zivotinja = zivotinja.ID_zivotinja,
                            datum_kontrole = uiOdabirDatum.Value,
                            status = status,
                            opis = uiUnosOpis.Text,
                            Zivotinja = zivotinja,
                            Veterinar = veterinar
                        };

                        db.Kontrola.Add(kontrola);
                        db.SaveChanges();
                    }

                    // Ažurira postojecu kontrolu

                    else
                    {
                        db.Kontrola.Attach(kontrola);

                        Zivotinja zivotinja = uiOdabirZivotinja.SelectedItem as Zivotinja;

                        db.Zivotinja.Attach(zivotinja);
                        db.Veterinar.Attach(veterinar);

                        kontrola.ID_veterinar = veterinar.ID_veterinar;
                        kontrola.ID_zivotinja = zivotinja.ID_zivotinja;
                        kontrola.datum_kontrole = uiOdabirDatum.Value;
                        kontrola.status = status;
                        kontrola.opis = uiUnosOpis.Text;
                        kontrola.Zivotinja = zivotinja;
                        kontrola.Veterinar = veterinar;

                        db.SaveChanges();
                    }
                }
                this.Close();            
            }
            else 
            {
                return;
            }     
        }

        #endregion
    }
}
