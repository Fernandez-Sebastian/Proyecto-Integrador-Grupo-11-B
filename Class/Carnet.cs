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

                    string SQL = "INSERT INTO CARNET (FechaEmision, FechaVencimiento, Numero, IdSocio) " +
                                 "VALUES (@FechaEmision, @FechaVencimiento, @Numero, @IdSocio)";

                    FechaEmision = DateTime.Now;
                    FechaVencimiento = DateTime.Now.AddYears(1);

                    using (MySqlCommand cmd = new MySqlCommand(SQL, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdSocio", idSocio);
                        cmd.Parameters.AddWithValue("@FechaEmision", FechaEmision.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@FechaVencimiento", FechaVencimiento.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@Numero", dni);

                        int filas = cmd.ExecuteNonQuery();

                        if (filas > 0)
                        {
                            return "OK";
                        }
                        return "No se pudo generar el carnet del socio.";
                    }
                }
            }
            catch (Exception ex)
            {
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

                const string SQL = @"
                    SELECT c.IdCarnet, c.FechaEmision, c.FechaVencimiento, c.Numero, c.IdSocio
                    FROM CARNET c
                    JOIN SOCIOS s ON s.IDSOCIO = c.IDSOCIO
                    WHERE s.DNI = @dni
                    LIMIT 1;";

                using var cmd = new MySqlCommand(SQL, conn);
                cmd.Parameters.Add("@dni", MySqlDbType.VarChar, 15).Value = dni;

                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    FechaEmision = Convert.ToDateTime(reader["FechaEmision"]);
                    FechaVencimiento = Convert.ToDateTime(reader["FechaVencimiento"]);
                    IdSocio = Convert.ToInt32(reader["IdSocio"]);
                    Numero = Convert.ToInt32(reader["Numero"]);
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
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

                const string SQL = @"
                    UPDATE Carnet
                        SET FechaEmision = @FechaEmision,
                            FechaVencimiento = @FechaVencimiento
                    WHERE NUMERO = @dni";

                FechaEmision = DateTime.Now;
                FechaVencimiento = DateTime.Now.AddYears(1);

                using var cmd = new MySqlCommand(SQL, conn);
                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.Parameters.AddWithValue("@FechaEmision", FechaEmision.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@FechaVencimiento", FechaVencimiento.ToString("yyyy-MM-dd"));

                int filas = cmd.ExecuteNonQuery();

                if (filas > 0)
                {
                    return "OK";
                }

                return "No se pudo generar el carnet del socio.";
            }
            catch (Exception ex)
            {
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

            if (GetCarnetSocioByDni(Socio.Dni))
            {
                if (FechaVencimiento <= DateTime.Now)
                {
                    DialogResult result = MessageBox.Show(
                        "El carnet del socio se encuentra vencido ¿Desea actualizar el carnet?",
                        "Confirmar actualización de carnet",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        resultMessage = ActualizarCarnet(Socio.Dni);

                        if (resultMessage != ResulOk)
                        {
                            MessageBox.Show(resultMessage);
                        }
                    }
                }
            }
            else
            {
                resultMessage = GenerarCarnet(Socio.Dni, idSocio);

                if (resultMessage != ResulOk)
                {
                    MessageBox.Show(resultMessage);
                }
            }
        }
    }
}
