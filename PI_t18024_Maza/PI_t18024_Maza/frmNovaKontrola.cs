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
        frmKalendar kalendar;
        Kontrola kontrola;

        public frmNovaKontrola(frmKalendar kalendar)
        {
            InitializeComponent();
            this.kalendar = kalendar;
            this.kontrola = null;
        }

        public frmNovaKontrola(Kontrola kontrola)
        {
            InitializeComponent();
            this.kalendar = null;
            this.kontrola = kontrola;
            
        }

        public frmNovaKontrola()
        {
            InitializeComponent();
            this.kalendar = null;
            this.kontrola = null;
        }

        private void NovaKontrola_Load(object sender, EventArgs e)
        {
            using (var db = new MazaEntities())
            {
                uiOdabirVeterinar.DataSource = db.Veterinar.ToList();
                uiOdabirVeterinar.DisplayMember = "Ime";
                uiOdabirVeterinar.ValueMember = "ID_Veterinar";

                uiOdabirZivotinja.DataSource = db.Zivotinja.ToList();
                uiOdabirZivotinja.DisplayMember = "Ime";
                uiOdabirZivotinja.ValueMember = "ID_Zivotinja";

                uiOdabirStatus.SelectedIndex = 1;
            }

            if (this.kontrola != null) // popuni s odabranim podacima
            {
                this.uiOdabirZivotinja.SelectedValue = kontrola.ID_zivotinja;
                this.uiOdabirVeterinar.SelectedValue = kontrola.ID_veterinar;
                this.uiOdabirDatum.Value = kontrola.datum_kontrole;
                this.uiOdabirStatus.Text = kontrola.status;
                this.uiUnosOpis.Text = kontrola.opis;
            }
        }

        private void uiActionOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uiActionUredu_Click(object sender, EventArgs e)
        {
            if (uiOdabirStatus.Text != "" && uiUnosOpis.Text != "" )
            {
                using (var db = new MazaEntities())
                {
                    if (this.kontrola == null)
                    {
                        Zivotinja zivotinja = uiOdabirZivotinja.SelectedItem as Zivotinja;
                        Veterinar veterinar = uiOdabirVeterinar.SelectedItem as Veterinar;

                        db.Zivotinja.Attach(zivotinja);
                        db.Veterinar.Attach(veterinar);

                        Kontrola kontrola = new Kontrola
                        {
                            ID_veterinar = veterinar.ID_veterinar,
                            ID_zivotinja = zivotinja.ID_zivotinja,
                            datum_kontrole = uiOdabirDatum.Value,
                            status = uiOdabirStatus.Text,
                            opis = uiUnosOpis.Text,
                            Zivotinja = zivotinja,
                            Veterinar = veterinar
                        };

                        db.Kontrola.Add(kontrola);
                        db.SaveChanges();
                    }
                    else
                    {
                        db.Kontrola.Attach(kontrola);

                        Zivotinja zivotinja = uiOdabirZivotinja.SelectedItem as Zivotinja;
                        Veterinar veterinar = uiOdabirVeterinar.SelectedItem as Veterinar;

                        db.Zivotinja.Attach(zivotinja);
                        db.Veterinar.Attach(veterinar);

                        kontrola.ID_veterinar = veterinar.ID_veterinar;
                        kontrola.ID_zivotinja = zivotinja.ID_zivotinja;
                        kontrola.datum_kontrole = uiOdabirDatum.Value;
                        kontrola.status = uiOdabirStatus.Text;
                        kontrola.opis = uiUnosOpis.Text;
                        kontrola.Zivotinja = zivotinja;
                        kontrola.Veterinar = veterinar;

                        db.SaveChanges();
                    }
                }
                this.Close();            
            }
            else // ako podaci nisu uneseni
            {
                return;
            }     
        }

        private void NovaKontrola_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (kalendar != null)
            {
                kalendar.Osvjezi();
            }         
        }
    }
}
