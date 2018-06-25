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

        private void frmStatistike_Load(object sender, EventArgs e)
        {
            PrikaziVrsteZivotinja();
        }

        private void uiActionPrikaziKontrole_Click(object sender, EventArgs e)
        {
            PrikaziKontrole();
        }
    }
}
