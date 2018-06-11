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
    public partial class Dizajn : Form
    {
        public Dizajn()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void uiActionKalendar_Click(object sender, EventArgs e)
        {            
            Kalendar kalendar = new Kalendar();
            this.Hide();           
            kalendar.StartPosition = FormStartPosition.CenterScreen;
            kalendar.ShowDialog();
            this.Close();
        }

        private void uiActionZivotinje_Click(object sender, EventArgs e)
        {
            Zivotinje zivotinja = new Zivotinje();
            this.Hide();
            zivotinja.StartPosition = FormStartPosition.CenterScreen;
            zivotinja.ShowDialog();
            this.Close();
        }

        private void uiActionVlasnici_Click(object sender, EventArgs e)
        {
            Vlasnici vlasnici = new Vlasnici();
            this.Hide();
            vlasnici.StartPosition = FormStartPosition.CenterParent;
            vlasnici.ShowDialog();
            this.Close();
            
        }

        private void uiActionKontrola_Click(object sender, EventArgs e)
        {
            KontrolaForm kontrola = new KontrolaForm(); // krivo ime forme
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
    }
}
