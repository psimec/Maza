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
            BindingList<Vlasnik> listaVlasnika = null;
            using (var db = new MazaEntities())
            {
                listaVlasnika = new BindingList<Vlasnik>(db.Vlasnik.ToList());
            }
            uiPrikazVlasnika.DataSource = listaVlasnika;
        }

        public void PrikaziZivotinje(Vlasnik vlasnik)
        {
            BindingList<Zivotinje> listaZivotinja = null;
            
        }

        private void Zivotinje_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_18024_DBDataSet.zivotinja' table. You can move, or remove it, as needed.
            this.zivotinjaTableAdapter.Fill(this._18024_DBDataSet.zivotinja);
            // TODO: This line of code loads data into the '_18024_DBDataSet.vlasnik' table. You can move, or remove it, as needed.
            this.vlasnikTableAdapter.Fill(this._18024_DBDataSet.vlasnik);
            PrikaziVlasnike();
        }
    }
}
