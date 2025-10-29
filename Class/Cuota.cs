using MySql.Data.MySqlClient;
using Proyecto_Integrador_Grupo_11_B.Datos;

namespace Proyecto_Integrador_Grupo_11_B.Class
{
    internal class Cuota
    {
        // Atributos de socio_tiene_cuotas
        public int Id { get; set; }
        public int IdSocio { get; set; }
        public int IdCuota { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public DateTime? FechaPago { get; set; }
        public float MontoAbonado { get; set; }
        public float Intereses { get; set; }
        public string MetodoPago { get; set; }
        public string Estado { get; set; }

        // Atributos de cuotas
        public int Periodo { get; set; }
        public float Importe { get; set; }

        // Constructor vacío
        public Cuota() { }

        // Método para buscar cuotas adeudadas por idSocio
        public static List<Cuota> BuscarCuotasAdeudadas(int idSocio)
        {
            List<Cuota> lista = new List<Cuota>();

            string query = @"
                SELECT stc.id, stc.idSocio, stc.idCuota, stc.FechaInicio, stc.FechaFin, 
                        stc.FechaPago, stc.MontoAbonado, stc.Intereses, stc.MetodoPago, stc.Estado,
                        c.Periodo, c.Importe
                FROM socio_tiene_cuotas stc
                INNER JOIN cuotas c ON stc.idCuota = c.idCuota
                WHERE stc.idSocio = @idSocio AND stc.Estado = 'Impaga'
                ORDER BY stc.FechaInicio ASC";

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
                                    Id = reader.GetInt32("id"),
                                    IdSocio = reader.GetInt32("idSocio"),
                                    IdCuota = reader.GetInt32("idCuota"),
                                    FechaInicio = reader.GetDateTime("FechaInicio"),
                                    FechaFin = reader.IsDBNull(reader.GetOrdinal("FechaFin")) ? (DateTime?)null : reader.GetDateTime("FechaFin"),
                                    FechaPago = reader.IsDBNull(reader.GetOrdinal("FechaPago")) ? (DateTime?)null : reader.GetDateTime("FechaPago"),
                                    MontoAbonado = reader.GetFloat("MontoAbonado"),
                                    Intereses = reader.GetFloat("Intereses"),
                                    MetodoPago = reader.IsDBNull(reader.GetOrdinal("MetodoPago")) ? null : reader.GetString("MetodoPago"),
                                    Estado = reader.GetString("Estado"),
                                    Periodo = reader.GetInt32("Periodo"),
                                    Importe = reader.GetFloat("Importe")
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

        // Método para mostrar una descripción de la cuota en el ComboBox
        public override string ToString()
        {
            return $"Cuota {Periodo} - Inicio: {FechaInicio.ToShortDateString()} - Importe: {Importe}";
        }
    }
}
