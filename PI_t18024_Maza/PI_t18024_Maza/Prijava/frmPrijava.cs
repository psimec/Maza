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
using Kriptografija;

namespace PI_t18024_Maza
{
    public partial class frmPrijava : Form
    {
        #region Globalne Varijable

        Veterinar veterinar;

        #endregion

        #region Konstruktor
        
        /// <summary>
        /// Konstruktor forme Prijava
        /// </summary>

        public frmPrijava()
        {
            InitializeComponent();
            veterinar = null;
            uiUnosLozinke.UseSystemPasswordChar = true;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        #endregion

        #region Funkcije

        /// <summary>
        /// Provjera valjanost unesnih podataka
        /// </summary>

        private void Autentifikacija()
        {
            try
            {
                if (uiUnosKorisnickogImena.Text != "" || uiUnosLozinke.Text != "")
                {
                    DohvatiPodatke();
                    if (veterinar != null)
                    {
                        if (Kriptiranje.usporediMD5(uiUnosLozinke.Text , veterinar.lozinka))
                        {

                            PrijavljeniVeterinar.PrijaviVeterinara(veterinar);
                            frmKalendar kalendar = new frmKalendar();
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

        /// <summary>
        /// Provjera postoji li uneseni podaci u bazi
        /// </summary>

        private void DohvatiPodatke()
        {
            // Provjera internet veze
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

        #endregion

        #region Dogadaji

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

            if (e.KeyCode == Keys.F1)
            {
                MessageBox.Show("hhh");
            }
        }

        private void uiUnosKorisnickogImena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Autentifikacija();
            }

            if (e.KeyCode == Keys.F1)
            {
                MessageBox.Show("hhh");
            }
        }


        #endregion
    }
}
