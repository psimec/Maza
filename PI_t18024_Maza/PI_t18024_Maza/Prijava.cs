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
        Veterinar veterinar;
        private static string privatniKljuc = "7BDHFJ54";

        public Prijava()
        {
            InitializeComponent();
            veterinar = null;
            uiUnosLozinke.UseSystemPasswordChar = true;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Autentifikacija()
        {
            try
            {
                if (uiUnosKorisnickogImena.Text != "" || uiUnosLozinke.Text != "")
                {
                    dohvatiPodatke();
                    if (veterinar != null)
                    {
                        if (usporediMD5(uiUnosLozinke.Text + privatniKljuc, veterinar.lozinka))
                        {
                            Kalendar kalendar = new Kalendar();
                            this.Hide();
                            kalendar.StartPosition = FormStartPosition.CenterScreen;
                            kalendar.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Loznika nije točna");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Korisnicko ime nije točno");
                    }
                }
                else
                {
                    uiUnosKorisnickogImena.BackColor = Color.IndianRed;
                    uiUnosLozinke.BackColor = Color.IndianRed;
                }
            }
            catch (ExceptionNemaInterneta ex)
            {
                MessageBox.Show(ex.Poruka);
            }
        }

        private void dohvatiPodatke()
        {
            if (!(NetworkInterface.GetIsNetworkAvailable()))
            {
                throw new ExceptionNemaInterneta("Aplikacija zahtjeva stabilnu internet konekciju");
            }
            else
            {
                using (var db = new MazaEntities())
                {
                    veterinar = db.Veterinar.Where(v => v.korime == uiUnosKorisnickogImena.Text).FirstOrDefault();              
                }
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
            Autentifikacija();
        }

        private void uiActionOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uiUnosLozinke_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Autentifikacija();
            }
        }

        private void uiUnosKorisnickogImena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Autentifikacija();
            }
        }
    }
}
