using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro._3
{
    public class Cliente
    {
        public int numeroCuenta { get; set; }
        public double saldo { get; set; }
        public string nombre { get; set; }

        public Cliente(int Nro, double saldo, string nombre)
        {
            this.numeroCuenta = Nro;
            this.saldo = saldo;
            this.nombre = nombre;
        }
    }
}
