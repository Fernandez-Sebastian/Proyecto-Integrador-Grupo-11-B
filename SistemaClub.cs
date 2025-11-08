using MySql.Data.MySqlClient;
using Proyecto_Integrador_Grupo_11_B.Datos;

namespace Proyecto_Integrador_Grupo_11_B
{
    public partial class SistemaClub : Form
    {
        public SistemaClub()
        {
            InitializeComponent();
            SetAlertaVencimientoLabelText();
        }

        private void RegistrarSocio_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario RegistrarSocio
            RegistrarSocio formRegistrarSocio = new RegistrarSocio();

            // Mostrarlo como modal (bloquea el formulario actual hasta que se cierre)
            formRegistrarSocio.ShowDialog();
        }

        private void SalirSistema_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "¿Seguro que deseas salir del sistema?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void RegistrarNoSocio_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario RegistrarNoSocio
            RegistrarNoSocio formRegistrarNoSocio = new RegistrarNoSocio();

            // Mostrarlo como modal (bloquea el formulario actual hasta que se cierre)
            formRegistrarNoSocio.ShowDialog();
        }

        private void CobrarCuota_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario RegistrarSocio
            CobrarCuota formPagarCuota = new();

            // Mostrarlo como modal (bloquea el formulario actual hasta que se cierre)
            formPagarCuota.ShowDialog();
        }

        /// <summary>
        /// Método para levantar formulario de vencimientos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MostrarVencimientosCuotaSocio_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario listar deudores
            ListarVencimientos formListarDeudores = new ListarVencimientos();

            // Mostrarlo como modal (bloquea el formulario actual hasta que se cierre)
            formListarDeudores.ShowDialog();
        }

        private void CobrarActividad_Click(object sender, EventArgs e)
        {
            // Crear instancia del formulario
            CobrarActividad formCobrar = new CobrarActividad();

            // Mostrarlo como modal (bloquea la ventana principal hasta cerrarlo)
            formCobrar.ShowDialog();
        }

        /// <summary>
        /// Método para levantar form de la búsqueda de socios
        /// que nos permite luego entrar a la impresión del carnet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CarnetSocioButton_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario Buscar socios
            BusquedaSocio busquedaSocio = new();

            // Mostrarlo como modal (bloquea el formulario actual hasta que se cierre)
            busquedaSocio.ShowDialog();
        }

        /// <summary>
        /// Método para setear el texto en alertaVencimientosLabel si existen o no 
        /// socios cuya cuota vence en el día
        /// </summary>
        private void SetAlertaVencimientoLabelText()
        {
            string fechaConsultar = DateTime.Now.ToString("yyyy-MM-dd");
            MySqlConnection sqlCon;
            sqlCon = Conexion.getInstancia().CrearConexion();
            MySqlCommand comando = new("sp_listar_deudores_por_fecha", sqlCon);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@p_fecha", fechaConsultar);
            sqlCon.Open();
            MySqlDataReader reader = comando.ExecuteReader();

            string resultMessage;

            if (reader.HasRows)
            {
                resultMessage = "Existen socios cuya cuota vence el día de hoy, consultar el listado de vencimientos.";
                alertaVencimientosLabel.ForeColor = Color.Red;
            }
            else
            {
                resultMessage = "No existen cuotas a vencer el día de hoy.";
                alertaVencimientosLabel.ForeColor = Color.Green;
            }

            alertaVencimientosLabel.Text = $"ATENCION: {resultMessage}";
        }

        /// <summary>
        /// Método para actualizar el alerta de vencimientos
        /// a través del botón de actualizar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActualizarButton_Click(object sender, EventArgs e)
        {
            SetAlertaVencimientoLabelText();
        }
    }
}
