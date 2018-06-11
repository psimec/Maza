using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_t18024_Maza
{
    public partial class PovijestBolesti : Form
    {
        private int idZivotinja;

        public PovijestBolesti(int idZivotinja)
        {
            InitializeComponent();
            this.idZivotinja = idZivotinja;
        }

        private void povijestBolesti_Load(object sender, EventArgs e)
        {
            _18024_DBDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the '_18024_DBDataSet.Lijek' table. You can move, or remove it, as needed.
            this.LijekTableAdapter.FillByZivotnijaId(this._18024_DBDataSet.Lijek, idZivotinja);
            // TODO: This line of code loads data into the '_18024_DBDataSet.bolest' table. You can move, or remove it, as needed.
            this.bolestTableAdapter.FillByZivotinjaId(this._18024_DBDataSet.bolest, 3);
            // TODO: This line of code loads data into the '_18024_DBDataSet.dijagnoza' table. You can move, or remove it, as needed.
            this.dijagnozaTableAdapter.FillByZivotinjaId(this._18024_DBDataSet.dijagnoza, idZivotinja);
            // TODO: This line of code loads data into the '_18024_DBDataSet.vlasnik' table. You can move, or remove it, as needed.
            this.vlasnikTableAdapter.FillByZivotinjaId(this._18024_DBDataSet.vlasnik, idZivotinja);
            // TODO: This line of code loads data into the '_18024_DBDataSet.zivotinja' table. You can move, or remove it, as needed.
            this.zivotinjaTableAdapter.FillByZivotinjaId(this._18024_DBDataSet.zivotinja, idZivotinja);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e) // test
        {
            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string filenameExtension;

            byte[] bytes = reportViewer1.LocalReport.Render(
                "PDF", null, out mimeType, out encoding, out filenameExtension,
                out streamids, out warnings);

            using (FileStream fs = new FileStream("output.pdf", FileMode.Create))
            {
                fs.Write(bytes, 0, bytes.Length);
            }
        }
    }
}
