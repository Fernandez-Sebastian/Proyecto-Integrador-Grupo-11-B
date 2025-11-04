namespace Proyecto_Integrador_Grupo_11_B.Class
{
    public class ComprobanteDePagoCuotaSocio : ComprobanteDePago
    {
        public int idSocio { get; set; }
        public string Dni { get; set; }
        public int CantCuotasPagadas { get; set; }
        public string CantCuotasFinanciada { get; set; } = "1";

        public ComprobanteDePagoCuotaSocio(
            string nombre,
            string apellido,
            string dni,
            int numeroSocio,
            double total,
            int cantCuotasPagadas,
            string cantCuotasFinanciada,
            string MetodoDePago = ""
        ) : base(nombre, apellido, total, MetodoDePago)
        {
            Dni = dni;
            idSocio = numeroSocio;
            CantCuotasPagadas = cantCuotasPagadas;
            CantCuotasFinanciada = cantCuotasFinanciada;
        }
    }
}
