using Proyecto_Integrador_Grupo_11_B.Class;

namespace Proyecto_Integrador_Grupo_11_B
{
    public partial class CobrarCuota : Form
    {
        public CobrarCuota()
        {
            InitializeComponent();
        }

        // Método para buscar un Socio por su DNI.
        // Si lo encuentra completa los campos con sus datos.
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

        // Método para volver al menú anterior.
        private void VolverMenu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "¿Seguro que deseas volver al menú principal?",
               "Confirmar salida",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
           );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Método para buscar la deuda del Socio.
        private void BuscarDeuda_Click(object sender, EventArgs e)
        {
            //Muestro el botón de pagar cuota.
            BtnPagarCuota.Visible = true;

            // vuelvo al estado inicial cada elemento del formulario.
            // Para que se reinicien si hay muchas búsquedas.
            labelAbonarAnio.Visible = false;
            checkBoxAbonarAnio.Visible = false;
            checkBoxAbonarTodo.Visible = true;
            comboBoxCuotas.Visible = true;
            labelComboCuotas.Visible = true;
            labelTodasCuotasAdeudadas.Visible = true;

            // Validar que el número de socio no esté vacío.
            // Es decir, ya se realizó la búsqueda del Socio previamente.
            if (string.IsNullOrWhiteSpace(textNumeroSocio.Text))
            {
                BtnPagarCuota.Visible = false;
                MessageBox.Show("Debe buscar un Socio antes de consultar la deuda.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Bloquear el campo DNI para que no se pueda modificar una vez se realizó la búsqueda.
            // Declaración de variables que utilizaremos.
            txtDni.Enabled = false;
            string Apellido = txtApellido.Text;
            string Nombre = txtNombre.Text;
            int idSocio = int.Parse(textNumeroSocio.Text);

            // Limpiar ComboBox antes de llenar con las cuotas a pagar.
            comboBoxCuotas.Items.Clear();
            
            // Obtenemos la deuda de cuotas del Socio.
            List<Cuota> cuotasAdeudadas = Cuota.BuscarCuotasAdeudadas(idSocio);

            // (*) Si no adeuda nada, habilito para que pague un año futuro.
            // (**) Si adeuda una cuota o mas cuotas, cargo el combo con ese listado de cuotas.
            // (**) Oculto la posibilidad de pagar un año adelantado 
            // (**) Habilito la posibilidad de pagar toda la deuda completa.
            if (cuotasAdeudadas == null || cuotasAdeudadas.Count == 0)
            {
                // Si no adeuda cuotas muestro el mensaje.
                MessageBox.Show($"No se registran deudas para el socio {Apellido}, {Nombre}.",
                                "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Habilito los elementos para pagar el año completo.
                labelAbonarAnio.Visible = true;
                checkBoxAbonarAnio.Visible = true;

                // Oculto todos los botones de pagos de cuotas vencidas porque no tiene.
                checkBoxAbonarTodo.Visible = false;
                comboBoxCuotas.Visible = false;
                labelComboCuotas.Visible = false;
                labelTodasCuotasAdeudadas.Visible = false;

                return;
            }

            // Llenar ComboBox con el listado de cuotas adeudadas.
            foreach (Cuota c in cuotasAdeudadas)
            {
                comboBoxCuotas.Items.Add(c);
            }

            // Selecciono la primera cuota de la lista.
            if (comboBoxCuotas.Items.Count > 0)
                comboBoxCuotas.SelectedIndex = 0;
        }

        // Método que se ejecuta al capturar el evento de click sobre el btn Pagar Cuota.
        private void PagarCuota_Click(object sender, EventArgs e)
        {
            // Declaración de las variables que utilizaremos.
            bool abonarTodas = checkBoxAbonarTodo.Checked;
            bool abonarAnio = checkBoxAbonarAnio.Checked;
            bool pagaUnaCuota = false;
            int idSocio = int.Parse(textNumeroSocio.Text);
            int CantCuotas = 0;

            Cuota cuotaSeleccionada = null;

            // Si no abona todo el año y no abona toda la deuda, es porque paga una sola cuota.
            // Valido que haya elegido una cuota.
            if (!abonarTodas && !abonarAnio)
            {
                if (comboBoxCuotas.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar una cuota a abonar.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener la cuota seleccionada del ComboBox.
                cuotaSeleccionada = (Cuota)comboBoxCuotas.SelectedItem;
                pagaUnaCuota = true;
            }

            // Determinar método de pago seleccionado.
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

            // Validaciones para cuando el método de pago es con tarjeta.
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

            // Confirmar los datos antes de continuar.

            DialogResult confirmar = MessageBox.Show(
                "\n\n¿Desea confirmar el pago?",
                "Confirmar pago",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmar == DialogResult.No)
                return;

            // Declaración de variables para ejecutar el pago.
            float TotalPago = 0;

            // Accion para pagar el año adelantado.
            // Valido que no tenga deuda.
            // Pago todas un año y cuento el total abonado.
            if (abonarAnio)
            {
                List<Cuota> cuotasAdeudadas = Cuota.BuscarCuotasAdeudadas(idSocio);
                if (cuotasAdeudadas == null || cuotasAdeudadas.Count == 0)
                {
                    CantCuotas = 12;
                    TotalPago = Cuota.CrearUnAnioDeCuotasPagas(idSocio, metodoPago, cantidadCuotaFinanciada);
                }
            }

            // Acción cuando paga todas las cuotas adeudada o una cuota específica adeudada.
            // Genero la lista de cuotas A Pagar y las abono en el método, en la clase Cuota.
            if (abonarTodas || pagaUnaCuota)
            {
                List<Cuota> cuotasAPagar = new List<Cuota>();

                if (abonarTodas)
                    cuotasAPagar = Cuota.BuscarCuotasAdeudadas(idSocio);
                else
                    cuotasAPagar.Add(cuotaSeleccionada);

                CantCuotas = cuotasAPagar.Count;
                TotalPago = Cuota.PagarCuotas(cuotasAPagar, metodoPago, cantidadCuotaFinanciada);
            }

            // Llegado acá ya se generó el pago de la o las cuotas.
            // Antes de crear el comprobante de pago, le cambio el estado al Socio Habilitado S/N según corresponda.
            List<Cuota> adeudaCuotas = new List<Cuota>();
            adeudaCuotas = Cuota.BuscarCuotasAdeudadas(idSocio);

            string Habilitado = "N";
            if (adeudaCuotas == null || adeudaCuotas.Count == 0)
            {
                Habilitado = "S";
            }

            // Actualizo el campo Habilitado del socio en el Formulario.
            txtHabilitado.Text = Habilitado;

            // Actualizo el Estado del Socio.
            string error = "";
            Socio ActualizarSocio = new();
            ActualizarSocio.ActualizarDatosSocio(idSocio, Habilitado, out error);

            // Crear el comprobante con una instancia de la clase ComprobanteDePagoCuotaSocio.
            // Que hereda de la clase ComprobanteDePago.
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

            // Antes de abrir el comprobante de pago.
            // Oculto todos los botones del formulario.
            // Para no generar inconvenientes al volver al formulario.
            // También bloqueamos los elementos para que no se pueda interactuar.
            BtnPagarCuota.Visible = false;
            buttonLimpiarBusqueda.Visible = false;
            BuscarSocio.Visible = false;
            BuscarDeuda.Visible = false;

            checkBoxAbonarTodo.Enabled = false;
            checkBoxAbonarAnio.Enabled = false;
            comboBoxCuotas.Enabled = false;

            radioEfectivo.Enabled = false;
            radioTarjeta.Enabled = false;
            radioTransferencia.Enabled = false;
            radio3Cuotas.Enabled = false;
            radio6Cuotas.Enabled = false;


            // Mostrar formulario visual del comprobante.
            ComprobantePagoCuotaSocio ComprobanteCuotaSocio = new ComprobantePagoCuotaSocio(comprobante);
            ComprobanteCuotaSocio.ShowDialog();
        }

        // Captura de evento para manejo del group de cuotas.
        private void radioTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            GroupCantidadDeCuotas.Visible = true;
        }

        // Captura de evento para manejo del group de cuotas.
        private void radioEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            GroupCantidadDeCuotas.Visible = false;
        }

        // Captura de evento para manejo del group de cuotas.
        private void radioTransferencia_CheckedChanged(object sender, EventArgs e)
        {
            GroupCantidadDeCuotas.Visible = false;
        }

        // Boton para limpiar campos del formulario.
        private void buttonLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            // Blanqueo los campos de la búsqueda del Socio.
            textNumeroSocio.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtHabilitado.Text = "";
            txtDni.Text = "";
            
            // Blanqueo los campos de opciones de pago.
            checkBoxAbonarAnio.Checked = false;
            checkBoxAbonarTodo.Checked = false;
            comboBoxCuotas.Items.Clear();

            // Blanqueo las opciones de los métodos de pago
            radioTransferencia.Checked = false;
            radioTarjeta.Checked = false;
            radioEfectivo.Checked = false;
            radio6Cuotas.Checked = false;
            radio3Cuotas.Checked = false;
            
            // Oculto el botón de pagar cuota y habilito el campo DNI para buscar otro DNI.
            txtDni.Enabled = true;
            BtnPagarCuota.Visible = false;
        }
    }
}
