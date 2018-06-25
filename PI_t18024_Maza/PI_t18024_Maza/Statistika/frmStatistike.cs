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
    public partial class frmStatistike : frmDizajn
    {
        public frmStatistike()
        {
            InitializeComponent();
        }

        private void uiActionPrikaziGraf_Click(object sender, EventArgs e)
        {
            PrikaziVrsteZivotinja();
        }

        private void PrikaziVrsteZivotinja()
        {
            this.uiGraf.Series.Clear();
            this.uiGraf.Series.Add("Broj životinja");

            List<Zivotinja> listaZivotinja = null;
            using (var db = new MazaEntities())
            {
                listaZivotinja = db.Zivotinja.ToList();
            }

            var brojZivotinja = listaZivotinja.GroupBy(n => n.vrsta).Select(group => new
            {
                vrsta = group.Key,
                broj = group.Count()
            });

            foreach (var item in brojZivotinja)
            {
                this.uiGraf.Series["Broj životinja"].Points.AddXY(item.vrsta, item.broj);
            }
        }

        private void PrikaziKontrole()
        {
            this.uiGraf.Series.Clear();
            this.uiGraf.Series.Add("Obavljene kontrole");
            this.uiGraf.Series.Add("Neobavljene kontrole");

            this.uiGraf.Series["Obavljene kontrole"].Color = Color.Green;
            this.uiGraf.Series["Neobavljene kontrole"].Color = Color.Red;

            List<Kontrola> listaKontrola = null;
            List<Veterinar> listaVeterinara = null;
            using (var db = new MazaEntities())
            {
                listaKontrola = db.Kontrola.ToList();
                listaVeterinara = db.Veterinar.ToList();
            }

            var brojObavljenihKontrola = listaKontrola.Where(s => s.status == "Obavljen").GroupBy(n => n.ID_veterinar).Select(group => new
            {
                veterinar = group.Key,
                broj = group.Count()
            });

            foreach (var item in brojObavljenihKontrola)
            {
                foreach (Veterinar veterinar in listaVeterinara)
                {
                    if(veterinar.ID_veterinar == item.veterinar)
                    {
                        this.uiGraf.Series["Obavljene kontrole"].Points.AddXY(veterinar.ime + " " + veterinar.prezime, item.broj);
                        break;
                    }
                }
            }

            var brojNeobavljenihKontrola = listaKontrola.Where(s => s.status == "Nije obavljen").GroupBy(n => n.ID_veterinar).Select(group => new
            {
                veterinar = group.Key,
                broj = group.Count()
            });

            foreach (var item in brojNeobavljenihKontrola)
            {
                foreach (Veterinar veterinar in listaVeterinara)
                {
                    if (veterinar.ID_veterinar == item.veterinar)
                    {
                        this.uiGraf.Series["Neobavljene kontrole"].Points.AddXY(veterinar.ime + " " + veterinar.prezime, item.broj);
                        break;
                    }
                }
            }
        }

        private void PrikaziCijepljenjaPoVrsti()
        {
            this.uiGraf.Series.Clear();
            this.uiGraf.Series.Add("Broj cjepljenja");
            this.uiGraf.Series["Broj cjepljenja"].Color = Color.Purple;

            List<Kontrola> listaKontrola = null;
            List<Zivotinja> listaZivotinja = null;
            List<Zivotinja> pravaLista = new List<Zivotinja>();
            using (var db = new MazaEntities())
            {
                listaKontrola = db.Kontrola.ToList();
                listaZivotinja = db.Zivotinja.ToList();

                foreach (Kontrola kontrola in listaKontrola)
                {
                    if(kontrola.Cjepivo != null)
                    {
                        pravaLista.Add(listaZivotinja.Where(s => s.ID_zivotinja == kontrola.ID_zivotinja).FirstOrDefault());
                    }
                }
            }

            var brojCjepljenja = pravaLista.GroupBy(n => n.vrsta).Select(group => new
            {
                vrsta = group.Key,
                broj = group.Count()
            });

            foreach (var item in brojCjepljenja)
            {
                this.uiGraf.Series["Broj cjepljenja"].Points.AddXY(item.vrsta, item.broj);
            }
        }

        private void PrikaziNajcesceBolesti()
        {
            this.uiGraf.Series.Clear();
            this.uiGraf.Series.Add("Broj pojavljivanja bolesti");
            this.uiGraf.Series["Broj pojavljivanja bolesti"].Color = Color.Purple;
            this.uiGraf.Series["Broj pojavljivanja bolesti"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            List<Dijagnoza> listaDijagnoza = null;
            List<Bolest> listaBolesti = null;

            using (var db = new MazaEntities())
            {
                listaBolesti = db.Bolest.ToList();
                listaDijagnoza = db.Dijagnoza.ToList();
            }

            var brojBolesti = listaDijagnoza.GroupBy(n => n.ID_bolest).Select(group => new
            {
                bolest = group.Key,
                broj = group.Count()
            });

            foreach (var item in brojBolesti)
            {
                foreach (Bolest bolest in listaBolesti)
                {
                    if(bolest.ID_bolest == item.bolest)
                    {
                        this.uiGraf.Series["Broj pojavljivanja bolesti"].Points.AddXY(bolest.naziv, item.broj);
                        break;
                    }
                }
            }
        }

        private void frmStatistike_Load(object sender, EventArgs e)
        {
            PrikaziVrsteZivotinja();
        }

        private void uiActionPrikaziKontrole_Click(object sender, EventArgs e)
        {
            PrikaziKontrole();
        }

        private void uiPrikaziCijepljenja_Click(object sender, EventArgs e)
        {
            PrikaziCijepljenjaPoVrsti();
        }

        private void uiActionNajcesceBolesti_Click(object sender, EventArgs e)
        {
            PrikaziNajcesceBolesti();
        }
    }
}
