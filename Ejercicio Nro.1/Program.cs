using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> idEstudiante = new List<int>();
            bool salir = false;

            Console.ReadKey();
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("1. agregar estudiante");
                    Console.WriteLine("2. mostrar estudiantes");
                    Console.WriteLine("\n0. salir");
                    byte opc = Convert.ToByte(Console.ReadLine());

                    switch (opc)
                    {
                        case 0:
                            Console.Clear();
                            salir = true;
                            break;
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Ingrese el Id de estudiante");
                            int id = Convert.ToInt32(Console.ReadLine());
                            if(idEstudiante.Count < 30)
                            {
                                bool duplicado = false;
                                foreach(var item in idEstudiante)
                                {
                                    if(item == id)
                                    {
                                        _Mensaje("El estudiante ya esta registrado");
                                        duplicado = true;
                                    }
                                    else { }
                                }
                                if (duplicado == false)
                                {
                                    idEstudiante.Add(id);
                                }
                            }
                            else
                            {
                                _Mensaje("ha alcanzado el limite maximo de estudiantes (30)");
                            }
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Lista de estudiantes por ID");
                            BubbleSort(idEstudiante);
                            if (idEstudiante.Count > 0)
                            {
                                foreach(var item in idEstudiante)
                                {
                                    Console.WriteLine(item);
                                }
                                Console.ReadKey();
                            }
                            else
                            {
                                _Mensaje("La lista de estudiantes se encuentra vacia");
                            }
                            break;
                        default:
                            _Mensaje("Error! opcion invalida");
                            break;
                    }
                }
                catch (FormatException) { _Mensaje("Error! ingrese un valor valido"); }
                catch (IndexOutOfRangeException) { _Mensaje("Error! ingrese un valor valido"); }
                catch (OverflowException) { _Mensaje("Error! ingrese un valor valido"); }
            } while (!salir);
            void _Mensaje(string pMensaje)
            {
                Console.Clear();
                Console.WriteLine(pMensaje);
                Console.ReadKey();
            }
             void BubbleSort( List<int> pLista)
            {
                for (int i = 0; i < pLista.Count - 1; i++)
                {
                    for (int j = 0; j < pLista.Count - i - 1; j++)
                        if (pLista[j] > pLista[j + 1])
                        {
                            var tempVar = pLista[j];
                            pLista[j] = pLista[j + 1];
                            pLista[j + 1] = tempVar;
                        }
                }
            }
        }
    }
}
