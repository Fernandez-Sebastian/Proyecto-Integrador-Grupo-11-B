using MySql.Data.MySqlClient;
using Proyecto_Integrador_Grupo_11_B.Class;
using Proyecto_Integrador_Grupo_11_B.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Integrador_Grupo_11_B
{
    public partial class CobrarActividad : Form
    {
        private string medioDePagoSeleccionado;

        public CobrarActividad()
        {
            InitializeComponent();
            this.Load += CobrarActividad_Load;
            this.Shown += CobrarActividad_Shown;
            cmbActividad.SelectedIndexChanged += cmbActividad_SelectedIndexChanged;
            btnCobrar.Enabled = false;
            
            //Verificamos que los campos estén completos para que se habilite
            //el botón Cobrar
            txtDni.TextChanged += (s, e) => VerificarCamposCompletos();
            txtIdNoSocio.TextChanged += (s, e) => VerificarCamposCompletos();
            txtNombre.TextChanged += (s, e) => VerificarCamposCompletos();
            txtApellido.TextChanged += (s, e) => VerificarCamposCompletos();
            txtAptoMedico.TextChanged += (s, e) => VerificarCamposCompletos();

            // 🔒 Hacer campos de solo lectura
            txtIdNoSocio.ReadOnly = true;
            txtNombre.ReadOnly = true;
            txtApellido.ReadOnly = true;
            txtAptoMedico.ReadOnly = true;
        }

        private void CobrarActividad_Load(object sender, EventArgs e)
        {
            List<Actividad> listaActividades = new List<Actividad>();

            using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT idActividad, Nombre FROM Actividad";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaActividades.Add(new Actividad
                            {
                                IdActividad = reader.GetInt32("idActividad"),
                                Nombre = reader.GetString("Nombre")
                            });
                        }
                    }

                    cmbActividad.DisplayMember = "Nombre"; // Lo que se ve en el ComboBox
                    cmbActividad.ValueMember = "IdActividad"; // El valor asociado a cada item
                    cmbActividad.DataSource = listaActividades;
                    cmbActividad.SelectedIndex = -1; // Para que no aparezca ninguna actividad seleccionada al inicio
                    txtPrecio.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar actividades: " + ex.Message);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text.Trim();
            if (!string.IsNullOrEmpty(dni))
            {
                // Supongamos que tenés un método que busca en la BD o en tu lista de NoSocios
                NoSocio ns = BuscarNoSocioPorDni(dni);

                if (ns != null)
                {
                    txtIdNoSocio.Text = ns.IdNoSocio.ToString();
                    txtDni.Text = ns.Dni;
                    txtNombre.Text = ns.Nombre;
                    txtApellido.Text = ns.Apellido;
                    txtAptoMedico.Text = ns.AptoMedico;
                }
                else
                {
                    MessageBox.Show("No se encontró el NoSocio con ese ID");
                }
            }
            else
            {
                MessageBox.Show("El ID ingresado no es válido");
            }
        }

        public NoSocio BuscarNoSocioPorDni(string dni)
        {
            NoSocio ns = null;

            using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM NoSocios WHERE Dni = @dni";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@dni", dni);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                ns = new NoSocio()
                                {
                                    IdNoSocio = reader.GetInt32("idNoSocio"),
                                    Dni = reader.GetString("Dni"),
                                    Nombre = reader.GetString("Nombre"),
                                    Apellido = reader.GetString("Apellido"),
                                    FechaNacimiento = reader.GetDateTime("FechaNacimiento"),
                                    AptoMedico = reader.GetString("AptoMedico"),
                                    IdActividad = reader.IsDBNull(reader.GetOrdinal("idActividad"))
                                                  ? (int?)null
                                                  : reader.GetInt32("idActividad")
                                };
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar NoSocio: " + ex.Message);
                }
            }

            return ns; // Devuelve null si no lo encuentra
        }

        private void cmbActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbActividad.SelectedIndex != -1)
            {
                int idActividad = Convert.ToInt32(cmbActividad.SelectedValue);
                CargarPrecioActividad(idActividad);
                VerificarCamposCompletos();
            }
        }

        private void CargarPrecioActividad(int idActividad)
        {
            using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT PrecioActividad FROM Actividad WHERE idActividad = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idActividad);

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            double precio = Convert.ToDouble(result);
                            txtPrecio.Text = precio.ToString("0.00"); // Mostramos con dos decimales
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el precio de la actividad: " + ex.Message);
                }
            }
        }

        private void rdbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEfectivo.Checked)
                medioDePagoSeleccionado = "Efectivo";
            VerificarCamposCompletos();

        }

        private void rdbTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTarjeta.Checked)
                medioDePagoSeleccionado = "Tarjeta";
            VerificarCamposCompletos();

        }

        private void rdbMercadoPago_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMercadoPago.Checked)
                medioDePagoSeleccionado = "Mercado Pago";
            VerificarCamposCompletos();

        }

        private void CobrarActividad_Shown(object sender, EventArgs e)
        {
            txtDni.Focus();
        }

        private void VerificarCamposCompletos()
        {
            bool datosCompletos =
                !string.IsNullOrWhiteSpace(txtDni.Text) &&
                !string.IsNullOrWhiteSpace(txtIdNoSocio.Text) &&
                !string.IsNullOrWhiteSpace(txtNombre.Text) &&
                !string.IsNullOrWhiteSpace(txtApellido.Text) &&
                !string.IsNullOrWhiteSpace(txtAptoMedico.Text) &&
                txtAptoMedico.Text.Trim().ToUpper() == "S" &&
                cmbActividad.SelectedIndex != -1 &&
                !string.IsNullOrWhiteSpace(txtPrecio.Text) &&
                !string.IsNullOrWhiteSpace(medioDePagoSeleccionado);

            btnCobrar.Enabled = datosCompletos;
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrEmpty(txtApellido.Text) ||
                cmbActividad.SelectedIndex == -1 ||
                string.IsNullOrEmpty(txtPrecio.Text) ||
                string.IsNullOrEmpty(medioDePagoSeleccionado))
            {
                MessageBox.Show("Debe completar todos los datos antes de cobrar.");
                return;
            }

            // Crear el objeto comprobante
            var comprobante = new ComprobanteDePago(
                txtIdNoSocio.Text,
                txtNombre.Text,
                txtApellido.Text,
                cmbActividad.Text,
                Convert.ToDouble(txtPrecio.Text),
                medioDePagoSeleccionado
            );

            // Abrir el nuevo formulario del comprobante
            FrmComprobantePago frm = new FrmComprobantePago(comprobante);
            frm.ShowDialog();
        }

    }
}
