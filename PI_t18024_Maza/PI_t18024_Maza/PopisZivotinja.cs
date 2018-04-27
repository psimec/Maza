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
    public partial class PopisZivotinja : Form
    {
        public PopisZivotinja()
        {
            InitializeComponent();

            uiTablicaZivotinja.Rows.Add("Pas","Njemački ovčar","Ivo Ivić", "Floki", "M", "22.1.2011", "10101010", "14");
            uiTablicaZivotinja.Rows.Add("Mačka","Ruska modra mačka", "Marijan Đurić", "Luna", "Ž", "22.10.2014", "201010", "4");
            uiTablicaZivotinja.Rows.Add("Pas","Pekinezer", "Marko Marić", "Đuro", "M", "22.1.2011", "10101110", "47");
            uiTablicaZivotinja.Rows.Add("Zec","Zec", "Luka Lukić", "Pero", "Ž", "21.4.2017", "1010221", "9");
            uiTablicaZivotinja.Rows.Add("Papiga","Nimfa", "Petra Petrić", "Ivek", "M", "22.1.2011", null, "2");

            DataGridViewComboBoxColumn godinaRodenja = new DataGridViewComboBoxColumn();
            godinaRodenja.HeaderText = "Godina rođenja";
            godinaRodenja.Name = "datumRodenja";
            int trenutnaGodina = int.Parse(DateTime.Today.Year.ToString());
            for(int i=1900; i <= trenutnaGodina; i++)
            {
                godinaRodenja.Items.Add(i);
            }
            uiTablicaZivotinja.Columns.Add(godinaRodenja);
            this.uiTablicaZivotinja.MultiSelect = false;

        }

        private void uiActionPopisVlasnika_Click(object sender, EventArgs e)
        {
            Form vlasnici = new Vlasnici();
            this.Hide();
            vlasnici.ShowDialog();
            this.Close();
        }
    }
}
