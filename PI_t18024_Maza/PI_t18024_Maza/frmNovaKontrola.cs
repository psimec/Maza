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

        public frmNovaKontrola(frmKalendar kalendar)
        {
            InitializeComponent();
            this.kalendar = kalendar;
        }

        public frmNovaKontrola()
        {
            InitializeComponent();
            this.kalendar = null;
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
                this.Close();            
            }
            else
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
