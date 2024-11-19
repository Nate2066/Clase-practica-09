using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro._2
{
    public class Tarea
    {
        public string asunto { get; set; }
        public string prioridad { get; set; }

        public Tarea(string asunto, byte prioridad)
        {
            this.asunto = asunto;
            if(prioridad == 1) { this.prioridad = "Alto"; }
            if (prioridad == 2) { this.prioridad = "Medio"; }
            if (prioridad == 3) { this.prioridad = "Bajo"; }
        }
    }
}
