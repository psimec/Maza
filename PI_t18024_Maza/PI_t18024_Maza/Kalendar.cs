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
    public partial class Kalendar : Dizajn
    {
        List<DanAktivnosti> listaDaniAktivnosti = new List<DanAktivnosti>();
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
            datumOd = datumOd.Date;
            datumDo = datumDo.Date;
            ispisAktivnosti();
        }

        private Button kreirajAkrivnost(DateTime datum, string zivotinja, int idKontrola, string opis) 
        {
            Button novi = new Button();
            novi.Click += (s, e) => 
            {
                KontrolaForm kontrola = new KontrolaForm( idKontrola); 
                this.Hide();
                kontrola.StartPosition = FormStartPosition.CenterScreen;
                kontrola.ShowDialog();
                this.Close();
            };
            novi.Text = datum.TimeOfDay + Environment.NewLine +zivotinja + Environment.NewLine + opis;
            novi.Size = new Size(100, 50);
            return novi;
        }

        private void postaviAktivnost(Button aktivnost, int stupac, int red)
        {
            uiPanelAktivnosti.Controls.Add(aktivnost, column: stupac, row: red);
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
            datumOd = datumOd.Date;
            datumDo = datumDo.Date;
        }

        private void dohvatiAktivnosti()
        {
            using (var db = new MazaEntities())
            {
                foreach (var kontrola in db.Kontrola)
                {
                    if (kontrola.datum_kontrole > datumOd.AddDays(-1) && kontrola.datum_kontrole < datumDo.AddDays(1))
                    {
                        //MessageBox.Show(datumOd.AddDays(-1).ToString());
                        Zivotinja zivotinja = db.Zivotinja.Where(z => z.ID_zivotinja == kontrola.ID_zivotinja).FirstOrDefault();
                        Button aktivnost = kreirajAkrivnost(kontrola.datum_kontrole, zivotinja.ime, kontrola.ID_kontrola, kontrola.opis);
                        int index = listaDaniAktivnosti.FindIndex(a => a.Dan == kontrola.datum_kontrole.DayOfWeek);
                        if (index >= 0)
                        {
                            listaDaniAktivnosti[index].DodajAktivnost(aktivnost);
                        }
                        else
                        {
                            DanAktivnosti nova = new DanAktivnosti(kontrola.datum_kontrole.DayOfWeek, aktivnost);
                            listaDaniAktivnosti.Add(nova);
                        }                                            
                    }                    
                }
            }
        }

        private void ispisAktivnosti()
        {
            dohvatiAktivnosti();

            foreach (var danTjedna in listaDaniAktivnosti)
            {
                int red = 0;
                danTjedna.SortirajListuAktivnosti();
                foreach (var aktivnost in danTjedna.ListaAktivnosti)
                {
                    postaviAktivnost(aktivnost, (int)danTjedna.Dan -1, red);
                    red++;
                }
            }
        }

        public void Osvjezi()
        {
            uiPanelAktivnosti.Controls.Clear();
            listaDaniAktivnosti.Clear();
            odrediTjedan(uiActionOdabirDatuma.Value);
            uiPanelAktivnosti.Invalidate();
            ispisAktivnosti();
            //uiPanelAktivnosti.RowCount++; dodavanje redova u panel
        }

        private void uiActionOdabirDatuma_ValueChanged(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void uiPanelAktivnosti_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Column == brojDana)
            {
                e.Graphics.FillRectangle(Brushes.LightPink, e.CellBounds);
            }
        }
        
        private void uiActionDodajAktivnost_Click(object sender, EventArgs e)
        {
            Form kreirajKontrolu = new NovaKontrola(this);
            kreirajKontrolu.StartPosition = FormStartPosition.CenterScreen;
            kreirajKontrolu.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PovijestBolesti povijestBolesti = new PovijestBolesti(3);
            povijestBolesti.ShowDialog();
        }
    }
}
