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
            Application.Exit();
        }
    }
}
