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
    public partial class Kalendar : Form
    {
        public Kalendar()
        {
            InitializeComponent();
        }

        private void uiActionOdjava_Click(object sender, EventArgs e)
        {
            Form prijava = new Prijava();
            this.Hide();
            prijava.ShowDialog();
            this.Close();
        }

        private void uiActionOdabirDatuma_ValueChanged(object sender, EventArgs e)
        {
            DateTime datum = uiActionOdabirDatuma.Value;
            DayOfWeek danUTjednu = datum.DayOfWeek; // dan u tjednu se koristi kako bi se znalo pod koji dan se dodaje aktivnost
            int brojDanaUMjesecu = DateTime.DaysInMonth(datum.Year, datum.Month);
            int brojTjednaUMjesecu = (datum.Day + (7 - (int)datum.DayOfWeek)) / 7;

            string test = "";

            for (int i = (brojTjednaUMjesecu * 7) - 7; i < brojTjednaUMjesecu * 7; i++)
            {
                if (i <= brojTjednaUMjesecu)
                {
                    test += i + " ";
                }
                else
                {

                }
            }
            MessageBox.Show(test);

        }
    }
}
