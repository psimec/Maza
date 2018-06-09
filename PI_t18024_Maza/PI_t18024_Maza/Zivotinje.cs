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
            using(var db = new MazaEntities())
            {
                test = new BindingList<Bolest>(db.Bolest.ToList());
            }
            dataGridView1.DataSource = test;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new MazaEntities())
            {
                Bolest test = new Bolest
                {
                    Naziv = textBox1.Text
                };
                db.Bolest.Add(test);
                db.SaveChanges();
            }
            Test();
            
        }
    }
}
