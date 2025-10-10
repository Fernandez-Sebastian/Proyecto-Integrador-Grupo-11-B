namespace Proyecto_Integrador_Grupo_11_B
{
    public partial class SistemaClub : Form
    {
        public SistemaClub()
        {
            InitializeComponent();
        }
        private void RegistrarSocio_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario RegistrarSocio
            RegistrarSocio formRegistrarSocio = new RegistrarSocio();

            // Mostrarlo como modal (bloquea el formulario actual hasta que se cierre)
            formRegistrarSocio.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
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
            MessageBox.Show("Altas de No Socios en Desarrollo");
        }

        private void CobrarCuota_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cobro Cuota en Desarrollo");
        }

        private void MostrarDeudaCuotaSocio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deuda de socios en Desarrollo");
        }
    }
}
