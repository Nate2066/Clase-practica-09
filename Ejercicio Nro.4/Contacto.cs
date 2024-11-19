using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro._4
{
    public class Contacto
    {
        public string nombre { get; set; }
        public List<int> numeros = new List<int>();

        public Contacto(string nombre, int numero)
        {
            this.nombre = nombre;
            numeros.Add(numero);
        }
    }
}
