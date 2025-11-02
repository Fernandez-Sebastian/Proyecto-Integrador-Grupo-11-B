using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Integrador_Grupo_11_B.Class
{
    internal class Actividad
    {
        public int IdActividad { get; set; }
        public string Nombre { get; set; }
        public DateTime Dia { get; set; }
        public TimeSpan Horario { get; set; }
        public int Cupo { get; set; }
        public string ProfesorAsignado { get; set; }
        public double PrecioActividad { get; set; }
    }
}
