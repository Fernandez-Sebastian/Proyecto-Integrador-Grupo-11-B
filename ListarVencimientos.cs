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
            //si selecciona fecha actual se toma fecha del sistema sino la fecha seleccionada
            DateTime fechaConsultar = rbFechaActual.Checked ? DateTime.Now : dtFechaSeleccionada.Value;

            //se valida que la fecha ingresada sea mayor o igual a la fecha actual
            if (fechaConsultar.Date >= DateTime.Now.Date)
            {
                CargarGrillaDeudores(fechaConsultar);
            }
            else
            {
                MessageBox.Show("La fecha seleccionada no puede ser anterior a la fecha actual.");
            }

        }

        /// <summary>
        /// Método que dada una fecha consulta socios con cuotas a vencer en esa fecha 
        /// </summary>
        /// <param name="fechaLista"></param>
        /// <returns></returns>
        private static MySqlDataReader GetListaSociosDeudores(DateTime fechaLista)
        {
            //usamos el sp sp_listar_deudores_por_fecha para consultar
            //socios cuya cuota vence en p_fecha = fecha seleccionada
            MySqlConnection sqlCon;
            sqlCon = Conexion.getInstancia().CrearConexion();
            MySqlCommand comando = new("sp_listar_deudores_por_fecha", sqlCon);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@p_fecha", fechaLista.ToString("yyyy-MM-dd"));
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
            //se consultan los socios con cuotas a vencer en la fecha seleccionada
            MySqlDataReader sociosDeudores = GetListaSociosDeudores(fechaLista);

            //limpiamos registros anteriores
            dataGridViewSociosDeudores.Rows.Clear();

            //si la consulta devuelve registros cargamos la grilla
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
