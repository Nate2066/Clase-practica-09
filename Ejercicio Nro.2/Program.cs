using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Tarea> listaTareas = new List<Tarea>();
            bool salir = false;

            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("1. agregar tarea");
                    Console.WriteLine("2. lista de tareas");
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
                            Console.WriteLine("Ingrese el asunto de la terea");
                            Console.Write(">>");
                            string asunto = Console.ReadLine();
                            if(asunto != "")
                            {
                                Console.WriteLine("Seleccione el nivel de prioridad para la tarea");
                                Console.WriteLine("\n1. Alto\n2. Medio\n3. Bajo");
                                Console.Write(">>");
                                byte prioridad = Convert.ToByte(Console.ReadLine());
                                if(prioridad > 0 && prioridad < 4)
                                {
                                    listaTareas.Add(new Tarea(asunto, prioridad));
                                }
                                else { _Mensaje("Tiene que ingresar una opcion"); }
                            }
                            else { _Mensaje("Tiene que ingresar una opcion"); }
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Tareas de Alta prioridad\n");
                            foreach(var item in listaTareas)
                            {
                                if(item.prioridad == "Alto")
                                {
                                    Console.WriteLine("  .{0}", item.asunto);
                                }
                            }
                            Console.WriteLine("\nTareas de prioridad Media\n");
                            foreach (var item in listaTareas)
                            {
                                if (item.prioridad == "Medio")
                                {
                                    Console.WriteLine("  .{0}", item.asunto);
                                }
                            }
                            Console.WriteLine("\nTareas de Baja prioridad\n");
                            foreach (var item in listaTareas)
                            {
                                if (item.prioridad == "Bajo")
                                {
                                    Console.WriteLine("  .{0}", item.asunto);
                                }
                            }
                            Console.ReadKey();
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
        }
    }
}
