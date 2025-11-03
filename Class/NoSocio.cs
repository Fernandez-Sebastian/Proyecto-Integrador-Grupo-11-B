using MySql.Data.MySqlClient;
using Proyecto_Integrador_Grupo_11_B.Datos;

namespace Proyecto_Integrador_Grupo_11_B.Class
{
    public class NoSocio : Persona
    {
        public DateTime FechaNacimiento { get; set; }
        public string AptoMedico { get; set; }
        public int IdNoSocio { get; set; }
        public int? IdActividad { get; set; }
        public string RegistrarNoSocio()
        {
            try
            {
                // Creamos la conexión usando la clase Conexion.
                // Al estar todo dentro de using si hay un error en la conexión o termina el bloque de codigo, la conexión finaliza.
                using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
                {
                    conn.Open();

                    string SQL = "INSERT INTO NoSocios (Dni, Nombre, Apellido, FechaNacimiento, AptoMedico) " +
                                 "VALUES (@dni, @nombre, @apellido, @fechaNacimiento, @aptoMedico)";

                    using (MySqlCommand cmd = new MySqlCommand(SQL, conn))
                    {
                        cmd.Parameters.AddWithValue("@dni", Dni);
                        cmd.Parameters.AddWithValue("@nombre", Nombre);
                        cmd.Parameters.AddWithValue("@apellido", Apellido);
                        cmd.Parameters.AddWithValue("@fechaNacimiento", FechaNacimiento.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@aptoMedico", AptoMedico);

                        int filas = cmd.ExecuteNonQuery();

                        if (filas > 0)
                        {
                            return "OK";
                        }
                        return "No se pudo registrar el No Socio.";
                    }
                }
            }
            catch (Exception ex)
            {
                return "ERROR: " + ex.Message;
            }
        }

        // Función que devuelve true o false si existe en la base de datos el DNI ingresado.
        // Validar si el DNI ya existe
        public bool ExisteDni(string Dni, out string error)
        {
            try
            {
                using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
                {
                    conn.Open();
                    string SQL = "SELECT COUNT(*) FROM NoSocios WHERE Dni = @dni";

                    using (MySqlCommand cmd = new MySqlCommand(SQL, conn))
                    {
                        cmd.Parameters.AddWithValue("@dni", Dni);
                        int cantidad = Convert.ToInt32(cmd.ExecuteScalar());
                        error = string.Empty;
                        return cantidad > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                error = "ERROR " + ex.Message;
                return false;
            }
        }
    }
}

