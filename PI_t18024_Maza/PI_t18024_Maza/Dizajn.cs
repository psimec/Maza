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
        }

        private void uiActionKalendar_Click(object sender, EventArgs e)
        {            
            Kalendar kalendar = new Kalendar();
            this.Hide();
            kalendar.ShowDialog();
            this.Close();
        }

        private void uiActionZivotinje_Click(object sender, EventArgs e)
        {
            Zivotinje zivotinja = new Zivotinje();
            this.Hide();
            zivotinja.ShowDialog();
            this.Close();
        }

        private void uiActionVlasnici_Click(object sender, EventArgs e)
        {
        }

        private void uiActionKontrola_Click(object sender, EventArgs e)
        {
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
