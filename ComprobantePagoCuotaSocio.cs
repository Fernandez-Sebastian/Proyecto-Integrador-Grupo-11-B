using Proyecto_Integrador_Grupo_11_B.Class;

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
            LblMontoTotal.Text = "$"+_comprobante.Precio.ToString();
            LblCuotaTarjeta.Text = _comprobante.CantCuotasFinanciada.ToString();
            LblCuotaAbonada.Text = _comprobante.CantCuotasPagadas.ToString();
        }

        private void Imprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                        $"📄 COMPROBANTE DE PAGO\n\n" +
                        $"Número de Socio: {_comprobante.idSocio}\n" +
                        $"Nombre: {_comprobante.Nombre} {_comprobante.Apellido}\n" +
                        $"DNI: {_comprobante.Dni}\n" +
                        $"Método de Pago: {_comprobante.MedioDePago}\n" +
                        $"Fecha de Pago: {_comprobante.Fecha.ToShortDateString()}\n" +
                        $"Monto Total: {_comprobante.Precio.ToString("C")}\n" +
                        $"Cuotas Financiadas: {_comprobante.CantCuotasFinanciada}\n" +
                        $"Cuotas Abonadas: {_comprobante.CantCuotasPagadas}",
                        "Comprobante de Pago",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

            // Ejemplo de acción al hacer clic en Registrar
            // MessageBox.Show("Comprobante generado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
