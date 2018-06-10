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
        double brojDana;
        DateTime datumOd;
        DateTime datumDo;
        //Dictionary<DayOfWeek, Dictionary<int, object>> brojAktivnostiPoDanu; mogucnost za bilježenje broja aktivnosti u redu

        public Kalendar()
        {
            InitializeComponent();         
            brojDana = (int)DateTime.Now.DayOfWeek - 1 == -1 ? 6 : ((int)DateTime.Now.DayOfWeek - 1);
            datumOd = DateTime.Now.AddDays(-brojDana);
            datumDo = DateTime.Now.AddDays(6 - brojDana);
            dohvatiAktivnosti();
        }

        private Button kreirajAkrivnost(DateTime datum, string zivotinja) // treba i id
        {
            Button novi = new Button();
            //novi.Click += (s, e) => { funkcija koju button izvrsava };
            novi.Text = datum + Environment.NewLine + zivotinja;
            novi.Size = new Size(100, 50);
            return novi;
        }

        private void postaviAktivnost(Button aktivnost, int stupac, int red)
        {
            uiPanelAktivnosti.Controls.Add(aktivnost, column: stupac, row: red);
        }

        private int odrediStupac(DateTime datum)
        {
           return (int)datum.DayOfWeek - 1;
        }

        private void odrediTjedan(DateTime datum)
        {
            brojDana = (int)datum.DayOfWeek - 1;
            if (brojDana == -1)
            {
                brojDana = 6;
            }
            datumOd = datum.AddDays(-brojDana);
            datumDo = datum.AddDays(6 - brojDana);
        }

        private void dohvatiAktivnosti()
        {
            using (var db = new MazaEntities())
            {
                foreach (var kontrola in db.Kontrola)
                {
                    if (kontrola.DatumKontrole >= datumOd && kontrola.DatumKontrole <= datumDo)
                    {
                        
                        Zivotinja zivotinja = db.Zivotinja.Where(z => z.IdZivotinja == kontrola.IdZivotinja).FirstOrDefault();
                        Button aktivnost = kreirajAkrivnost(kontrola.DatumKontrole, zivotinja.Ime);
                        postaviAktivnost(aktivnost, odrediStupac(kontrola.DatumKontrole), 0);
                    }                    
                }
            }
        }

        private void uiActionOdabirDatuma_ValueChanged(object sender, EventArgs e)
        {
            uiPanelAktivnosti.Controls.Clear();
            odrediTjedan(uiActionOdabirDatuma.Value); // odreduje tjedan za koji se prikazuju aktivnosti
            uiPanelAktivnosti.Invalidate();
            dohvatiAktivnosti();
            //uiPanelAktivnosti.RowCount++; dodavanje redova u panel
        }

        private void uiPanelAktivnosti_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Column == brojDana)
            {
                e.Graphics.FillRectangle(Brushes.LightPink, e.CellBounds);
            }
        }

        private void uiActionZivotinje_Click(object sender, EventArgs e)
        {
            Zivotinje zivotinje = new Zivotinje();
            zivotinje.ShowDialog();
        }

        private void uiActionOdjava_Click(object sender, EventArgs e)
        {
            Form prijava = new Prijava();
            this.Hide();
            prijava.ShowDialog();
            this.Close();
        }
    }
}
