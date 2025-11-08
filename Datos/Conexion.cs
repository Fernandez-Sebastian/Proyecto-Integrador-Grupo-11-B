using MySql.Data.MySqlClient;
// --------------------

namespace Proyecto_Integrador_Grupo_11_B.Datos
{
    public class Conexion // la clase debe ser PUBLICA
    {
        // declaramos las variables
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;
        public Conexion(string servidor, string puerto, string usuario, string clave)
        {
            this.baseDatos = "ClubDeportivo";
            this.servidor = servidor;
            this.puerto = puerto;
            this.usuario = usuario;
            this.clave = clave;
        }
        public static void Inicializar(string servidor, string puerto, string usuario, string clave)
        {
            con = new Conexion(servidor, puerto, usuario, clave);
        }
        public static Conexion getInstancia()
        {
            if (con == null)
            {
                MessageBox.Show("No se ha configurado la conexión a la base de datos.");
                throw new InvalidOperationException("La conexión no ha sido inicializada.");
            }
            return con;
        }
        // proceso de interacción
        public MySqlConnection CrearConexion()
        {
            // instanciamos una conexion
            MySqlConnection? cadena = new MySqlConnection();
            // el bloque try permite controlar errores
            try
            {
                cadena.ConnectionString = "datasource=" + this.servidor +
                ";port=" + this.puerto +
                ";username=" + this.usuario +
                ";password=" + this.clave +
                ";Database=" + this.baseDatos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cadena = null;
                throw;
            }
            return cadena;
        }
        public bool ProbarConexion()
        {
            try
            {
                using (var conn = CrearConexion())
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}

