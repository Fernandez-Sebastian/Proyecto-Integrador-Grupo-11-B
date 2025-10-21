using MySql.Data.MySqlClient;
using Proyecto_Integrador_Grupo_11_B.Datos;

namespace Proyecto_Integrador_Grupo_11_B.Class
{
    internal class Socio : Persona
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
        public string ExisteDni(string Dni)
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
                        if(cantidad > 0)
                        {
                            return "S";
                        }
                        return "N";
                    }
                }
            }
            catch (Exception ex)
            {
                return "ERROR: " + ex.Message;
            }
        }

        // Seteo los campos heredados
        public void SetDatosPersona(string dni, string nombre, string apellido)
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

    }
}
