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
        /// Método que obtiene el ID del socio, instancia el objeto Carnet correspondiente
        /// y abre el formulario de impresión pasando dicho carnet.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImprimirCarnetButton_Click(object sender, EventArgs e)
        {
            //obtenemos el id del socio por su dni
            int idSocio = Socio.GetIdSocioByDni(SocioBusqueda.Dni);
            //creamos una instancia para el carnet del socio 
            Carnet carnet = new(SocioBusqueda, idSocio);
            //creamos el form de impresió del carnet pasando el carnet como parámetro 
            ImprimirCarnet carnetForm = new(carnet);
            //mostramos el formulario
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
            //obtenemos el dni ingresado sin espacios
            string dni = dniSocioText.Text.Trim();

            //validamos que haya sido ingresado el dni
            if (string.IsNullOrWhiteSpace(dni))
            {
                //si no hay dni limpiamos datos anteriores
                SocioBusqueda = null;
                resultadoLabel.Text = string.Empty;
                //notificamos al usuario que debe ingresar un dni
                MessageBox.Show("Debe ingresar un DNI para continuar.");
            }
            else
            {
                //buscamos al socio por dni
                SocioBusqueda = Socio.GetSocioByDni(dni);
                //mostramos en pantalla en el label el resultado de la búsquedda
                SetResultadoLabel();
            }
            //Habilitar o deshabilitar el botón de impresión según si se encontró el socio
            EnableButtonImprimir();
        }

        /// <summary>
        /// Método para setear los datos del socio encontrado en pantalla 
        /// </summary>
        private void SetResultadoLabel()
        {
            if (SocioBusqueda != null)
            {
                //si se encontró el socio se setea en pantalla sus datos
                resultadoLabel.Text = $"Datos del socio: {SocioBusqueda.Nombre} {SocioBusqueda.Apellido}, DNI: {SocioBusqueda.Dni}";
            }
            else
            {
                //si no se encontró se limpia el label y se notifica al usuario
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
            //el botón de imprimir se habilita solo cuando tengo un socio
            imprimirCarnetButton.Enabled = SocioBusqueda != null;
        }
    }
}
