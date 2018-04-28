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
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace PI_t18024_Maza
{
    public partial class ExportPDF : Form
    {
        Document doc = new Document(PageSize.A4);

        public ExportPDF()
        {
            InitializeComponent();
        }
        
        private void formirajPDF() //privremena funckija za kreiranje PDF-a, samo za testiranje
        {
            PdfWriter.GetInstance(doc, new FileStream("Test.pdf", FileMode.Create));
            doc.Open();
            iTextSharp.text.Font naslovFont = FontFactory.GetFont("Times New Roman", 32);
            iTextSharp.text.Font sadrzajFont = FontFactory.GetFont("Times New Roman", 14);
            Paragraph naslov = new Paragraph("Naslov" + Chunk.NEWLINE, naslovFont); // naslov postaviti na ime životinje
            naslov.Alignment = Element.ALIGN_CENTER;
            doc.Add(naslov);
            Chunk dioTeksta = new Chunk("Tekst koji je potrebno prikazati" + Chunk.NEWLINE, sadrzajFont); // iz baze se dohvacaju podaci 
            for (int i = 0; i < 10; i++)
            {
                doc.Add(dioTeksta);
            }
            doc.Close();
        }

        private void uiActionSpremiPDF_Click(object sender, EventArgs e)
        {
            formirajPDF();
        }

        private void uiActionPrikaziPDF_Click(object sender, EventArgs e)
        {
            formirajPDF();
            System.Diagnostics.Process.Start("Test.pdf");
            System.Threading.Thread.Sleep(10000); // privremeno rijesenje kod brisanja prikazanog pdf-a
            File.Delete("Test.pdf");
            doc = new Document(PageSize.A4);
        }
    }

}
