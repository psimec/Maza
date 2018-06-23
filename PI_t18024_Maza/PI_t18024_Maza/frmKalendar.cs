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
    public partial class frmKalendar : frmDizajn
    {
        #region Globlane varijable

        List<DanAktivnosti> listaDaniAktivnosti = new List<DanAktivnosti>();
        double brojOdabranogDana;
        public DateTime datumOd;
        public DateTime datumDo;
        private bool sviVeterinari = false;

        #endregion

        #region Kontruktor

        /// <summary>
        /// Konstruktor forme Kalendar
        /// </summary>

        public frmKalendar()
        {
            InitializeComponent();
            uiActionOdabirDatuma.Format = DateTimePickerFormat.Custom;
            uiActionOdabirDatuma.CustomFormat = "dd-MM-yyyy";
            brojOdabranogDana = (int)DateTime.Now.DayOfWeek - 1 == -1 ? 6 : ((int)DateTime.Now.DayOfWeek - 1);
            datumOd = DateTime.Now.AddDays(-brojOdabranogDana).Date;
            datumDo = DateTime.Now.AddDays(6 - brojOdabranogDana).Date;
            PopuniDatume();
            IspisAktivnosti();
        }

        #endregion

        #region Fukncije baratanja odabranim datumom

        /// <summary>
        /// Odreduje datum pocetka i zavrsetka tjedna na temelju proslijedenog datuma
        /// </summary>
        /// <param name="datum"> Datum za koji se zeli odrediti datum pocetka i kraja tog tjedna </param>

        public void OdrediTjedan(DateTime datum)
        {
            brojOdabranogDana = (int)datum.DayOfWeek - 1;
            if (brojOdabranogDana == -1)
            {
                brojOdabranogDana = 6;
            }
            datumOd = datum.AddDays(-brojOdabranogDana).Date;
            datumDo = datum.AddDays(6 - brojOdabranogDana).Date;
        }

        /// <summary>
        /// Popunjava labele na na kalendaru na temelju trenutnog tjedna
        /// </summary>

        private void PopuniDatume()
        {
            uiPrikazDatuma1.Text = datumOd.ToString("dd/MM/yyyy");
            uiPrikazDatuma2.Text = datumOd.AddDays(1).ToString("dd/MM/yyyy");
            uiPrikazDatuma3.Text = datumOd.AddDays(2).ToString("dd/MM/yyyy");
            uiPrikazDatuma4.Text = datumOd.AddDays(3).ToString("dd/MM/yyyy");
            uiPrikazDatuma5.Text = datumOd.AddDays(4).ToString("dd/MM/yyyy");
            uiPrikazDatuma6.Text = datumOd.AddDays(5).ToString("dd/MM/yyyy");
            uiPrikazDatuma7.Text = datumOd.AddDays(6).ToString("dd/MM/yyyy");
        }

        #endregion

        #region Aktivnosti na kalendaru

        /// <summary>
        /// Kreiranje nove aktivnosti (termin kontrole) koja se dodaje na kalendar
        /// </summary>
        /// <param name="kontrola"> Kontrola na temelju koje se kreira aktivnost </param>
        /// <returns> Aktvinost u obliku buttona-a sa svim potrebim informacijama i zadovoljavajucim izgledom </returns>

        public Button KreirajAkrivnost(Kontrola kontrola) 
        {
            Button novi = new Button();
            novi.Click += (s, e) => 
            {
                frmDetaljiKontrole detaljiKontrole = new frmDetaljiKontrole(kontrola);
                detaljiKontrole.StartPosition = FormStartPosition.CenterScreen;
                this.Hide();
                detaljiKontrole.ShowDialog();
                this.Show();
                Osvjezi();
            };

            Zivotinja zivotinja;

            using (var db = new MazaEntities())
            {
                zivotinja = db.Zivotinja.Where(z => z.ID_zivotinja == kontrola.ID_zivotinja).FirstOrDefault();
            }

            novi.Text = kontrola.datum_kontrole.TimeOfDay + Environment.NewLine + zivotinja.ime + Environment.NewLine + kontrola.opis;
            novi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            novi.FlatAppearance.MouseOverBackColor = Color.LightGray;
            novi.Size = new Size(120, 50);
            novi.BringToFront();

            if (kontrola.status == "Obavljen")
            {
                novi.BackColor = Color.LightSeaGreen;
            }
            else if(kontrola.status == "Nije obavljen")
            {
                novi.BackColor = Color.IndianRed;
            }

            return novi;
        }

        /// <summary>
        /// Prikazuje aktivnost na kalendaru
        /// </summary>
        /// <param name="aktivnost"> Aktivnost za prikaz na kalendaru </param>
        /// <param name="stupac"> Dan u tjednu za koji zelimo dodati aktivnost </param>
        /// <param name="red"> Redoljed aktivnosti za odredeni dan </param>

        private void PostaviAktivnost(Button aktivnost, int stupac, int red)
        {
            uiPanelAktivnosti.Controls.Add(aktivnost, column: stupac, row: red);
        }

        private void DohvatiAktivnosti()
        {
            using (var db = new MazaEntities())
            {
                foreach (var kontrola in db.Kontrola)
                {
                    if (!sviVeterinari)
                    {
                        if (kontrola.datum_kontrole > datumOd.AddDays(-1) && kontrola.datum_kontrole < datumDo.AddDays(1) && kontrola.ID_veterinar == PrijavljeniVeterinar.Veterinar.ID_veterinar)
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
                    else
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
        }

        /// <summary>
        /// Postavljanje pozicija aktivnosti na kalendaru temeljem aktivnosti u objektima klase DanAktivnosti
        /// </summary>

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

        #endregion

        #region Funkcije

        /// <summary>
        /// Osvjezava stanje kalendara
        /// </summary>

        public void Osvjezi()
        {
            uiPanelAktivnosti.Controls.Clear();
            listaDaniAktivnosti.Clear();
            uiPanelAktivnosti.Invalidate();        
            OdrediTjedan(uiActionOdabirDatuma.Value);
            PopuniDatume();
            IspisAktivnosti();
        }

        #endregion

        #region Dogadaji

        private void uiActionOdabirDatuma_ValueChanged(object sender, EventArgs e)
        {
            Osvjezi();
        }

        // Promjeni pozadinsku boju trenutno selektiranog datuma

        private void uiPanelAktivnosti_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Column == brojOdabranogDana)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(89, 119, 183)), e.CellBounds);
            }

        }
        
        private void uiActionDodajAktivnost_Click(object sender, EventArgs e)
        {
            Form kreirajKontrolu = new frmNovaKontrola();
            kreirajKontrolu.StartPosition = FormStartPosition.CenterScreen;
            kreirajKontrolu.ShowDialog();
            Osvjezi();
        }

        // Nacin prikaza kalendara

        private void uiActionPrikaziSveAktivnosti_Click(object sender, EventArgs e)
        {
            sviVeterinari = !sviVeterinari;
            if (sviVeterinari)
            {
                uiActionPrikaziSveAktivnosti.Text = "Prikazi vlastite aktivnosti";
            }
            else
            {
                uiActionPrikaziSveAktivnosti.Text = "Prikazi sve aktivnosti";
            }

            Osvjezi();
        }

        #endregion
    }
}
