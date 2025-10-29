using iTextSharp.text;
using iTextSharp.text.pdf;
using Proyecto_Integrador_Grupo_11_B.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Integrador_Grupo_11_B
{
    public partial class FrmComprobantePago : Form
    {
        private ComprobanteDePago comprobante;
        public FrmComprobantePago(ComprobanteDePago comprobante)
        {
            InitializeComponent();
            this.comprobante = comprobante;
            this.Load += FrmComprobantePago_Load;
        }

        private void FrmComprobantePago_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Comprobante de Pago";
            lblIdNoSocio.Text = comprobante.IdNoSocio;
            lblNombre.Text = comprobante.Nombre;
            lblApellido.Text = comprobante.Apellido;
            lblActividad.Text = comprobante.Actividad;
            lblPrecio.Text = comprobante.Precio.ToString("C2"); // formato monetario
            lblMedioDePago.Text = comprobante.MedioDePago;
            lblFecha.Text = comprobante.Fecha.ToString("dd/MM/yyyy HH:mm");
        }

        private void btnCerrarComprobante_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            GenerarPDF();
        }

        private void GenerarPDF()
        {
            try
            {
                // 📄 1. Crear documento
                Document doc = new Document(PageSize.A4, 50, 50, 25, 25);

                // 📁 2. Definir ruta donde guardar (en el escritorio)
                string ruta = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                    $"Comprobante_{comprobante.Nombre}_{DateTime.Now:yyyyMMdd_HHmm}.pdf"
                );

                // 🖋️ 3. Crear escritor de PDF
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(ruta, FileMode.Create));

                doc.Open();

                iTextSharp.text.Font tituloFont = FontFactory.GetFont("Helvetica", 18, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font despedidaFont = FontFactory.GetFont("Helvetica", 12, iTextSharp.text.Font.ITALIC);

                // 🧾 4. Agregar contenido
                var titulo = new Paragraph("Comprobante de Pago", tituloFont);
                titulo.Alignment = Element.ALIGN_CENTER;
                doc.Add(titulo);
                doc.Add(new Paragraph("\n"));

                // Datos del comprobante
                doc.Add(new Paragraph($"Nombre: {comprobante.Nombre}"));
                doc.Add(new Paragraph($"Apellido: {comprobante.Apellido}"));
                doc.Add(new Paragraph($"Actividad: {comprobante.Actividad}"));
                doc.Add(new Paragraph($"Precio: ${comprobante.Precio:0.00}"));
                doc.Add(new Paragraph($"Medio de Pago: {comprobante.MedioDePago}"));
                doc.Add(new Paragraph($"Fecha: {comprobante.Fecha:dd/MM/yyyy HH:mm}"));

                doc.Add(new Paragraph("\n\n"));
                doc.Add(new Paragraph("Gracias por su participación.", despedidaFont));

                // 📘 5. Cerrar documento
                doc.Close();
                writer.Close();

                Process.Start(new ProcessStartInfo
                {
                    FileName = ruta,
                    UseShellExecute = true // importante para abrir con la aplicación predeterminada
                });

                MessageBox.Show($"Comprobante generado con éxito en:\n{ruta}", "PDF generado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF: " + ex.Message);
            }
        }
    }
}
