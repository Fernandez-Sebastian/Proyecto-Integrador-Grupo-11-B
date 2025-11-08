using MySql.Data.MySqlClient;
using Proyecto_Integrador_Grupo_11_B.Datos;

namespace Proyecto_Integrador_Grupo_11_B
{
    public partial class ListarVencimientos : Form
    {
        public ListarVencimientos()
        {
            //inicializamos componentes del form
            InitializeComponent();
        }

        private void ListarVencimientos_Click(object sender, EventArgs e)
        {
            DateTime fechaConsultar = rbFechaActual.Checked ? DateTime.Now : dtFechaSeleccionada.Value;
            CargarGrillaDeudores(fechaConsultar);
        }

        /// <summary>
        /// Método que dada una fecha cnsulta socios con cuotas a vencer en esa fecha 
        /// </summary>
        /// <param name="fechaLista"></param>
        /// <returns></returns>
        private static MySqlDataReader GetListaSociosDeudores(DateTime fechaLista)
        {
            MySqlConnection sqlCon;
            sqlCon = Conexion.getInstancia().CrearConexion();
            MySqlCommand comando = new("sp_listar_deudores_por_fecha", sqlCon);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@p_fecha", fechaLista);
            sqlCon.Open();

            return comando.ExecuteReader();
        }

        /// <summary>
        /// Método que llena la grilla con los socios con cuotas a vencer obtenidos 
        /// para la fecha indicada
        /// y nro socio
        /// </summary>
        /// <param name="fechaLista"></param>
        public void CargarGrillaDeudores(DateTime fechaLista)
        {
            MySqlDataReader sociosDeudores = GetListaSociosDeudores(fechaLista);
            dataGridViewSociosDeudores.Rows.Clear();

            if (sociosDeudores.HasRows)
            {
                while (sociosDeudores.Read())
                {
                    int renglon = dataGridViewSociosDeudores.Rows.Add();
                    dataGridViewSociosDeudores.Rows[renglon].Cells[0].Value = sociosDeudores.GetString(0);  //Nombre
                    dataGridViewSociosDeudores.Rows[renglon].Cells[1].Value = sociosDeudores.GetString(1);  //Apellido
                    dataGridViewSociosDeudores.Rows[renglon].Cells[2].Value = sociosDeudores.GetString(2);  //Dni
                    dataGridViewSociosDeudores.Rows[renglon].Cells[3].Value = sociosDeudores.GetInt64(3);   //Cant Cuotas
                    dataGridViewSociosDeudores.Rows[renglon].Cells[4].Value = sociosDeudores.GetDateTime(4).ToString("dd-MM-yyyy");//Fecha vto cuota
                    dataGridViewSociosDeudores.Rows[renglon].Cells[5].Value = sociosDeudores.GetDecimal(5); //Monto deuda
                }
            }
            else
            {
                MessageBox.Show("Para la fecha seleccionada no existen socios con cuotas vencidas.");
            }
        }
    }
}
