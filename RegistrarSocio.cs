using MySql.Data.MySqlClient;
using Proyecto_Integrador_Grupo_11_B;

namespace Proyecto_Integrador_Grupo_11_B
{
    public partial class RegistrarSocio : Form
    {
        public RegistrarSocio()
        {
            InitializeComponent();
        }

        private void VolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            // Tomamos los valores del formulario
            string dni = txtDni.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            DateTime fechaNacimiento = dtpFechaNacimiento.Value; // asumiendo que usas un DateTimePicker
            string aptoMedico = chkAptoMedico.Checked ? "S" : "N";

            if (string.IsNullOrEmpty(dni) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido))
            {
                MessageBox.Show("Complete todos los campos obligatorios.");
                return;
            }

            try
            {
                // Creamos la conexión usando tu clase Conexion
                MySqlConnection conn = Datos.Conexion.getInstancia().CrearConexion();

                conn.Open();

                string query = "INSERT INTO Socios (Dni, Nombre, Apellido, `FechaNacimiento`, AptoMedico) " +
                       "VALUES (@dni, @nombre, @apellido, @fechaNacimiento, @aptoMedico)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@dni", dni);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellido", apellido);
                    cmd.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@aptoMedico", aptoMedico);

                    int filas = cmd.ExecuteNonQuery();

                    if (filas > 0)
                    {
                        MessageBox.Show("Socio registrado correctamente.");
                        // Opcional: limpiar campos
                        txtDni.Clear();
                        txtNombre.Clear();
                        txtApellido.Clear();
                        dtpFechaNacimiento.Value = DateTime.Today;
                        chkAptoMedico.Checked = false;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar el socio.");
                    }
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el socio: " + ex.Message);
            }
        }

    }
}
