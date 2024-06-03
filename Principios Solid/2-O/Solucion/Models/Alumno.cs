using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios_Solid._2_O.Solucion.Models
{
    public class Alumno
    {
        public string Nombre { get; set; } = null!;
        public string Sexo { get; set; } = null!;
        public byte Grado { get; set; }
        public byte Edad { get; set; }
    }

}
