using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Integrador_Grupo_11_B.Class
{
    public class NoSocio : Persona
    {
        public int IdNoSocio { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string AptoMedico { get; set; }
        public int? IdActividad { get; set; }
    }
}
