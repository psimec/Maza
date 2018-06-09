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
    public partial class Zivotinje : Form
    {
        public Zivotinje()
        {
            InitializeComponent();
            Test();
        }

        private void Test()
        {
            BindingList<Bolest> test = null;
            using(var db = new Entities())
            {
                test = new BindingList<Bolest>(db.bolests.ToList());
            }
            dataGridView1.DataSource = test;

        }
    }
}
