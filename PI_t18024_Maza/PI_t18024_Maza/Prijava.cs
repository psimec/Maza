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
    public partial class Prijava : Form
    {
        public Prijava()
        {
            InitializeComponent();
        }

        private void uiActionOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uiActionPrijava_Click(object sender, EventArgs e)
        {
            //ukoliko su uneseni podaci točni, izvrši

            Form glavnaForma = new Form1();
            this.Hide();
            glavnaForma.ShowDialog();
            this.Close();
        }
    }
}
