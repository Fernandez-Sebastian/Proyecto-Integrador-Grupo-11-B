using Proyecto_Integrador_Grupo_11_B.Class;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;

namespace Proyecto_Integrador_Grupo_11_B
{
    public partial class ImprimirCarnet : Form
    {
        private readonly Carnet carnetSocio;
        private readonly PrintDocument printDoc;
        private Bitmap? panelBitmap;

        public ImprimirCarnet(Carnet carnetSocio)
        {
            //inicializamos componentes del form
            InitializeComponent();
            //se setea carnetSocio con el carnet recibido
            this.carnetSocio = carnetSocio;

            //creamos un documento de impresión
            printDoc = new PrintDocument();

            //Asociamos el evento PrintPage al método que se encargará de dibujar
            //el carnet en la página (PrintDoc_PrintPage).
            //Este evento se ejecuta automáticamente cuando se llame a printDoc.Print().
            printDoc.PrintPage += PrintDoc_PrintPage;

            //asociamoss el evento Shown al método que se encargara de setear los valores
            //en el form al momento de mostrarse
            Shown += ImprimirCarnet_Shown;
        }

        /// <summary>
        /// Método para setear los valores en los controles del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImprimirCarnet_Shown(object? sender, EventArgs e)
        {
            // Se cargan los datos de la clase carnet
            lblNombreValor.Text = carnetSocio.Socio.Nombre;
            lblApellidoValor.Text = carnetSocio.Socio.Apellido;
            lblDniValor.Text = carnetSocio.Socio.Dni;
            lblFechaRegValor.Text = carnetSocio.FechaEmision.ToString("dd/MM/yyyy");
            lblFechaVtoValor.Text = carnetSocio.FechaVencimiento.ToString("dd/MM/yyyy");

            // Código de barras uso el DNI considero que es solo numérico porque ya llega validado y creo el código
            picBarcode.Image = RenderCode39Digits(carnetSocio.Socio.Dni, picBarcode.Width, picBarcode.Height, 2, 6);

            // Captura inicial del panel (lo que voy a imprimir)
            panelBitmap = ImprimirPanelCarnet(panelPreviewImprimir);
        }

        /// <summary>
        /// Método que cierra el form para volver al form anterior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VolverButton_Click(object? sender, EventArgs e) => Close();

        /// <summary>
        /// Método que realiza la impresión desde el botón Imprimir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImprimirButton_Click(object? sender, EventArgs e)
        {
            //refrescamos la captura del panel a imprimir
            panelBitmap = ImprimirPanelCarnet(panelPreviewImprimir);

            // Márgenes y orientación para impresión
            //definimos que sea vertical la impresión
            printDoc.DefaultPageSettings.Margins = new Margins(40, 40, 40, 40);
            printDoc.DefaultPageSettings.Landscape = false;

            // Verificamos si existe la impresora Microsoft Print to PDF
            string? pdfPrinter = PrinterSettings.InstalledPrinters
                .Cast<string>()
                .FirstOrDefault(p => p.IndexOf("Microsoft Print to PDF", StringComparison.OrdinalIgnoreCase) >= 0);

            // Si se encuentra Microsoft Print to PDF, se la selecciona para la impresión.
            if (pdfPrinter != null)
            {
                printDoc.PrinterSettings.PrinterName = pdfPrinter;
            }

            //Mostramos cuadro de diálogo de impresión al usuario.
            // Permite seleccionar la impresora, definir copias, etc.
            // Se asocia el 'printDoc' configurado al diálogo.
            PrintDialog print = new PrintDialog()
            {
                UseEXDialog = true,
                Document = printDoc
            };

            //Si el usuario confirma, ejecutamos la impresión
            if (print.ShowDialog(this) == DialogResult.OK)
            {
                printDoc.Print();
            }
        }

        /// <summary>
        /// Método de impresión que dibuja en la página el contenido visual del carnet
        /// Escala y centra la imagen del panel dentro de los márgenes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintDoc_PrintPage(object? sender, PrintPageEventArgs e)
        {
            //verificamos si no hay imagen del panel cargada, entonces termina la impresión
            if (panelBitmap == null)
            {
                // se setea en false para indicar que no hay más páginas a imprimir
                e.HasMorePages = false;
                return;
            }

            //se toma la imagen a imprimir
            Bitmap? imagen = panelBitmap;
            //definimos un rectangulo dentro de los margenes (margen de impresión)
            Rectangle margen = e.MarginBounds;

            //ajustamos la imagen al área imprimible por escala
            float escala = Math.Min((float)margen.Width / imagen.Width, (float)margen.Height / imagen.Height);
            int ancho = (int)(imagen.Width * escala);
            int alto = (int)(imagen.Height * escala);
            //calculamos posición en la hoja
            int x = margen.Left + (margen.Width - ancho) / 2;
            int y = margen.Top + (margen.Height - alto) / 2;

            //se mejora calidad de impresión            
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            //se dibujan bordes en el margen
            e.Graphics.DrawRectangle(Pens.Black, x, y, ancho, alto);
            //se dibuja la imagen del panel en la página, ajustando a los margenes
            e.Graphics.DrawImage(imagen, new Rectangle(x, y, ancho, alto));

            // se setea en false para indicar que no hay más páginas a imprimir
            e.HasMorePages = false;
        }

