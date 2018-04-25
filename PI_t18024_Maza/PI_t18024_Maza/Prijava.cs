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
            uiUnosLozinke.UseSystemPasswordChar = true;
        }

        private void uiActionOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uiActionPrijava_Click(object sender, EventArgs e)
        {
            string korime = uiUnosKorisnickogImena.Text;
            string lozinka = uiUnosLozinke.Text;


            if (korime != "" || lozinka != "")
            {
                // dohvati korisnicko ime iz baze, ako ne postoji vrati gresku
                // dohvati lozinku za korisnicko ime u bazi podataka;
                string bazaLozinka = "testloz"; 

                if (lozinka == bazaLozinka)
                {
                    Form glavnaForma = new Form1();
                    this.Hide();
                    glavnaForma.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lozinka nije točna");
                }
            }


        }
    }
}
