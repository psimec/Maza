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

            dataGridView1.Rows.Add("Pas","Njemački ovčar","Ivo Ivić", "Floki", "M", "22.1.2011", "10101010", "14");
            dataGridView1.Rows.Add("Mačka","Ruska modra mačka", "Marijan Đurić", "Luna", "Ž", "22.10.2014", "201010", "4");
            dataGridView1.Rows.Add("Pas","Pekinezer", "Marko Marić", "Đuro", "M", "22.1.2011", "10101110", "47");
            dataGridView1.Rows.Add("Zec","Zec", "Luka Lukić", "Pero", "Ž", "21.4.2017", "1010221", "9");
            dataGridView1.Rows.Add("Papiga","Nimfa", "Petra Petrić", "Ivek", "M", "22.1.2011", null, "2");

            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;

        }

    }
}
