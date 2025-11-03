using MySql.Data.MySqlClient;
using Proyecto_Integrador_Grupo_11_B.Datos;
using System.Globalization;

namespace Proyecto_Integrador_Grupo_11_B.Class
{
    public class Cuota
    {
        // Atributos de cuota
        public int IdCuota { get; set; }
        public int IdSocio { get; set; }
        public int NumeroCuota { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public DateTime? FechaPago { get; set; }
        public float Monto { get; set; }
        public string MetodoPago { get; set; } = "";
        public string Estado { get; set; } = "Impaga";
        public string Vigente { get; set; } = "N";
        public string CantidadCuotaFinanciada { get; set; } = "1";



        // Método para buscar cuotas adeudadas por idSocio
        public static List<Cuota> BuscarCuotasAdeudadas(int idSocio, string Fecha = "" )
        {
            List<Cuota> lista = new List<Cuota>();

            string FiltroFecha = "";
            if (Fecha!= "")
            {
                DateTime fecha = DateTime.ParseExact(Fecha, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                // Convertir al formato yyyy-MM-dd
                string fechaFormateada = fecha.ToString("yyyy-MM-dd");
                FiltroFecha = $" AND cuota.FechaInicio <= '{fechaFormateada}'";
            }

            string query = $@"
                SELECT cuota.idCuota, cuota.NumeroCuota, socios.idSocio, socios.Nombre, socios.Apellido, socios.Dni, 
	                IF(cuota.FechaInicio='0000-00-00', NULL, cuota.FechaInicio) AS FechaInicio,
                    IF(cuota.FechaFin='0000-00-00', NULL, cuota.FechaFin) AS FechaFin,
                    IF(cuota.FechaPago='0000-00-00', NULL, cuota.FechaPago) AS FechaPago, 
                    cuota.Monto, cuota.Vigente, cuota.MetodoPago, cuota.Estado, socios.Habilitado
                FROM cuota 
                INNER JOIN socios ON (socios.idSocio = cuota.idSocio)
                WHERE cuota.idSocio = @idSocio AND cuota.Estado = 'Impaga'
                {FiltroFecha}
                ORDER BY cuota.FechaInicio ASC";

            try
            {
                using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idSocio", idSocio);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Cuota cuota = new Cuota
                                {
                                    IdCuota = reader.GetInt32("idCuota"),
                                    IdSocio = reader.GetInt32("idSocio"),
                                    NumeroCuota = reader.GetInt32("NumeroCuota"),
                                    FechaInicio = reader.IsDBNull(reader.GetOrdinal("FechaInicio")) ? (DateTime?)null : reader.GetDateTime("FechaInicio"),
                                    FechaFin = reader.IsDBNull(reader.GetOrdinal("FechaFin")) ? (DateTime?)null : reader.GetDateTime("FechaFin"),
                                    FechaPago = reader.IsDBNull(reader.GetOrdinal("FechaPago")) ? (DateTime?)null : reader.GetDateTime("FechaPago"),
                                    Monto = reader.GetFloat("Monto"),
                                    MetodoPago = reader.IsDBNull(reader.GetOrdinal("MetodoPago")) ? "" : reader.GetString("MetodoPago"),
                                    Vigente = reader.GetString("Vigente"),
                                    Estado = reader.GetString("Estado")
                                };

                                lista.Add(cuota);
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener cuotas: " + ex.Message);
            }

            return lista;
        }

        // Método para pagar Cuotas
        public static float PagarCuotas(List<Cuota> Cuotas, string metodoPago, string CantCuotaFinanciada = "1")
        {
            float TotalCuotasAbonadas = 0;
            try
            {
                using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
                {
                    conn.Open();
                    int ulimaNumeroCuota = 0;
                    string UltimaCuotaVigente = "N";
                    DateTime? ultimoFechaFin = null;
                    int idSocio = 0;
                    
                    foreach (Cuota cuota in Cuotas)
                    {
                        TotalCuotasAbonadas = + cuota.Monto;
                        
                        string query = @"
                            UPDATE cuota
                            SET 
                                Estado = @Estado,
                                FechaPago = @FechaPago,
                                CantidadCuotaFinanciada = @CantidadCuotaFinanciada,
                                MetodoPago = @MetodoPago
                            WHERE idCuota = @IdCuota";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@FechaPago", DateTime.Now.Date);
                            cmd.Parameters.AddWithValue("@MetodoPago", metodoPago);
                            cmd.Parameters.AddWithValue("@CantidadCuotaFinanciada", CantCuotaFinanciada);
                            cmd.Parameters.AddWithValue("@IdCuota", cuota.IdCuota);
                            cmd.Parameters.AddWithValue("@Estado", "Paga");
                            cmd.ExecuteNonQuery();
                        }

                        ulimaNumeroCuota = cuota.NumeroCuota;
                        UltimaCuotaVigente = cuota.Vigente;
                        idSocio = cuota.IdSocio;
                        ultimoFechaFin = cuota.FechaFin;
                    }

                    // si esta pagando la ultima cuota vigente
                    if (UltimaCuotaVigente == "S")
                    {
                        // busco si tiene deuda,
                        // si no tiene deuda cambio Habilitado = S al Socio 
                        // y creo una nueva cuota para el siguiente periodo
                        List<Cuota> cuotasAdeudadas = Cuota.BuscarCuotasAdeudadas(idSocio);
                        if (cuotasAdeudadas == null || cuotasAdeudadas.Count == 0)
                        {
                            ulimaNumeroCuota ++;
                            DateTime NuevaFechaInicio = ultimoFechaFin.Value.AddDays(1);
                            DateTime NuevaFechaFin= NuevaFechaInicio.AddDays(30);
                            string insertQuery = @"
                                INSERT INTO cuota
                                    (idSocio, NumeroCuota,  FechaInicio, FechaFin, Vigente, Estado)
                                    VALUES
                                    (@idSocio, @NumeroCuota, @FechaInicio, @FechaFin, 'S', 'Impaga')";

                            using (MySqlCommand cmdInsert = new MySqlCommand(insertQuery, conn))
                            {
                                cmdInsert.Parameters.AddWithValue("@idSocio", idSocio);
                                cmdInsert.Parameters.AddWithValue("@NumeroCuota", ulimaNumeroCuota);
                                cmdInsert.Parameters.AddWithValue("@FechaInicio", NuevaFechaInicio);
                                cmdInsert.Parameters.AddWithValue("@FechaFin", NuevaFechaFin);
                                cmdInsert.ExecuteNonQuery();
                            }

                            // Actualizo Habilitado S el socio
                            Socio SocioCuota = new();
                            string error = "";
                            SocioCuota.ActualizarDatosSocio(idSocio, "", out error);
                        }
                    }
                    MessageBox.Show("Todas las cuotas fueron actualizadas correctamente.",
                                    "Pago exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el pago: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return TotalCuotasAbonadas;
        }



        // Método para mostrar una descripción de la cuota en el ComboBox
       public override string ToString()
       {
            string fechaInicioStr = FechaInicio.HasValue ? FechaInicio.Value.ToShortDateString() : "Sin fecha";
            return $"Cuota {NumeroCuota} - Importe: {Monto} - Periodo: {fechaInicioStr} ";
       }

        // Crea al Socio un año de cuotas para pagar por adelantado
        public static float CrearUnAnioDeCuotasPagas(int idSocio, string metodoPago, string CantCuotaFinanciada = "1")
        {
            float TotalCuotasAbonadas = 0;
            List<Cuota> listaCuotasFuturas = new List<Cuota>();
            string query = @"
                SELECT cuota.idCuota, cuota.NumeroCuota, socios.idSocio, 
                    IF(cuota.FechaInicio='0000-00-00', NULL, cuota.FechaInicio) AS FechaInicio,
                    IF(cuota.FechaFin='0000-00-00', NULL, cuota.FechaFin) AS FechaFin,
                    IF(cuota.FechaPago='0000-00-00', NULL, cuota.FechaPago) AS FechaPago, 
                    cuota.Monto, cuota.Vigente, cuota.MetodoPago, cuota.Estado
                FROM cuota
                INNER JOIN socios ON socios.idSocio = cuota.idSocio
                WHERE cuota.idSocio = @idSocio AND cuota.Vigente = 'S'";

            try
            {
                using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
                {
                    conn.Open();

                    int ultimaNumeroCuota = 0;
                    DateTime? ultimoFechaFin = null;
                    int idCuota = 0;
                    float Monto  = 0;

                    // --- 1. Leer datos y llenar lista ---
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idSocio", idSocio);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Cuota cuota = new Cuota
                                {
                                    IdCuota = reader.GetInt32("idCuota"),
                                    IdSocio = reader.GetInt32("idSocio"),
                                    NumeroCuota = reader.GetInt32("NumeroCuota"),
                                    FechaInicio = reader.IsDBNull(reader.GetOrdinal("FechaInicio")) ? (DateTime?)null : reader.GetDateTime("FechaInicio"),
                                    FechaFin = reader.IsDBNull(reader.GetOrdinal("FechaFin")) ? (DateTime?)null : reader.GetDateTime("FechaFin"),
                                    FechaPago = reader.IsDBNull(reader.GetOrdinal("FechaPago")) ? (DateTime?)null : reader.GetDateTime("FechaPago"),
                                    Monto = reader.GetFloat("Monto"),
                                    MetodoPago = reader.IsDBNull(reader.GetOrdinal("MetodoPago")) ? "" : reader.GetString("MetodoPago"),
                                    Vigente = reader.GetString("Vigente"),
                                    Estado = reader.GetString("Estado")
                                };
                                listaCuotasFuturas.Add(cuota);

                                ultimaNumeroCuota = cuota.NumeroCuota;
                                ultimoFechaFin = cuota.FechaFin;
                                idCuota = cuota.IdCuota;
                                Monto = cuota.Monto;
                            }
                        }
                    }

                    if (listaCuotasFuturas.Count == 0)
                    {
                        MessageBox.Show("No se encontraron cuotas futuras vigentes para este socio.",
                                        "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // --- 2. Actualizar la última cuota vigente a "Paga" ---
                    string updateQuery = @"
                        UPDATE cuota 
                        SET FechaPago = @FechaPago,
                            MetodoPago = @MetodoPago,
                            Vigente = 'N',
                            CantidadCuotaFinanciada = @CantCuotaFinanciada,
                            Estado = 'Paga'
                        WHERE idCuota = @idCuota";

                    using (MySqlCommand cmdUpdate = new MySqlCommand(updateQuery, conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("@FechaPago", DateTime.Now.Date);
                        cmdUpdate.Parameters.AddWithValue("@MetodoPago", metodoPago);
                        cmdUpdate.Parameters.AddWithValue("@CantCuotaFinanciada", CantCuotaFinanciada);
                        cmdUpdate.Parameters.AddWithValue("@idCuota", idCuota);
                        cmdUpdate.ExecuteNonQuery();
                    }

                    // Sumo al total abonado la primer cuota.
                    TotalCuotasAbonadas =+ Monto;

                    // --- 3. Crear 11 cuotas pagas adicionales ---
                    DateTime? fechaInicioNueva = ultimoFechaFin;
                    int numeroCuota = ultimaNumeroCuota;
                    
                    for (int i = 0; i < 11; i++)
                    {
                        numeroCuota++;
                        DateTime fechaFinNueva = fechaInicioNueva.Value.AddMonths(1);

                        string insertQuery = @"
                            INSERT INTO cuota
                                (idSocio, NumeroCuota, FechaInicio, FechaFin, FechaPago, MetodoPago, CantidadCuotaFinanciada, Estado, Vigente)
                            VALUES
                                (@idSocio, @NumeroCuota, @FechaInicio, @FechaFin, @FechaPago, @MetodoPago, @CantidadCuotaFinanciada, @Estado, @Vigente)";

                        using (MySqlCommand cmdInsert = new MySqlCommand(insertQuery, conn))
                        {
                            cmdInsert.Parameters.AddWithValue("@idSocio", idSocio);
                            cmdInsert.Parameters.AddWithValue("@NumeroCuota", numeroCuota);
                            cmdInsert.Parameters.AddWithValue("@FechaInicio", fechaInicioNueva);
                            cmdInsert.Parameters.AddWithValue("@FechaFin", fechaFinNueva);
                            cmdInsert.Parameters.AddWithValue("@FechaPago", DateTime.Now.Date);
                            cmdInsert.Parameters.AddWithValue("@MetodoPago", metodoPago);
                            cmdInsert.Parameters.AddWithValue("@CantidadCuotaFinanciada", CantCuotaFinanciada);
                            cmdInsert.Parameters.AddWithValue("@Estado", "Paga");
                            cmdInsert.Parameters.AddWithValue("@Vigente", "N");
                            cmdInsert.ExecuteNonQuery();
                        }
                        TotalCuotasAbonadas = +Monto;
                        fechaInicioNueva = fechaFinNueva;
                    }

                    // --- 4. Crear última cuota impaga y vigente ---
                    numeroCuota++;
                    DateTime fechaFinFinal = fechaInicioNueva.Value.AddMonths(1);

                    string insertUltima = @"
                        INSERT INTO cuota
                            (idSocio, NumeroCuota, FechaInicio, FechaFin, Estado, Vigente)
                        VALUES
                            (@idSocio, @NumeroCuota, @FechaInicio, @FechaFin, @Estado, @Vigente)";

                    using (MySqlCommand cmdUltima = new MySqlCommand(insertUltima, conn))
                    {
                        cmdUltima.Parameters.AddWithValue("@idSocio", idSocio);
                        cmdUltima.Parameters.AddWithValue("@NumeroCuota", numeroCuota);
                        cmdUltima.Parameters.AddWithValue("@FechaInicio", fechaInicioNueva);
                        cmdUltima.Parameters.AddWithValue("@FechaFin", fechaFinFinal);
                        cmdUltima.Parameters.AddWithValue("@Estado", "Impaga");
                        cmdUltima.Parameters.AddWithValue("@Vigente", "S");
                        cmdUltima.ExecuteNonQuery();
                    }

                    MessageBox.Show("Todas las cuotas fueron actualizadas correctamente.",
                                    "Pago Anual exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener cuotas: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return TotalCuotasAbonadas;
        }
    }
}
