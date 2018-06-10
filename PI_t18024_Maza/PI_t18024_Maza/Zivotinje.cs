using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PI_t18024_Maza
{
    public partial class Zivotinje : Dizajn
    {
        public Zivotinje()
        {
            InitializeComponent();
        }

        public void PrikaziVlasnike()
        {
            BindingList<Vlasnik> listaVlasnike = null;
            using (var db = new MazaEntities())
            {
                listaVlasnike = new BindingList<Vlasnik>(db.Vlasnik.ToList());
            }
            vlasnikBindingSource.DataSource = listaVlasnike;
        }

        private void Zivotinje_Load(object sender, EventArgs e)
        {
            PrikaziVlasnike();
        }
    }
}
