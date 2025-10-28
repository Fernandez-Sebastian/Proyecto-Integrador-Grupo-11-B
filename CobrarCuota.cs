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

        }
    }
}
