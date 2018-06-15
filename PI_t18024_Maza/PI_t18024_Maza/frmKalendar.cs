﻿using System;
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
    public partial class frmKalendar : frmDizajn
    {
        List<DanAktivnosti> listaDaniAktivnosti = new List<DanAktivnosti>();
        double brojDana;
        DateTime datumOd;
        DateTime datumDo;
        //Dictionary<DayOfWeek, Dictionary<int, object>> brojAktivnostiPoDanu; mogucnost za bilježenje broja aktivnosti u redu

        public frmKalendar()
        {
            InitializeComponent();         
            brojDana = (int)DateTime.Now.DayOfWeek - 1 == -1 ? 6 : ((int)DateTime.Now.DayOfWeek - 1);
            datumOd = DateTime.Now.AddDays(-brojDana);
            datumDo = DateTime.Now.AddDays(6 - brojDana);
            datumOd = datumOd.Date;
            datumDo = datumDo.Date;
            IspisAktivnosti();
        }

        private Button KreirajAkrivnost(Kontrola kontrola) 
        {
            Button novi = new Button();
            novi.Click += (s, e) => 
            {
                frmDetaljiKontrole detaljiKontrole = new frmDetaljiKontrole(kontrola);
                detaljiKontrole.StartPosition = FormStartPosition.CenterScreen;
                detaljiKontrole.ShowDialog();
            };

            Zivotinja zivotinja;

            using (var db = new MazaEntities())
            {
                zivotinja = db.Zivotinja.Where(z => z.ID_zivotinja == kontrola.ID_zivotinja).FirstOrDefault();
            }
            novi.Text = kontrola.datum_kontrole.TimeOfDay + Environment.NewLine + zivotinja.ime + Environment.NewLine + kontrola.opis;
            novi.Size = new Size(100, 50);
            return novi;
        }

        private void PostaviAktivnost(Button aktivnost, int stupac, int red)
        {
            uiPanelAktivnosti.Controls.Add(aktivnost, column: stupac, row: red);
        }

        private void OdrediTjedan(DateTime datum)
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

        private void DohvatiAktivnosti()
        {
            using (var db = new MazaEntities())
            {
                foreach (var kontrola in db.Kontrola)
                {
                    if (kontrola.datum_kontrole > datumOd.AddDays(-1) && kontrola.datum_kontrole < datumDo.AddDays(1))
                    {
                        int index = listaDaniAktivnosti.FindIndex(a => a.Dan == kontrola.datum_kontrole.DayOfWeek);
                        if (index >= 0)
                        {
                            listaDaniAktivnosti[index].DodajAktivnost(kontrola);
                        }
                        else
                        {
                            DanAktivnosti noviDanAktivnosti = new DanAktivnosti(kontrola.datum_kontrole.DayOfWeek, kontrola);
                            listaDaniAktivnosti.Add(noviDanAktivnosti);
                        }                                            
                    }                    
                }
            }
        }

        private void IspisAktivnosti()
        {
            DohvatiAktivnosti();

            foreach (var danTjedna in listaDaniAktivnosti)
            {
                int red = 0;
                danTjedna.SortirajListuAktivnosti();
                foreach (var aktivnost in danTjedna.ListaKontrola)
                {
                    Button treuntaKontrola = KreirajAkrivnost(aktivnost);
                    PostaviAktivnost(treuntaKontrola, (int)danTjedna.Dan -1, red);
                    red++;
                }
            }
        }

        public void Osvjezi()
        {
            uiPanelAktivnosti.Controls.Clear();
            listaDaniAktivnosti.Clear();
            OdrediTjedan(uiActionOdabirDatuma.Value);
            uiPanelAktivnosti.Invalidate();
            IspisAktivnosti();
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
            Form kreirajKontrolu = new frmNovaKontrola(this);
            kreirajKontrolu.StartPosition = FormStartPosition.CenterScreen;
            kreirajKontrolu.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPovijestBolesti povijestBolesti = new frmPovijestBolesti(3);
            povijestBolesti.ShowDialog();
        }
    }
}
