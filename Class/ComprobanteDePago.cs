using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Integrador_Grupo_11_B.Class
{
    public class ComprobanteDePago
    {
        public string IdNoSocio { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Actividad { get; set; }
        public double Precio { get; set; }
        public string MedioDePago { get; set; }
        public DateTime Fecha { get; set; }

        public ComprobanteDePago(string idNoSocio, string nombre, string apellido, string actividad, double precio, string medioDePago)
        {
            IdNoSocio = idNoSocio;
            Nombre = nombre;
            Apellido = apellido;
            Actividad = actividad;
            Precio = precio;
            MedioDePago = medioDePago;
            Fecha = DateTime.Now;
        }
    }
}
