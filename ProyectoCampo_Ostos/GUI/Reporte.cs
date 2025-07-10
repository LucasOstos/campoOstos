using BE;
using SERVICIOS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace GUI
{
    public class Reporte
    {
        public void GenerarFactura(DataGridView dgv, string rutaPdf, string rutaImagen, Factura f)
        {
            Document doc = new Document(PageSize.A4);
            PdfWriter.GetInstance(doc, new FileStream(rutaPdf, FileMode.Create));
            doc.Open();

            // Logo (si existe)
            if (File.Exists(rutaImagen))
            {
                Image logo = Image.GetInstance(rutaImagen);
                logo.ScaleAbsolute(100, 100);
                logo.Alignment = Element.ALIGN_RIGHT;
                doc.Add(logo);
            }

            // Nombre empresa
            Paragraph nombre = new Paragraph("BELLEZA ARGENTINA", FontFactory.GetFont(FontFactory.HELVETICA, 18));
            nombre.Alignment = Element.ALIGN_RIGHT;
            doc.Add(nombre);

            // Numero de factura
            Paragraph titulo = new Paragraph($"FACTURA N°: {f.NumFactura}\n\n", FontFactory.GetFont(FontFactory.HELVETICA, 18));
            titulo.Alignment = Element.ALIGN_LEFT;
            doc.Add(titulo);

            // Fecha
            Paragraph parrafoFecha = new Paragraph($"Fecha de Emisión: {f.FechaEmision}\n\n", FontFactory.GetFont(FontFactory.HELVETICA, 10));
            parrafoFecha.Alignment = Element.ALIGN_RIGHT;
            doc.Add(parrafoFecha);

            // Datos del cliente
            doc.Add(new Paragraph($"DNI: {f.facturaCliente.DNI}\nNombre: {f.facturaCliente.Nombre}\nApellido: {f.facturaCliente.Apellido}\nCelular: {f.facturaCliente.Celular}\nEmail: {Encriptado.InstanceEncriptado.DesencriptacionReversible(f.facturaCliente.Email)}\n\n", FontFactory.GetFont(FontFactory.HELVETICA, 12)));

            // Tabla (a partir del dgv)
            PdfPTable tabla = new PdfPTable(dgv.Columns.Count);
            tabla.WidthPercentage = 100;

            // Encabezados
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                PdfPCell celda = new PdfPCell(new Phrase(col.HeaderText, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10)));
                celda.BackgroundColor = new BaseColor(220, 220, 220);
                tabla.AddCell(celda);
            }

            // Filas
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        tabla.AddCell(cell.Value?.ToString() ?? "");
                    }
                }
            }

            doc.Add(tabla);

            doc.Close();
        }
    }
}