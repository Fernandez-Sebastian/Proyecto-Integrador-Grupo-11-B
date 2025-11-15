using MySql.Data.MySqlClient;
using Proyecto_Integrador_Grupo_11_B.Datos;

namespace Proyecto_Integrador_Grupo_11_B.Class
{
    public class Carnet
    {
        public Carnet(Socio socio, int idSocio)
        {
            this.Socio = socio;
            this.IdSocio = idSocio;

            GetCarnetSocio(idSocio);
        }

        private readonly string ResulOk = "OK";

        public DateTime FechaEmision { get; set; }

        public DateTime FechaVencimiento { get; set; }

        public int Numero { get; set; }

        public int IdSocio { get; set; }

        public Socio Socio { get; set; }

        /// <summary>
        /// Método que crea el registro del carnet en la tabla carnet para el socio 
        /// nuevo registrado
        /// </summary>
        /// <param name="dni">dni del socio registrado</param>
        /// <param name="idSocio">idSocio de la tabla socio correspondiente al socio</param>
        /// <returns></returns>
        public string GenerarCarnet(string dni, int idSocio)
        {
            try
            {
                // Creamos la conexión usando la clase Conexion.
                // Al estar dentro de using si hay un error en la conexión o termina el bloque de codigo, la conexión finaliza.
                using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
                {
                    conn.Open();

                    //se genera registro para carnet con datos del socio
                    string SQL = "INSERT INTO CARNET (FechaEmision, FechaVencimiento, Numero, IdSocio) " +
                                 "VALUES (@FechaEmision, @FechaVencimiento, @Numero, @IdSocio)";

                    FechaEmision = DateTime.Now; //fecha actual
                    FechaVencimiento = DateTime.Now.AddYears(1); //fecha actual + 1 año

                    using (MySqlCommand cmd = new MySqlCommand(SQL, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdSocio", idSocio);
                        cmd.Parameters.AddWithValue("@FechaEmision", FechaEmision.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@FechaVencimiento", FechaVencimiento.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@Numero", dni);

                        int filas = cmd.ExecuteNonQuery();

                        if (filas > 0)
                        {
                            //si se genera sin problemas retorna OK
                            return "OK";
                        }

                        //si no se logra insertar se retorna mensaje para el usuario
                        return "No se pudo generar el carnet del socio.";
                    }
                }
            }
            catch (Exception ex)
            {
                //se capturan errores de ejecución
                MessageBox.Show($"Error al generar el carnet del socio: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "ERROR: " + ex.Message;
            }
        }

        /// <summary>
        /// Método para buscar el carnet del socio 
        /// si encuentra retorna true sino false
        /// </summary>
        /// <param name="dni">Dni del socio</param>
        /// <returns></returns>
        private bool GetCarnetSocioByDni(string dni)
        {
            try
            {
                using var conn = Conexion.getInstancia().CrearConexion();
                conn.Open();

                //sonsulta de carnet por dni del socio
                const string SQL = @"
                    SELECT c.IdCarnet, c.FechaEmision, c.FechaVencimiento, c.Numero, c.IdSocio
                    FROM CARNET c
                    JOIN SOCIOS s ON s.IDSOCIO = c.IDSOCIO
                    WHERE s.DNI = @dni
                    LIMIT 1;";

                using var cmd = new MySqlCommand(SQL, conn);
                cmd.Parameters.Add("@dni", MySqlDbType.VarChar, 15).Value = dni;

                using var reader = cmd.ExecuteReader();

                //si encuentra registro para el carnet seteamos las propiedades de la clase
                //y se retorna true
                if (reader.Read())
                {
                    FechaEmision = Convert.ToDateTime(reader["FechaEmision"]);
                    FechaVencimiento = Convert.ToDateTime(reader["FechaVencimiento"]);
                    IdSocio = Convert.ToInt32(reader["IdSocio"]);
                    Numero = Convert.ToInt32(reader["Numero"]);
                    return true;
                }

                //si no lo encuentra se retorna false
                return false;
            }
            catch (Exception ex)
            {
                //capturamos errores de ejecución
                MessageBox.Show($"Error al buscar socio: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Método para actualizar el carnet vencido
        /// </summary>
        /// <param name="dni"></param>
        /// <returns></returns>
        public string ActualizarCarnet(string dni)
        {
            try
            {
                using var conn = Conexion.getInstancia().CrearConexion();
                conn.Open();

                //se actualiza para el carnet del socio las fechas de emisión y vencimiento
                const string SQL = @"
                    UPDATE Carnet
                        SET FechaEmision = @FechaEmision,
                            FechaVencimiento = @FechaVencimiento
                    WHERE NUMERO = @dni";

                FechaEmision = DateTime.Now; //fecha actual
                FechaVencimiento = DateTime.Now.AddYears(1); //fecha actual + 1 año

                using var cmd = new MySqlCommand(SQL, conn);
                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.Parameters.AddWithValue("@FechaEmision", FechaEmision.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@FechaVencimiento", FechaVencimiento.ToString("yyyy-MM-dd"));

                int filas = cmd.ExecuteNonQuery();

                if (filas > 0)
                {
                    //si se actualiza sin problemas retorna OK
                    return "OK";
                }

                //si no se logra actualizar se retorna mensaje para el usuario
                return "No se pudo actualizar el carnet del socio.";
            }
            catch (Exception ex)
            {
                //se capturan errores de ejecución
                MessageBox.Show($"Error al generar el carnet del socio: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "ERROR: " + ex.Message;
            }
        }

        /// <summary>
        /// Método para obtener el carnet del socio, si no existe se crea y si existe vencido se regenera con fecha actual
        /// por confirmación del usuario
        /// </summary>
        public void GetCarnetSocio(int idSocio)
        {
            string resultMessage;

            //consultamos si existe carnet para el socio por dni
            if (GetCarnetSocioByDni(Socio.Dni))
            {
                //verificamos si el carnet encontrado se encuentra vencido
                if (FechaVencimiento <= DateTime.Now)
                {
                    //se confirma con el usuario la actualización del carnet
                    DialogResult result = MessageBox.Show(
                        "El carnet del socio se encuentra vencido ¿Desea actualizar el carnet?",
                        "Confirmar actualización de carnet",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        //si se confirma se actualiza el carnet
                        resultMessage = ActualizarCarnet(Socio.Dni);

                        if (resultMessage != ResulOk)
                        {
                            //si ocurre algún error se muestra al usuario
                            MessageBox.Show(resultMessage);
                        }
                    }
                }
            }
            else
            {
                //si no existe carnet para el socio, se genera el carnet
                resultMessage = GenerarCarnet(Socio.Dni, idSocio);

                if (resultMessage != ResulOk)
                {
                    //si ocurre algún error se muestra al usuario
                    MessageBox.Show(resultMessage);
                }
            }
        }
    }
}
