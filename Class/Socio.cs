using MySql.Data.MySqlClient;
using Proyecto_Integrador_Grupo_11_B.Datos;

namespace Proyecto_Integrador_Grupo_11_B.Class
{
    public class Socio : Persona
    {
        public DateTime FechaNacimiento { get; set; }

        public string AptoMedico { get; set; }

        public string RegistrarSocio()
        {
            try
            {
                // Creamos la conexión usando la clase Conexion.
                // Al estar todo dentro de using si hay un error en la conexión o termina el bloque de codigo, la conexión finaliza.
                using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
                {
                    conn.Open();

                    string SQL = "INSERT INTO Socios (Dni, Nombre, Apellido, FechaNacimiento, AptoMedico) " +
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
                        return "No se pudo registrar el socio.";
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
                    string SQL = "SELECT COUNT(*) FROM Socios WHERE Dni = @dni";

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

        /// <summary>
        /// Método que obtiene el IdSocio a través del dni
        /// </summary>
        /// <param name="Dni">Dni del socio a buscar</param>
        /// <returns></returns>
        public static int GetIdSocioByDni(string Dni)
        {
            try
            {
                using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
                {
                    conn.Open();
                    string SQL = "SELECT IdSocio FROM Socios WHERE Dni = @dni";

                    using (MySqlCommand cmd = new MySqlCommand(SQL, conn))
                    {
                        cmd.Parameters.AddWithValue("@dni", Dni);
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar datos del socio: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        /// <summary>
        /// Método que instancia el socio dado un dni si lo encuentra en la 
        /// tabla socios
        /// </summary>
        /// <param name="dni"></param>
        /// <returns></returns>
        public static Socio? GetSocioByDni(string dni)
        {
            try
            {
                using var conn = Conexion.getInstancia().CrearConexion();
                conn.Open();

                const string SQL = @"
                    SELECT DNI, NOMBRE, APELLIDO
                    FROM SOCIOS
                    WHERE HABILITADO = 'S' AND DNI = @dni
                    LIMIT 1;";

                using var cmd = new MySqlCommand(SQL, conn);
                cmd.Parameters.Add("@dni", MySqlDbType.VarChar, 15).Value = dni;

                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Socio
                    {
                        Dni = reader["Dni"].ToString(),
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString()
                    };
                }

                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar socio: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
