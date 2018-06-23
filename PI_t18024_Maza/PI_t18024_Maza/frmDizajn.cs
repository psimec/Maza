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
    public partial class frmDizajn : Form
    {
        public frmDizajn()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            PrikaziPrijavljenogVeterinara();
        }

        private void PrikaziPrijavljenogVeterinara()
        {
            if (PrijavljeniVeterinar.Veterinar != null)
            {
                uiPrikazPrijavljenogVeterinara.Text = PrijavljeniVeterinar.Veterinar.korime;
            }
            else
            {
                uiPrikazPrijavljenogVeterinara.Text = "";
            }
        }

        private void uiActionKalendar_Click(object sender, EventArgs e)
        {            
            frmKalendar kalendar = new frmKalendar();
            this.Hide();           
            kalendar.StartPosition = FormStartPosition.CenterScreen;
            kalendar.ShowDialog();
            this.Close();
        }

        private void uiActionZivotinje_Click(object sender, EventArgs e)
        {
            frmZivotinje zivotinja = new frmZivotinje();
            this.Hide();
            zivotinja.StartPosition = FormStartPosition.CenterScreen;
            zivotinja.ShowDialog();
            this.Close();
        }

        private void uiActionVlasnici_Click(object sender, EventArgs e)
        {
            frmVlasnici vlasnici = new frmVlasnici();
            this.Hide();
            vlasnici.StartPosition = FormStartPosition.CenterParent;
            vlasnici.ShowDialog();
            this.Close();
            
        }

        private void uiActionKontrola_Click(object sender, EventArgs e)
        {
            frmKontrola kontrola = new frmKontrola(); 
            this.Hide();
            kontrola.StartPosition = FormStartPosition.CenterScreen;
            kontrola.ShowDialog();
            this.Close();
        }

        private void uiActionClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uiActionMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void uiActionOdjava_Click(object sender, EventArgs e)
        {
            Form prijava = new frmPrijava();
            this.Hide();
            prijava.ShowDialog();
            this.Close();            
        }

        private void uiActionStatistika_Click(object sender, EventArgs e)
        {
            frmStatistike statistike = new frmStatistike();
            this.Hide();
            statistike.StartPosition = FormStartPosition.CenterScreen;
            statistike.ShowDialog();
            this.Close();
        }
    }
}