        /// <summary>
        /// Método que genera una imagen que captura el contenido de un panel del form
        /// creando un imagen bitmap para luego usarla en la impresión
        /// </summary>
        /// <param name="panel">panel que queremos capturar en la imagen</param>
        /// <returns></returns>
        private static Bitmap ImprimirPanelCarnet(Panel panel)
        {
            //creamos bitmap tomando alto y ancho del panel
            Bitmap bmp = new(panel.ClientSize.Width, panel.ClientSize.Height);
            //dibujamos en la imagen todo lo que se ve en pantalla dentro del panel
            panel.DrawToBitmap(bmp, new Rectangle(Point.Empty, panel.ClientSize));
            return bmp;
        }

        /// <summary>
        /// Método que genera una imagen bitmap que representa un código de barras
        /// en formato Code 39 a partir de una cadena numérica especificada
        /// </summary>
        /// <param name="codNumerico">cadena numérica a codificar</param>
        /// <param name="anchoImg">ancho total de la imagen a generar</param>
        /// <param name="altoImg">altura total de la imagen a generar</param>
        /// <param name="narrow">ancho barras angostas</param>
        /// <param name="wide">ancho barras anchas</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        private static Bitmap RenderCode39Digits(string codNumerico, int anchoImg, int altoImg, int narrow, int wide)
        {
            //Se crea el diccionario de patrones (N=angosto, W=ancho). Solo usamos digitos entre 0..9 y '*' para inicio y fin
            Dictionary<char, string> patronBarras = new Dictionary<char, string>()
            {
                ['0'] = "NNNWWNWNN",
                ['1'] = "WNNWNNNNW",
                ['2'] = "NNWWNNNNW",
                ['3'] = "WNWWNNNNN",
                ['4'] = "NNNWWNNNW",
                ['5'] = "WNNWWNNNN",
                ['6'] = "NNWWWNNNN",
                ['7'] = "NNNW WNNNW".Replace(" ", "N"),
                ['8'] = "WNNNWNNNN",
                ['9'] = "NNWNWNNNN",
                ['*'] = "NWNNWNWNN"
            };

            //delimitamos el texto con *, obligatorio en Code 39 para indicar inicio y fin
            string texto = $"*{codNumerico}*";

            //Se calcula el total de “unidades lógicas” necesarias para el código
            //cada carácter aporta 9 unidades (patrón) + 1 espacio entre caracteres
            int unidades = 0;
            foreach (char caracter in texto)
            {
                unidades += patronBarras[caracter].Length; //9 por caracter
                unidades += 1;                             //espacio para separar
            }
            //eliminamos el espacio extra del final
            unidades -= 1;

            //convertimos las unidades lógicas a píxeles reales
            //calculamos el tamaño base de una unidad angosta (narrow) y una ancha (wide)
            int unidadPixel = Math.Max(1, anchoImg / (unidades * narrow)); //tamaño base
            int anchoBarraAngosta = Math.Max(1, unidadPixel * narrow); //tamaño barra angosta
            int anchoBarraAncha = Math.Max(anchoBarraAngosta + 1, unidadPixel * wide); //tamaño barra ancha

            //se crea el bitmap donde se va a dibujar
            Bitmap bmpBarras = new(anchoImg, altoImg);

            using (var g = Graphics.FromImage(bmpBarras))
            {
                //se usa fondo blanco
                g.Clear(Color.White);
                //se inicializa la posición horizontal para dibujar
                int posX = 0;

                //vamos dibujando cada caracter del código numérico
                foreach (char caracter in texto)
                {
                    //se busca en el diccionario el patrón del caracter
                    string patron = patronBarras[caracter];

                    //recorremos el patrón obtenido del diccionario
                    for (int i = 0; i < patron.Length; i++)
                    {
                        //calculamos el ancho de la barra o espacio según el patrón (N o W)
                        int barW = (patron[i] == 'N') ? anchoBarraAngosta : anchoBarraAncha;

                        //verificamos si dibujamos barras o espacios
                        //las posiciones pares representan barras negras, las impares espacios blancos
                        bool drawBar = (i % 2 == 0);

                        //si corresponde, dibujamoss barra negra
                        if (drawBar)
                        {
                            g.FillRectangle(Brushes.Black, posX, 0, barW, altoImg - 20);
                        }

                        //avanzamos horizontalmente el ancho de la barra
                        posX += barW;
                    }

                    // espacio entre caracteres (angosto)
                    g.FillRectangle(Brushes.White, posX, 0, anchoBarraAngosta, altoImg);
                    //avanzamos horizontalmente el ancho de la barra
                    posX += anchoBarraAngosta;
                }

                //agregamos el código numérico como texto debajo de la barra
                using var font = new Font("Consolas", 12, FontStyle.Regular, GraphicsUnit.Pixel);
                StringFormat sf = new StringFormat { Alignment = StringAlignment.Center };
                g.DrawString(codNumerico, font, Brushes.Black, new RectangleF(0, altoImg - 18, anchoImg, 16), sf);
            }

            return bmpBarras;
        }
    }
}
