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
    public partial class Kalendar : Form
    {
        List<DanAktivnosti> daniAktivnosti = new List<DanAktivnosti>();
        DateTime datumOd;
        DateTime datumDo;
        
        public Kalendar()
        {
            InitializeComponent();
        }

        private void uiActionOdjava_Click(object sender, EventArgs e)
        {
            Form prijava = new Prijava();
            this.Hide();
            prijava.ShowDialog();
            this.Close();
        }

        private void kreirajAkrivnost()
        {
            Button novi = new Button();
            //novi.Text = datum, životinja, opis
            // novi.Location = new Point(x iz klase, y odreden prema kolicina aktivnosti za taj dan)
            this.Controls.Add(novi);
        }

        private void odrediTjedan(DateTime datum)
        {
            double brojDana = 0;
            switch (datum.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    brojDana = 0;
                    break;
                case DayOfWeek.Tuesday:
                    brojDana = 1;
                    break;
                case DayOfWeek.Wednesday:
                    brojDana = 2;
                    break;
                case DayOfWeek.Thursday:
                    brojDana = 3;
                    break;
                case DayOfWeek.Friday:
                    brojDana = 4;
                    break;
                case DayOfWeek.Saturday:
                    brojDana = 5;
                    break;
                case DayOfWeek.Sunday:
                    brojDana = 6;
                    break;
                default:
                    break;
            }

            datumOd = datum.AddDays(-brojDana);
            datumDo = datum.AddDays(6 - brojDana);
        }

        private void uiActionOdabirDatuma_ValueChanged(object sender, EventArgs e)
        {
            odrediTjedan(uiActionOdabirDatuma.Value); // odreduje tjedan za koji se prikazuju aktivnosti
            //uiPanelAktivnosti.RowCount++; dodavanje redova u panel
        }
    }
}
