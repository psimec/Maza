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
        double brojDana = (int)DateTime.Now.DayOfWeek;

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
            //novi.Click += (s, e) => { funkcija koju button izvrsava };
            //novi.Text = datum, životinja, opis
            novi.Size = new Size(100, 50);
        }

        private void postaviAktivnost(Button aktivnost, int stupac, int red)
        {
            uiPanelAktivnosti.Controls.Add(aktivnost, column:stupac, row:red);
        }

        private void odrediTjedan(DateTime datum)
        {
            kreirajAkrivnost();
            brojDana = (int)datum.DayOfWeek - 1;
            datumOd = datum.AddDays(-brojDana);
            datumDo = datum.AddDays(6 - brojDana);
            MessageBox.Show(datumOd.ToString() + "  " + datumDo.ToString());
        }

        private void uiActionOdabirDatuma_ValueChanged(object sender, EventArgs e)
        {
            odrediTjedan(uiActionOdabirDatuma.Value); // odreduje tjedan za koji se prikazuju aktivnosti
            uiPanelAktivnosti.Invalidate();
            //uiPanelAktivnosti.RowCount++; dodavanje redova u panel
        }

        private void uiPanelAktivnosti_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Column == brojDana)
            {
                e.Graphics.FillRectangle(Brushes.LightPink, e.CellBounds);
            }           
        }
    }
}
