using MySql.Data.MySqlClient;
using Proyecto_Integrador_Grupo_11_B.Class;
using System.Net;

namespace Proyecto_Integrador_Grupo_11_B
{
    public partial class CobrarCuota : Form
    {
        public CobrarCuota()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BuscarSocio_Click(object sender, EventArgs e)
        {
            try
            {
                // Se crea una instancia la clase Socio.
                Socio BuscarSocio = new();
                string dni = txtDni.Text.Trim();
                // Declaramos la variable para capturar y mostrar el error.
                string error = "";
                if (BuscarSocio.ExisteDni(dni, out error))
                {
                    BuscarSocio.GetSocio(txtDni.Text);
                    textNumeroSocio.Text = BuscarSocio.idSocio;
                    txtNombre.Text = BuscarSocio.Nombre;
                    txtApellido.Text = BuscarSocio.Apellido;
                    txtFechaPagoCuota.Text = BuscarSocio.FechaPagoCuota;
                    txtHabilitado.Text = BuscarSocio.Habilitado;
                }
                else
                {
                    MessageBox.Show("No existe el Socio");
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

        private void VolverMenu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "¿Seguro que deseas volver al menú principal? Se cancelará pago de cuota actual",
               "Confirmar salida",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
           );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BuscarDeuda_Click(object sender, EventArgs e)
        {
            // Bloquear el campo DNI para que no se pueda modificar
            txtDni.Enabled = false;

            // Guardar el idSocio en una variable
            int idSocio = int.Parse(textNumeroSocio.Text);

            // Limpiar ComboBox antes de llenar
            comboBoxCuotas.Items.Clear();

            // Obtener la lista de cuotas adeudadas (la conexión se maneja dentro del método)
            List<Cuota> cuotasAdeudadas = Cuota.BuscarCuotasAdeudadas(idSocio);

            // Llenar ComboBox
            foreach (Cuota c in cuotasAdeudadas)
            {
                comboBoxCuotas.Items.Add(c);
            }

            // Opcional: seleccionar la primera cuota
            if (comboBoxCuotas.Items.Count > 0)
                comboBoxCuotas.SelectedIndex = 0;
        }

        private void PagarCuota_Click(object sender, EventArgs e)
        {

        }
    }
}
