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
            RegistrarSocio formRegistrar = new();

            // Mostrarlo como modal (bloquea el formulario actual hasta que se cierre)
            formRegistrar.ShowDialog();
        }

        private void SistemaClub_Load(object sender, EventArgs e)
        {

        }
    }
}
