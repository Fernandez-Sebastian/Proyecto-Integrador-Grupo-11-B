using Proyecto_Integrador_Grupo_11_B.Class;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_Integrador_Grupo_11_B
{
    public partial class RegistrarNoSocio : Form
    {
        public RegistrarNoSocio()
        {
            InitializeComponent();
        }

        private void VolverMenu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "¿Seguro que deseas volver al menú principal?",
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
                // Se crea una instancia la clase No Socio.
                NoSocio NuevoNoSocio = new();

                // Declaramos la variable para capturar y mostrar el error.
                string error = "";

                // Tomamos los valores del formulario y lo asignamos a variables para hacer las validaciones correspondientes.
                string dni = txtDni.Text.Trim();
                string nombre = txtNombre.Text.Trim();
                string apellido = txtApellido.Text.Trim();
                DateTime fechaNacimiento = dtpFechaNacimiento.Value;
                string aptoMedico = chkAptoMedico.Checked ? "S" : "N";             

                //Validamos que el nombre NO este vacío y que NO tenga números

                if (string.IsNullOrEmpty(nombre))
                {
                    MessageBox.Show("El campo Nombre no puede estar vacío.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (nombre.Any(char.IsDigit))
                {
                    MessageBox.Show("El Nombre no puede contener números.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Validamos que el dni NO este vacío y que SOLO tenga números
                if (string.IsNullOrEmpty(dni))
                {
                    MessageBox.Show("El campo DNI no puede estar vacío.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!dni.All(char.IsDigit))
                {
                    MessageBox.Show("El DNI solo puede contener números.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validamos que el apellido NO este vacío y que NO tenga números
                if (string.IsNullOrEmpty(apellido))
                {
                    MessageBox.Show("El campo Apellido no puede estar vacío.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (apellido.Any(char.IsDigit))
                {
                    MessageBox.Show("El Apellido no puede contener números.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Validamos que el NoSocio tenga el apto médico para realizar actividades
                if (aptoMedico == "N")
                {
                    MessageBox.Show("Para continuar el alta, debe presentar el Apto Médico.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Validamos la edad
                // La fecha del No socio debe ser mayor que 5 años y menor que 100 años
                int edad = DateTime.Today.Year - fechaNacimiento.Year; //calcula la edad

                if (fechaNacimiento.Date > DateTime.Today.AddYears(-edad)) edad--; // calcula el mes de nacimiento para determinar si ya cumplió o no los años.

               
                if (fechaNacimiento > DateTime.Today)  // Además no se puede ingresar una edad mayor al día de hoy
                {
                    MessageBox.Show("La fecha de nacimiento no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (edad < 5)
                {
                    MessageBox.Show("El No Socio debe tener al menos 5 años.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (edad > 100)
                {
                    MessageBox.Show("La edad ingresada no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Si llegamos acá todos los datos ingresados ya estan correctos para realizar el alta del No Socio.
                // Validamos que el DNI no este registardo.

                if (NuevoNoSocio.ExisteDni(dni, out error))
                {
                    MessageBox.Show($"Cuidado Dato Duplicado: Ya existe un No Socio registrado con el DNI {dni}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Si llegamos aca, el DNI ingresado no esta duplicado y los datos estan validados.
                // Agregamos una Ventana de Confirmación para confirmar el Nuevo alta del No Socio.
                DialogResult result = MessageBox.Show(
                    $"¿Seguro que deseas dar de alta a {nombre} {apellido} DNI: {dni}? ",
                    "Confirmar Alta",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.No)
                {
                    return;
                }

                // Carga de datos y registro del No Socio en la base de datos.

                NuevoNoSocio.Dni = dni;
                NuevoNoSocio.Nombre = nombre;
                NuevoNoSocio.Apellido = apellido;
                NuevoNoSocio.FechaNacimiento = fechaNacimiento;
                NuevoNoSocio.AptoMedico = aptoMedico;
                string EstadoAlta = NuevoNoSocio.RegistrarNoSocio();

                //Si el proceso se completo correctamente, la ventana procede a cerrarse.
                if (EstadoAlta == "OK")
                {
                    MessageBox.Show($"No Socio: {nombre} {apellido} registrado exitosamente.");
                    this.Close();
                }

            // Manejo de Errores en la Base de Datos y otras excepciones.
                else
                {
                    MessageBox.Show("No se pudo registrar el No Socio.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado durante el registro del No Socio:\n{ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
