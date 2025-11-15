using MySql.Data.MySqlClient;
using Proyecto_Integrador_Grupo_11_B.Datos;
using System.Globalization;

namespace Proyecto_Integrador_Grupo_11_B.Class
{
    public class Cuota
    {
        // Atributos de la clase cuota.
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



        // Método para buscar cuotas adeudadas por idSocio.
        public static List<Cuota> BuscarCuotasAdeudadas(int idSocio)
        {
            List<Cuota> lista = new List<Cuota>();

           string query = $@"
                SELECT cuota.idCuota, cuota.NumeroCuota, socios.idSocio, socios.Nombre, socios.Apellido, socios.Dni, 
	               cuota.FechaInicio, cuota.FechaFin, cuota.FechaPago, 
                   cuota.Monto, cuota.Vigente, cuota.MetodoPago, cuota.Estado, socios.Habilitado
                FROM cuota 
                INNER JOIN socios ON (socios.idSocio = cuota.idSocio)
                WHERE cuota.idSocio = @idSocio AND cuota.Estado = 'Impaga'
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

        // Método para pagar un listado de Cuotas.
        // Los parámetros identifican el método en que se pagaron las cuotas.
        // Y si financiaron el pago. Por defecto pagan todo en un solo pago.
        public static float PagarCuotas(List<Cuota> Cuotas, string metodoPago, string CantCuotaFinanciada = "1")
        {
            float TotalCuotasAbonadas = 0;
            try
            {
                using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
                {
                    // Abro la conexión a la base de Datos.
                    // Declaro e inicializo las variables a utilizar.
                    conn.Open();
                    int ultimaNumeroCuota = 0;
                    string UltimaCuotaVigente = "N";
                    DateTime? ultimoFechaFin = null;
                    int idSocio = 0;
                    float Monto = 45000;
                    
                    // Recorremos el listado de Cuotas y las actualizamos a PAGA con todos los datos adicionales.
                    foreach (Cuota cuota in Cuotas)
                    {
                        TotalCuotasAbonadas += Monto;

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

                        ultimaNumeroCuota = cuota.NumeroCuota;
                        UltimaCuotaVigente = cuota.Vigente;
                        idSocio = cuota.IdSocio;
                        ultimoFechaFin = cuota.FechaFin;
                    }
                   
                    // Busco deuda del Socio para determinar si está Habilitado luego de pagar las cuotas.
                    string Habilitado = "N";
                    string Estado = "Inhabilitado";
                    List<Cuota> cuotasAdeudadasHoy = Cuota.BuscarCuotasAdeudadas(idSocio);
                    if (cuotasAdeudadasHoy == null || cuotasAdeudadasHoy.Count == 0)
                    {
                        Habilitado = "S";
                        Estado = "Habilitado";
                    }
                    // Actualizo Habilitado del socio de acuerdo a si debe cuotas o no.
                    // Creo la instancia del Socio y uso sus métodos.
                    Socio SocioCuota = new();
                    string error = "";
                    SocioCuota.ActualizarDatosSocio(idSocio, Habilitado, out error);
                    
                    string Mensaje = $"Cuotas abonadas correctamente. " +
                                     $"El Socio Nro: {idSocio}, está {Estado} para el Ingreso al Club";

                    MessageBox.Show(Mensaje,
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



        // Re escribimos el método para mostrar una descripción personalizada
        // de la cuota en el ComboBox.
       public override string ToString()
       {
            string fechaInicioStr = FechaInicio.HasValue ? FechaInicio.Value.ToShortDateString() : "Sin fecha";
            return $"Cuota {NumeroCuota} - Importe: {Monto} - Periodo: {fechaInicioStr} ";
       }

        // Crea un año de cuotas y las paga por adelantado al Socio.
        public static float CrearUnAnioDeCuotasPagas(int idSocio, string metodoPago, string CantCuotaFinanciada = "1")
        {
            // Obtengo Última la cuota vigente.
            float TotalCuotasAbonadas = 0;
            List<Cuota> listaCuotasFuturas = new List<Cuota>();
            string query = @"
                SELECT cuota.idCuota, cuota.NumeroCuota, socios.idSocio, 
                    cuota.FechaInicio, cuota.FechaFin, cuota.FechaPago, 
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

                    // Leer datos y llenar lista
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idSocio", idSocio);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Recorro el resultado de la consulta a la base de datos.
                            // Creo una instancia de la cuota y la agrego a la lista.
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

                                // Guardo en variables los datos que me permiten crear las 12 cuotas para el Socio.
                                ultimaNumeroCuota = cuota.NumeroCuota;
                                ultimoFechaFin = cuota.FechaFin;
                                idCuota = cuota.IdCuota;
                                Monto = cuota.Monto;
                            }
                        }
                    }

                    if (listaCuotasFuturas.Count == 0)
                    {
                        MessageBox.Show("No se encontraron cuotas futuras para este Socio.",
                                        "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // Actualizar la última cuota vigente a "Paga".
                    string updateQuery = @"
                        UPDATE cuota 
                        SET Vigente = 'N'
                        WHERE idCuota = @idCuota";

                    using (MySqlCommand cmdUpdate = new MySqlCommand(updateQuery, conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("@idCuota", idCuota);
                        cmdUpdate.ExecuteNonQuery();
                    }

                    // Crear 11 cuotas pagas con vigente en N.
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
                        TotalCuotasAbonadas += Monto;

                        fechaInicioNueva = fechaFinNueva;
                    }

                    // Creo la cuota 12 Paga y vigente.
                    numeroCuota++;
                    DateTime fechaFinFinal = fechaInicioNueva.Value.AddMonths(1);

                    string insertUltima = @"
                        INSERT INTO cuota
                            (idSocio, NumeroCuota, FechaInicio, FechaFin, FechaPago, MetodoPago, Estado, Vigente)
                        VALUES
                            (@idSocio, @NumeroCuota, @FechaInicio, @FechaFin, @FechaPago, @MetodoPago, @Estado, @Vigente)";

                    using (MySqlCommand cmdUltima = new MySqlCommand(insertUltima, conn))
                    {
                        cmdUltima.Parameters.AddWithValue("@idSocio", idSocio);
                        cmdUltima.Parameters.AddWithValue("@NumeroCuota", numeroCuota);
                        cmdUltima.Parameters.AddWithValue("@FechaInicio", fechaInicioNueva);
                        cmdUltima.Parameters.AddWithValue("@FechaFin", fechaFinFinal);
                        cmdUltima.Parameters.AddWithValue("@FechaPago", DateTime.Now.Date);
                        cmdUltima.Parameters.AddWithValue("@MetodoPago", metodoPago);
                        cmdUltima.Parameters.AddWithValue("@Estado", "Paga");
                        cmdUltima.Parameters.AddWithValue("@Vigente", "S");
                        cmdUltima.ExecuteNonQuery();
                    }
                    TotalCuotasAbonadas += Monto;
                }
                // Actualizo al Socio al Estado Habilitado = S, ya que pago un año adelantado.
                // Creo la instancia del Socio y uso sus métodos.
                Socio SocioCuota = new();
                string error = "";
                SocioCuota.ActualizarDatosSocio(idSocio, "S", out error);

                string Mensaje = $"Se ha abonado un año por anticipado." +
                                 $" El Socio Nro: {idSocio}, está Habilitado para el Ingreso al Club";
                MessageBox.Show(Mensaje,
                                    "Pago exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
