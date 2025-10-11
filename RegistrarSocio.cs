using MySql.Data.MySqlClient;

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
            DialogResult result = MessageBox.Show(
                "¿Seguro que deseas volver al menú principal? Se cancelará el alta actual",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            // Tomamos los valores del formulario
            string dni = txtDni.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            string aptoMedico = chkAptoMedico.Checked ? "S" : "N";

            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("El campo DNI no puede estar vacío.");
                return;
            }
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("El campo Nombre no puede estar vacío.");
                return;
            }
            if (string.IsNullOrEmpty(apellido))
            {
                MessageBox.Show("El campo Apellido no puede estar vacío.");
                return;
            }

            if (aptoMedico == "N")
            {
                MessageBox.Show("Para continuar el alta, debe presentar el Apto Médico.");
                return;
            }

            int edad = DateTime.Today.Year - fechaNacimiento.Year;
            // calcula el mes de nacimiento para determinar si ya cumplió o no los años.
            if (fechaNacimiento.Date > DateTime.Today.AddYears(-edad)) edad--;

            // La fecha del socio debe ser mayor que 5 años y menor que 100 años
            // Además no se puede ingresar una edad mayor al día de hoy
            if (fechaNacimiento > DateTime.Today)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser futura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (edad < 5)
            {
                MessageBox.Show("El socio debe tener al menos 5 años.", "Edad no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (edad > 100)
            {
                MessageBox.Show("La edad ingresada no es válida.", "Edad no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Creamos la conexión usando la clase Conexion
                MySqlConnection conn = Datos.Conexion.getInstancia().CrearConexion();
                conn.Open();

                // Validar si el DNI ya existe
                string SQL = "SELECT COUNT(*) FROM Socios WHERE Dni = @dni";
                using (MySqlCommand DniCheck = new MySqlCommand(SQL, conn))
                {
                    DniCheck.Parameters.AddWithValue("@dni", dni);
                    int existe = Convert.ToInt32(DniCheck.ExecuteScalar());

                    if (existe > 0)
                    {
                        MessageBox.Show("Ya existe un socio registrado con este DNI.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        conn.Close();
                        return;
                    }
                }

                // Agregamos alerta para confirmar el Nuevo alta de Socio
                DialogResult result = MessageBox.Show(
                    $"¿Seguro que deseas dar de alta a {nombre} {apellido} DNI: {dni}? ",
                    "Confirmar salida",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.No)
                {
                    conn.Close();
                    return;
                }

                // Insert del nuevo Socio
                SQL = "INSERT INTO Socios (Dni, Nombre, Apellido, `FechaNacimiento`, AptoMedico) " +
                      "VALUES (@dni, @nombre, @apellido, @fechaNacimiento, @aptoMedico)";

                using (MySqlCommand cmd = new MySqlCommand(SQL, conn))
                {
                    cmd.Parameters.AddWithValue("@dni", dni);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellido", apellido);
                    cmd.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@aptoMedico", aptoMedico);

                    int filas = cmd.ExecuteNonQuery();

                    if (filas > 0)
                    {
                        MessageBox.Show($"Socio {nombre} {apellido} registrado correctamente. Para realizar una actividad debe tener la cuota al día.");
                        // limpiar campos
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

        private void ImprimirCarnet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Imprimir Carnet en Desarrollo");
        }
    }
}
