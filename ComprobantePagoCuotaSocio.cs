using iTextSharp.text;
using iTextSharp.text.pdf;
using Proyecto_Integrador_Grupo_11_B.Class;
using System.Diagnostics;

namespace Proyecto_Integrador_Grupo_11_B
{
    public partial class ComprobantePagoCuotaSocio : Form
    {
        private ComprobanteDePagoCuotaSocio _comprobante;

        //  Constructor: recibe el comprobante con los datos del socio y cuotas
        public ComprobantePagoCuotaSocio(ComprobanteDePagoCuotaSocio comprobante)
        {
            InitializeComponent();
            _comprobante = comprobante;

            // Agregar manualmente el evento Load
            this.Load += ComprobantePagoCuotaSocio_Load;
        }

        //  Evento Load del formulario
        private void ComprobantePagoCuotaSocio_Load(object sender, EventArgs e)
        {
            LblNroSocio.Text = _comprobante.idSocio.ToString();
            LblNombre.Text = _comprobante.Nombre;
            LblApellido.Text = _comprobante.Apellido;
            LblDni.Text = _comprobante.Dni;
            LblMetodoPago.Text = _comprobante.MedioDePago.ToString();
            LblFechaPago.Text = _comprobante.Fecha.ToShortDateString();
            LblMontoTotal.Text = "$" + _comprobante.Precio.ToString();
            LblCuotaTarjeta.Text = _comprobante.CantCuotasFinanciada.ToString();
            LblCuotaAbonada.Text = _comprobante.CantCuotasPagadas.ToString();

            panelComprobanteCompleto.Dock = DockStyle.Fill;
            panelComprobanteCompleto.BackColor = Color.White;
            panelComprobanteCompleto.Invalidate();

        }

        private void Imprimir_Click(object sender, EventArgs e)
        {
            GenerarPDF();
        }

        private void GenerarPDF()
        {
            try
            {
                // Capturar todo el formulario (this).
                Bitmap bmp = new Bitmap(panelComprobanteCompleto.Width, panelComprobanteCompleto.Height);
                panelComprobanteCompleto.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, panelComprobanteCompleto.Width, panelComprobanteCompleto.Height));

                //  Convertir la imagen a un MemoryStream.
                using (MemoryStream ms = new MemoryStream())
                {
                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(ms.ToArray());

                    // Crear documento PDF.
                    Document doc = new Document(PageSize.A4, 50, 50, 25, 25);
                    string ruta = Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                        $"Comprobante_{_comprobante.Nombre}_{DateTime.Now:yyyyMMdd_HHmm}.pdf"
                    );

                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(ruta, FileMode.Create));
                    doc.Open();

                    // Ajustar la imagen al tamaño de página.
                    float pageWidth = doc.PageSize.Width - doc.LeftMargin - doc.RightMargin;
                    float pageHeight = doc.PageSize.Height - doc.TopMargin - doc.BottomMargin;

                    imagen.ScaleToFit(pageWidth, pageHeight);
                    imagen.Alignment = Element.ALIGN_CENTER;

                    // Agregar imagen al PDF.
                    doc.Add(imagen);

                    doc.Close();
                    writer.Close();

                    // Abrir PDF automáticamente.
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

        private void panelComprobanteCompleto_Paint(object sender, PaintEventArgs e)
        {
            // Elegí el color y grosor del borde.
            using (Pen pen = new Pen(Color.Black, 2))
            {
                // Dibujamos el rectángulo del borde (ajustamos 1px para que no se corte).
                e.Graphics.DrawRectangle(pen, 0, 0, panelComprobanteCompleto.Width - 1, panelComprobanteCompleto.Height - 1);
            }
        }

        private void VolverMenu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                 "¿Seguro que deseas volver?",
                 "Confirmar salida",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
