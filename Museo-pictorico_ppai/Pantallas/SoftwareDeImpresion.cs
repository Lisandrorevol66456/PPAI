using iTextSharp.text;
using iTextSharp.text.pdf;
using Museo_pictorico_ppai.Modelos;
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

namespace Museo_pictorico_ppai.Pantallas
{
    public partial class SoftwareDeImpresion : Form
    {
        public SoftwareDeImpresion()
        {
            InitializeComponent();
        }

        private void SoftwareDeImpresion_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }
        public void imprimir(Entrada entrada) // genera pdf con los datos de la entrada vendida y lo guarda en la ruta elegida
        {
            FileStream fs = new FileStream(@"C:\Users\Windows 10\Desktop\Entradas impresas\" + DateTime.Now.Ticks.ToString() + ".pdf", FileMode.Create);
            Document doc = new Document(PageSize.LETTER, 5, 5, 7, 7);
            PdfWriter pw = PdfWriter.GetInstance(doc, fs);
            doc.Open();
            doc.AddAuthor("Museo");
            doc.AddTitle("Entrada");

            iTextSharp.text.Font standarFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 11, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            doc.Add(new Paragraph("Entrada a Museo"));
            doc.Add(Chunk.NEWLINE);
            PdfPTable tblEntrada = new PdfPTable(5);
            tblEntrada.WidthPercentage = 100;

            PdfPCell clIdEntrada = new PdfPCell(new Phrase("Numero de entrada", standarFont));
            clIdEntrada.BorderWidth = 0;
            clIdEntrada.BorderWidthBottom = 0.75f;

            PdfPCell clFechahora = new PdfPCell(new Phrase("Fecha y hora", standarFont));
            clFechahora.BorderWidth = 0;
            clFechahora.BorderWidthBottom = 0.75f;

            PdfPCell clMonto = new PdfPCell(new Phrase("Monto", standarFont));
            clMonto.BorderWidth = 0;
            clMonto.BorderWidthBottom = 0.75f;

            PdfPCell clTarifa = new PdfPCell(new Phrase("Numero de tarifa", standarFont));
            clTarifa.BorderWidth = 0;
            clTarifa.BorderWidthBottom = 0.75f;

            PdfPCell ClSede = new PdfPCell(new Phrase("Numero de Sede", standarFont));
            clIdEntrada.BorderWidth = 0;
            clIdEntrada.BorderWidthBottom = 0.75f;

            tblEntrada.AddCell(clIdEntrada);
            tblEntrada.AddCell(clFechahora);
            tblEntrada.AddCell(clMonto);
            tblEntrada.AddCell(clTarifa);
            tblEntrada.AddCell(ClSede);
            if (entrada != null)
            {
                clIdEntrada = new PdfPCell(new Phrase(entrada.nroEntrada.ToString()));
                clIdEntrada.BorderWidth = 0;
                clFechahora = new PdfPCell(new Phrase(entrada.fechaHoraVenta.ToString()));
                clFechahora.BorderWidth = 0;
                clMonto = new PdfPCell(new Phrase(entrada.monto.ToString()));
                clMonto.BorderWidth = 0;
                clTarifa = new PdfPCell(new Phrase(entrada.tarifa.ToString()));
                clTarifa.BorderWidth = 0;
                ClSede = new PdfPCell(new Phrase(entrada.idSede.ToString()));
                ClSede.BorderWidth = 0;

                tblEntrada.AddCell(clIdEntrada);
                tblEntrada.AddCell(clFechahora);
                tblEntrada.AddCell(clMonto);
                tblEntrada.AddCell(clTarifa);
                tblEntrada.AddCell(ClSede);

            }
            doc.Add(tblEntrada);
            doc.Close();
            pw.Close();

        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
