using MySql.Data.MySqlClient;
using Proyecto_Integrador_Grupo_11_B.Class;
using System.Net;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto_Integrador_Grupo_11_B
{
    public partial class CobrarCuota : Form
    {
        public CobrarCuota()
        {
            InitializeComponent();
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
            //Muestro el boton de pagar cuota
            BtnPagarCuota.Visible = true;

            // Si se desea hacer una búsqueda sin salir de la pantalla, 
            // reinicio los estados de ocultoo visible de cada elemento.
            labelAbonarAnio.Visible = false;
            checkBoxAbonarAnio.Visible = false;
            checkBoxAbonarTodo.Visible = true;
            comboBoxCuotas.Visible = true;
            labelComboCuotas.Visible = true;
            labelTodasCuotasAdeudadas.Visible = true;

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

            // Obtener la lista de cuotas adeudadas hasta el periodo en curso,
            // sin contar cuotas futuras

            string ultimoDiaPeriodo = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month)).ToString("dd/MM/yyyy");
            List<Cuota> cuotasAdeudadas = Cuota.BuscarCuotasAdeudadas(idSocio, ultimoDiaPeriodo);

            // si no adeuda nada, habilito para que pague un año futuro.
            // si adeuda cuota, cargo el combo con ese listado de cuotas,
            // oculto la posibilidad de pagar un año adelantado 
            // muestro la posibilidad de pagar toda la deuda completa
            if (cuotasAdeudadas == null || cuotasAdeudadas.Count == 0)
            {
                MessageBox.Show($"No se registran deudas para el socio {Apellido}, {Nombre}.",
                                "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Habilito los elementos para pagar el año completo.
                labelAbonarAnio.Visible = true;
                checkBoxAbonarAnio.Visible = true;

                //oculto todos los botones de pagos de cuotas vencidas
                checkBoxAbonarTodo.Visible = false;
                comboBoxCuotas.Visible = false;
                labelComboCuotas.Visible = false;
                labelTodasCuotasAdeudadas.Visible = false;

                return;
            }
            
            // Llenar ComboBox con el listado de cuotas adeudadas
            foreach (Cuota c in cuotasAdeudadas)
            {
                comboBoxCuotas.Items.Add(c);
            }

            // Selecciono la primera cuota
            if (comboBoxCuotas.Items.Count > 0)
                comboBoxCuotas.SelectedIndex = 0;
        }

        private void PagarCuota_Click(object sender, EventArgs e)
        {
            // Determinar si se abonarán todas las cuotas o solo una o todo el año
            bool abonarTodas = checkBoxAbonarTodo.Checked;
            bool abonarAnio = checkBoxAbonarAnio.Checked;
            bool pagaUnaCuota = false;
            int idSocio = int.Parse(textNumeroSocio.Text);
            int CantCuotas = 0;

            Cuota cuotaSeleccionada = null;

            if (!abonarTodas && !abonarAnio)
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
                pagaUnaCuota = true;
            }

            // Determinar método de pago
            string metodoPago = "";
            GroupCantidadDeCuotas.Visible = false;
            if (radioEfectivo.Checked)
                metodoPago = "Efectivo";
            else if (radioTarjeta.Checked)
            {
                metodoPago = "Tarjeta";
            }
            else if (radioTransferencia.Checked)
                metodoPago = "Transferencia";
            else
            {
                MessageBox.Show("Debe seleccionar un método de pago.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Valdiaciones para pago con tarjeta
            string cantidadCuotaFinanciada = "1";
            if (radioTarjeta.Checked)
            {
                GroupCantidadDeCuotas.Visible = true;
                if (radio3Cuotas.Checked)
                    cantidadCuotaFinanciada = "3";
                else if (radio6Cuotas.Checked)
                    cantidadCuotaFinanciada = "6";
                else
                {
                    MessageBox.Show("Debe seleccionar en cuantas Cuotas va a abonar.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
            }

            // Confirmar los datos del pago antes de continuar

            DialogResult confirmar = MessageBox.Show(
                "\n\n¿Desea confirmar el pago?",
                "Confirmar pago",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmar == DialogResult.No)
                return;
          
            string ultimoDiaPeriodo = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month)).ToString("dd/MM/yyyy");
            float TotalPago = 0;
            // Accion para pagar el año.
            if (abonarAnio)
            {
                List<Cuota> cuotasAdeudadas = Cuota.BuscarCuotasAdeudadas(idSocio, ultimoDiaPeriodo);
                if (cuotasAdeudadas == null || cuotasAdeudadas.Count == 0)
                {
                    CantCuotas = 12;
                    TotalPago = Cuota.CrearUnAnioDeCuotasPagas(idSocio, metodoPago, cantidadCuotaFinanciada);
                }
            }

            // Accion cuando paga todas las cuotas adeudada o una cuota específica.
            // Genero la lista de cuotas y las pago en la clase cuota.
            if (abonarTodas || pagaUnaCuota)
            {
                List<Cuota> cuotasAPagar = new List<Cuota>();

                if (abonarTodas)
                    cuotasAPagar = Cuota.BuscarCuotasAdeudadas(idSocio, ultimoDiaPeriodo);
                else
                    cuotasAPagar.Add(cuotaSeleccionada);

                CantCuotas = cuotasAPagar.Count;
                TotalPago = Cuota.PagarCuotas(cuotasAPagar, metodoPago, cantidadCuotaFinanciada);
            }

            // Simular el pago (más adelante irá la lógica de actualización en la BD)
            MessageBox.Show("Pago realizado con éxito.\n\n(Próximamente se abrirá el comprobante de pago para poder imprimirlo).",
                            "Pago confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Antes de crear el comprobante de pago, le cambio el estado al Socio Habilitado S/N según corresponda.
            List<Cuota> adeudaCuotas = new List<Cuota>();
            adeudaCuotas = Cuota.BuscarCuotasAdeudadas(idSocio, ultimoDiaPeriodo);

            string Habilitado = "N";
            if (adeudaCuotas == null || adeudaCuotas.Count == 0)
            {
                Habilitado = "S";
            }

            // Actualizo el Estado del Socio.
            string error = "";
            Socio ActualizarSocio = new();
            ActualizarSocio.ActualizarDatosSocio(idSocio, Habilitado, out error);

            // Crear el comprobante (objeto de datos)
            string Apellido = txtApellido.Text;
            string Nombre = txtNombre.Text;
            string Dni = txtDni.Text.Trim();
            double Total = TotalPago;


            var comprobante = new ComprobanteDePagoCuotaSocio(
                Nombre,
                Apellido,
                Dni,
                idSocio,
                Total,
                CantCuotas,
                cantidadCuotaFinanciada,
                metodoPago
            );

            //Mostrar formulario visual del comprobante
            ComprobantePagoCuotaSocio ComprobanteCuotaSocio = new ComprobantePagoCuotaSocio(comprobante);
            ComprobanteCuotaSocio.ShowDialog();
            //this.Close();


        }

        private void radioTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            GroupCantidadDeCuotas.Visible = true;
        }

        private void radioEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            GroupCantidadDeCuotas.Visible = false;
        }

        private void radioTransferencia_CheckedChanged(object sender, EventArgs e)
        {
            GroupCantidadDeCuotas.Visible = false;
        }
    }
}
