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
    public partial class DodajZivotinjuForm : Form
    {
        public DodajZivotinjuForm()
        {
            InitializeComponent();
            uiOdabirSpola.Items.Add("m");
            uiOdabirSpola.Items.Add("ž");
        }

        private void DodajZivotinjuForm_Load(object sender, EventArgs e)
        {
            using (var db = new MazaEntities())
            {
                //uiOdabirVlasnika.DataSource = db.Vlasnik.ToList();
                //uiOdabirVlasnika.DisplayMember = "Ime";
                //uiOdabirVlasnika.ValueMember = "IdVlasnik";

                //ui
            }
        }
    }
}
