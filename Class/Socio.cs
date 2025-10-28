using MySql.Data.MySqlClient;
using Proyecto_Integrador_Grupo_11_B.Datos;

namespace Proyecto_Integrador_Grupo_11_B.Class
{
    internal class Socio : Persona
    {
        public DateTime FechaNacimiento { get; set; }
        public string AptoMedico { get; set; }
        public string Habilitado { get; set; }
        public string FechaPagoCuota { get; set; }
        public string idSocio { get; set; }

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
        public bool ExisteDni(string Dni, out string error )
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

        // Devolver Socio
        public bool GetSocio(string dni)
        {
            try
            {
                using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
                {
                    conn.Open();
                    string SQL = "SELECT * FROM Socios WHERE Dni = @dni LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(SQL, conn))
                    {
                        cmd.Parameters.AddWithValue("@dni", dni);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                this.Dni = reader["Dni"].ToString();
                                this.Nombre = reader["Nombre"].ToString();
                                this.Apellido = reader["Apellido"].ToString();
                                this.FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]);
                                this.AptoMedico = reader["AptoMedico"].ToString();
                                this.FechaPagoCuota = reader["FechaPagoCuota"].ToString();
                                this.Habilitado = reader["Habilitado"].ToString();
                                this.idSocio = reader["idSocio"].ToString();
                                return true;
                            }
                        }
                    }
                }

                return false; // no se encontró
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener socio: " + ex.Message);
                return false;
            }
        }


    }
}
