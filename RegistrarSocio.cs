using Proyecto_Integrador_Grupo_11_B.Class;

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
            try
            {
                // Se crea una instancia la clase Socio.
                Socio NuevoSocio = new();

                // Tomamos los valores del formulario y lo asignamos a variables para hacer las validaciones correspondientes.
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

                // Si llegue acá todos los datos ingresados ya estan correctos para realizar el alta del Socio.
                // Valido que el DNI no este registardo.
                if (NuevoSocio.ExisteDni(dni) == "S")
                {
                    MessageBox.Show($"Ya existe un socio registrado con el DNI {dni}.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Si llegamos aca, el DNI ingresado no esta duplicado y los datos estan validados.
                // Agregamos alerta para confirmar el Nuevo alta de Socio.
                DialogResult result = MessageBox.Show(
                    $"¿Seguro que deseas dar de alta a {nombre} {apellido} DNI: {dni}? ",
                    "Confirmar salida",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.No)
                {
                    return;
                }

                // Carga de datos y registro el Socio en la base de datos.
                NuevoSocio.SetDatosPersona(dni, nombre, apellido);
                NuevoSocio.FechaNacimiento = fechaNacimiento;
                NuevoSocio.AptoMedico = aptoMedico;
                string EstadoAlta = NuevoSocio.RegistrarSocio();

                if (EstadoAlta == "OK")
                {
                    MessageBox.Show($"\"Socio {nombre} {apellido} registrado correctamente. Para realizar una actividad debe tener la cuota al día.\"");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el socio.");
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

        private void ImprimirCarnet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Imprimir Carnet en Desarrollo");
        }
    }
}
