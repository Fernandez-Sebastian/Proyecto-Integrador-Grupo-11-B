using Proyecto_Integrador_Grupo_11_B.Class;
using System;
using System.Windows.Forms;

namespace Proyecto_Integrador_Grupo_11_B
{
    public partial class RegistrarNoSocio : Form
    {
        public RegistrarNoSocio()
        {
            InitializeComponent();
            Tema.Aplicar(this);   // aplica el estilo
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
                NoSocio NuevoNoSocio = new();
                string error = "";

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
                if (fechaNacimiento.Date > DateTime.Today.AddYears(-edad)) edad--;

                if (fechaNacimiento > DateTime.Today)
                {
                    MessageBox.Show("La fecha de nacimiento no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (edad < 5)
                {
                    MessageBox.Show("El No Socio debe tener al menos 5 años.", "Edad no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (edad > 100)
                {
                    MessageBox.Show("La edad ingresada no es válida.", "Edad no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (NuevoNoSocio.ExisteDni(dni, out error))
                {
                    MessageBox.Show($"Ya existe un No Socio registrado con el DNI {dni}.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    $"¿Seguro que deseas dar de alta a {nombre} {apellido} DNI: {dni}? ",
                    "Confirmar salida",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.No)
                    return;

                NuevoNoSocio.Dni = dni;
                NuevoNoSocio.Nombre = nombre;
                NuevoNoSocio.Apellido = apellido;
                NuevoNoSocio.FechaNacimiento = fechaNacimiento;
                NuevoNoSocio.AptoMedico = aptoMedico;

                string EstadoAlta = NuevoNoSocio.RegistrarNoSocio();

                if (EstadoAlta == "OK")
                {
                    MessageBox.Show($"No Socio: {nombre} {apellido} registrado correctamente.");
                    this.Close();
                }
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

        private void lblTitulo_Click(object sender, EventArgs e)
        {
            // opcional
        }
    }
}
