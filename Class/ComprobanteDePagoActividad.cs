using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto_Integrador_Grupo_11_B.Class
{
    public class ComprobanteDePagoActividad : ComprobanteDePago
    {
        public string IdNoSocio { get; set; }
        public string Actividad { get; set; }
        public ComprobanteDePagoActividad(
            string idNoSocio, 
            string actividad, 
            string nombre, 
            string apellido, 
            double precio, 
            string medioDePago
        ) :base(nombre, apellido, precio, medioDePago)
        {
            IdNoSocio = idNoSocio;
            Actividad = actividad;
        }
    }
}
