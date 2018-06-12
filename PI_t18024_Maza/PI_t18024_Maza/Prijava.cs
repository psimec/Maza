using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace PI_t18024_Maza
{
    public partial class Prijava : Form
    {

        public Prijava()
        {
            InitializeComponent();
            uiUnosLozinke.UseSystemPasswordChar = true;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void prijava()
        {
            string korime = uiUnosKorisnickogImena.Text;
            string lozinka = uiUnosLozinke.Text;

            try
            {
                dohvatiPodaatke();
            }
            catch (ExceptionNemaInterneta ex)
            {
                MessageBox.Show(ex.Poruka);
            }

            if (korime != "" || lozinka != "")
            {
                // dohvati korisnicko ime iz baze, ako ne postoji vrati gresku
                // dohvati lozinku za korisnicko ime u bazi podataka;
                string bazaLozinka = "testloz";

                if (lozinka == bazaLozinka)
                {
                    Form glavnaForma = new Kalendar();
                    this.Hide();
                    glavnaForma.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lozinka nije točna");
                }
            }
            else
            {
                uiUnosKorisnickogImena.BackColor = Color.IndianRed;
                uiUnosLozinke.BackColor = Color.IndianRed;
            }
        }

        private void dohvatiPodaatke()
        {
            if (!(NetworkInterface.GetIsNetworkAvailable()))
            {
                throw new ExceptionNemaInterneta("Aplikacija zahtjeva stabilnu internet konekciju");
            }
            else
            {
                // code
            }
        }

        private string kriptirajMD5(string input)
        {
            MD5 md5 = MD5.Create();
            byte[] podaci = ASCIIEncoding.UTF8.GetBytes(input);
            byte[] hash = md5.ComputeHash(podaci);
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                stringBuilder.Append(hash[i].ToString("x2"));
            }

            return stringBuilder.ToString();
        }

        private bool usporediMD5(string rijec, string hash)
        {
            string rijecHash = kriptirajMD5(rijec);
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;

            if (stringComparer.Compare(rijecHash, hash) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void uiUnosKorisnickogImena_TextChanged(object sender, EventArgs e)
        {
            uiUnosKorisnickogImena.BackColor = Color.White;
        }

        private void uiUnosLozinke_TextChanged(object sender, EventArgs e)
        {
            uiUnosLozinke.BackColor = Color.White;
        }

        private void uiActionPrijava_Click(object sender, EventArgs e)
        {
            prijava();
        }

        private void uiActionOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uiUnosLozinke_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                prijava();
            }
        }

        private void uiUnosKorisnickogImena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                prijava();
            }
        }
    }
}
