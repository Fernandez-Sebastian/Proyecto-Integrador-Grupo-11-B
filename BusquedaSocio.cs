using Proyecto_Integrador_Grupo_11_B.Class;

namespace Proyecto_Integrador_Grupo_11_B
{
    public partial class BusquedaSocio : Form
    {
        public Socio? SocioBusqueda { get; set; }

        public BusquedaSocio()
        {
            //inicializamos componentes del form
            InitializeComponent();
        }

        /// <summary>
        /// Método que instancia el carnet del socio y levanta el form
        /// de impresión pasando la clase del carnet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImprimirCarnetButton_Click(object sender, EventArgs e)
        {
            int idSocio = Socio.GetIdSocioByDni(SocioBusqueda.Dni);
            Carnet carnet = new(SocioBusqueda, idSocio);
            ImprimirCarnet carnetForm = new(carnet);
            carnetForm.ShowDialog();
        }

        /// <summary>
        /// Método que realiza la búsqueda del socio por el dni 
        /// ingresado en pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BuscarButton_Click(object sender, EventArgs e)
        {
            string dni = dniSocioText.Text.Trim();
            if (string.IsNullOrWhiteSpace(dni))
            {
                SocioBusqueda = null;
                resultadoLabel.Text = string.Empty;
                MessageBox.Show("Debe ingresar un DNI para continuar.");
            }
            else
            {
                SocioBusqueda = Socio.GetSocioByDni(dni);
                SetResultadoLabel();
            }
            EnableButtonImprimir();
        }

        /// <summary>
        /// Método para setear los datos del socio encontrado en pantalla 
        /// </summary>
        private void SetResultadoLabel()
        {
            if (SocioBusqueda != null)
            {
                resultadoLabel.Text = $"Datos del socio: {SocioBusqueda.Nombre} {SocioBusqueda.Apellido}, DNI: {SocioBusqueda.Dni}";
            }
            else
            {
                resultadoLabel.Text = string.Empty;
                MessageBox.Show("No se encontró un socio habilitado para el DNI ingresado.");
            }
        }

        /// <summary>
        /// Método para volver al form anterior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VolverMenu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "¿Seguro que deseas volver al menú principal?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
                this.Close();
        }

        /// <summary>
        /// Método para habilitar el botón de imprimir solo si se ha 
        /// encontrado un socio
        /// </summary>
        private void EnableButtonImprimir()
        {
            imprimirCarnetButton.Enabled = SocioBusqueda != null;
        }
    }
}
