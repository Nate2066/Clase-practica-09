using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Contacto> contactos = new List<Contacto>();
            bool salir = false;

            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("1. agregar nuevo contacto");
                    Console.WriteLine("2. editar contacto");
                    Console.WriteLine("3. mostrar lista de contactos");
                    Console.WriteLine("\n0. salir");
                    byte opc = Convert.ToByte(Console.ReadLine());

                    switch (opc)
                    {
                        case 0:
                            Console.Clear();
                            salir = true;
                            break;
                        case 1:
                            bool volver = false;
                            do
                            {
                                try
                                {
                                    Console.Clear();
                                    Console.WriteLine("0. volver\n");
                                    Console.WriteLine("Agregar un contacto nuevo");
                                    Console.WriteLine("Nombre");
                                    string nombreContacto = Console.ReadLine();
                                    if(nombreContacto == "0") { break; }
                                    Console.WriteLine("Numero");
                                    int numero = Convert.ToInt32(Console.ReadLine());
                                    if (numero == 0) { break; }
                                    if (nombreContacto != "" && Convert.ToString(numero).Length >= 8)
                                    {
                                        contactos.Add(new Contacto(nombreContacto, numero));
                                    }
                                    else
                                    {
                                        _Mensaje("Error! uno de los datos no es valido");
                                    }
                                }
                                catch (FormatException) { _Mensaje("Error! ingrese un valor valido"); }
                                catch (IndexOutOfRangeException) { _Mensaje("Error! ingrese un valor valido"); }
                                catch (OverflowException) { _Mensaje("Error! ingrese un valor valido"); }
                            } while (!volver);
                            break;
                        case 2:
                            bool volver1 = false;
                            do
                            {
                                try
                                {
                                    Console.Clear();
                                    _ImprimirLista(contactos);
                                    Console.WriteLine("\n.....0. volver.....\n");
                                    Console.WriteLine("\nSeleccione un contacto para agregar un numero");
                                    byte opc1 = Convert.ToByte(Console.ReadLine());
                                    if(opc1 == 0) { break; }
                                    if (opc1 > 0 && opc1 < contactos.Count + 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Ingrese el nuevo numero a agregar");
                                        int newNumber = Convert.ToInt32(Console.ReadLine());
                                        if (newNumber == 0) { break; }
                                        if (Convert.ToString(newNumber).Length > 7)
                                        {
                                            contactos[opc1 -1].numeros.Add(newNumber);
                                        }
                                        else
                                        {
                                            _Mensaje("Error! el numero tiene que contener 8 digitos o mas");
                                        }
                                    }
                                    else
                                    {
                                        _Mensaje("Ingrese un valor valido");
                                    }
                                }
                                catch (FormatException) { _Mensaje("Error! ingrese un valor valido"); }
                                catch (IndexOutOfRangeException) { _Mensaje("Error! ingrese un valor valido"); }
                                catch (OverflowException) { _Mensaje("Error! ingrese un valor valido"); }
                            } while (!volver1);
                                break;
                        case 3:
                            Console.Clear();
                            _ImprimirLista(contactos);
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
            void _ImprimirLista(List<Contacto> list)
            {
                if(list.Count > 0)
                {
                    Console.WriteLine("Lista de contactos");
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine("{0}. {1}", i+1,list[i].nombre);
                        for(int j = 0; j < list[i].numeros.Count; j++)
                        {
                            Console.WriteLine("     .{0}", list[i].numeros[j]);
                        }
                        Console.WriteLine("");
                    }
                }
                else
                {
                    _Mensaje("la lista de contactos se encuentra vacia");
                }
            }
        }
    }
}
