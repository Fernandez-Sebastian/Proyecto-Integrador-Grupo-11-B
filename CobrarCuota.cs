using MySql.Data.MySqlClient;
using Proyecto_Integrador_Grupo_11_B.Class;
using System.Net;

namespace Proyecto_Integrador_Grupo_11_B
{
    public partial class CobrarCuota : Form
    {
        public CobrarCuota()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BuscarSocio_Click(object sender, EventArgs e)
        {
            try
            {
                // Se crea una instancia la clase Socio.
                Socio BuscarSocio = new();
                string dni = txtDni.Text.Trim();
                // Declaramos la variable para capturar y mostrar el error.
                string error = "";
                if (BuscarSocio.ExisteDni(dni, out error))
                {
                    BuscarSocio.GetSocio(txtDni.Text);
                    textNumeroSocio.Text = BuscarSocio.idSocio;
                    txtNombre.Text = BuscarSocio.Nombre;
                    txtApellido.Text = BuscarSocio.Apellido;
                    txtHabilitado.Text = BuscarSocio.Habilitado;
                }
                else
                {
                    MessageBox.Show("No existe el Socio");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado durante el registro del socio:\n{ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void VolverMenu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "¿Seguro que deseas volver al menú principal? Se cancelará pago de cuota actual",
               "Confirmar salida",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
           );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BuscarDeuda_Click(object sender, EventArgs e)
        {

            // Validar que el número de socio no esté vacío
            if (string.IsNullOrWhiteSpace(textNumeroSocio.Text))
            {
                MessageBox.Show("Debe buscar un Socio antes de consultar la deuda.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Bloquear el campo DNI para que no se pueda modificar
            txtDni.Enabled = false;
            string Apellido = txtApellido.Text;
            string Nombre = txtNombre.Text;

            // Guardar el idSocio en una variable
            int idSocio = int.Parse(textNumeroSocio.Text);

            // Limpiar ComboBox antes de llenar
            comboBoxCuotas.Items.Clear();

            // Obtener la lista de cuotas adeudadas (la conexión se maneja dentro del método)
            List<Cuota> cuotasAdeudadas = Cuota.BuscarCuotasAdeudadas(idSocio);

            if (cuotasAdeudadas == null || cuotasAdeudadas.Count == 0)
            {
                MessageBox.Show($"No se registran deudas para el socio {Apellido}, {Nombre}.",
                                "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Muestro el boton de pagar cuota
            PagarCuota.Visible = true;
            // Llenar ComboBox
            foreach (Cuota c in cuotasAdeudadas)
            {
                comboBoxCuotas.Items.Add(c);
            }

            // Opcional: seleccionar la primera cuota
            if (comboBoxCuotas.Items.Count > 0)
                comboBoxCuotas.SelectedIndex = 0;
        }

        private void PagarCuota_Click(object sender, EventArgs e)
        {
            // Determinar si se abonarán todas las cuotas o solo una
            bool abonarTodas = checkBoxAbonarTodo.Checked;
            int idSocio = int.Parse(textNumeroSocio.Text);

            Cuota cuotaSeleccionada = null;

            if (!abonarTodas)
            {
                // Si no se abonan todas, debe haber una cuota seleccionada
                if (comboBoxCuotas.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar una cuota a abonar.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener la cuota seleccionada del ComboBox
                cuotaSeleccionada = (Cuota)comboBoxCuotas.SelectedItem;
            }

            // Determinar método de pago
            string metodoPago = "";

            if (radioEfectivo.Checked)
                metodoPago = "Efectivo";
            else if (radioTarjeta.Checked)
                metodoPago = "Tarjeta";
            else if (radioTransferencia.Checked)
                metodoPago = "Transferencia";
            else
            {
                MessageBox.Show("Debe seleccionar un método de pago.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Confirmar los datos del pago antes de continuar
            string mensajeResumen = abonarTodas
                ? $"Socio ID: {idSocio}\nMétodo de pago: {metodoPago}\n\nSe abonarán todas las cuotas adeudadas."
                : $"Socio ID: {idSocio}\nCuota seleccionada: {cuotaSeleccionada.ToString()}\nMétodo de pago: {metodoPago}";

            DialogResult confirmar = MessageBox.Show(
                mensajeResumen + "\n\n¿Desea confirmar el pago?",
                "Confirmar pago",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmar == DialogResult.No)
                return;

            // Simular el pago (más adelante irá la lógica de actualización en la BD)
            MessageBox.Show("Pago realizado con éxito.\n\n(Próximamente se abrirá el comprobante de pago para poder imprimirlo).",
                            "Pago confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
