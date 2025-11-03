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
        private ComprobanteDePagoActividad comprobante;
        public FrmComprobantePago(ComprobanteDePagoActividad comprobante)
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
            lblFecha.Text = comprobante.Fecha.ToString("dd/MM/yyyy");
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
                // ✅ 1. Capturar todo el formulario (this)
                Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);
                panel1.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, panel1.Width, panel1.Height));

                // ✅ 2. Convertir la imagen a un MemoryStream
                using (MemoryStream ms = new MemoryStream())
                {
                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(ms.ToArray());

                    // ✅ 3. Crear documento PDF
                    Document doc = new Document(PageSize.A4, 50, 50, 25, 25);
                    string ruta = Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                        $"Comprobante_{comprobante.Nombre}_{DateTime.Now:yyyyMMdd_HHmm}.pdf"
                    );

                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(ruta, FileMode.Create));
                    doc.Open();

                    // ✅ 4. Ajustar la imagen al tamaño de página
                    float pageWidth = doc.PageSize.Width - doc.LeftMargin - doc.RightMargin;
                    float pageHeight = doc.PageSize.Height - doc.TopMargin - doc.BottomMargin;

                    imagen.ScaleToFit(pageWidth, pageHeight);
                    imagen.Alignment = Element.ALIGN_CENTER;

                    // ✅ 5. Agregar imagen al PDF
                    doc.Add(imagen);

                    doc.Close();
                    writer.Close();

                    // ✅ 6. Abrir PDF automáticamente
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = ruta,
                        UseShellExecute = true
                    });

                    MessageBox.Show($"Comprobante generado con éxito en:\n{ruta}",
                                    "PDF generado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF: " + ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Elegí el color y grosor del borde
            using (Pen pen = new Pen(Color.Black, 2))
            {
                // Dibujamos el rectángulo del borde (ajustamos 1px para que no se corte)
                e.Graphics.DrawRectangle(pen, 0, 0, panel1.Width - 1, panel1.Height - 1);
            }
        }

    }
}
