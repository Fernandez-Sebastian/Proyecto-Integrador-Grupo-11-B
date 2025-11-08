using Proyecto_Integrador_Grupo_11_B.Datos;
using System.Data;

namespace Proyecto_Integrador_Grupo_11_B
{
    public partial class ConfiguracionBD : Form
    {
        public string Servidor { get; private set; }
        public string Puerto { get; private set; }
        public string Usuario { get; private set; }
        public string Clave { get; private set; }

        public ConfiguracionBD()
        {
            InitializeComponent();
        }

        private void ConfiguracionBD_Load(object sender, EventArgs e)
        {
            // Inicialmente mostramos el placeholder
            txtPass.ForeColor = Color.Gray;
            txtPass.UseSystemPasswordChar = false;
            this.BeginInvoke((Action)(() => txtServidor.Focus()));
        }

        private void TxtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Black;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void TxtPass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.ForeColor = Color.Gray;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.Gray;
            }
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            // Guardamos los valores ingresados en las propiedades públicas
            Servidor = txtServidor.Text.Trim();
            Puerto = txtPuerto.Text.Trim();
            Usuario = txtUsuario.Text.Trim();
            Clave = txtPass.Text.Trim();

            // Verificar que no haya campos vacíos
            if (string.IsNullOrWhiteSpace(Servidor) ||
                string.IsNullOrWhiteSpace(Puerto) ||
                string.IsNullOrWhiteSpace(Usuario))
            {
                MessageBox.Show("Por favor complete todos los campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Intentar conectar
            try
            {
                var conexion = new Conexion(Servidor, Puerto, Usuario, Clave);

                if (conexion.ProbarConexion())
                {
                    MessageBox.Show("Conexión exitosa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Guardamos la instancia para uso global
                    Conexion.Inicializar(Servidor, Puerto, Usuario, Clave);

                    // Abrimos el formulario de Login
                    Login loginForm = new Login();
                    loginForm.Show();

                    // Ocultamos la ventana actual
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No se pudo conectar. Verifique los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar conectar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "¿Seguro que deseas cancelar la conexión?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}