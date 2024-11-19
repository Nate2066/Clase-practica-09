using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro._3{
    internal class Program{
        static void Main(string[] args){
            List<Cliente> listaClientes = new List<Cliente>();
            bool salir = false;

            do{
                try{
                    _OrdenarLista(listaClientes);
                    Console.Clear();
                    Console.WriteLine("Espere por su turno\n");
                    if(listaClientes.Count > 0){
                        for (int i = 0; i < listaClientes.Count; i++){
                            Console.WriteLine("{0}. {1}", i + 1, listaClientes[i].nombre);
                        }
                    }
                    Console.WriteLine("\n1. entrar a fila");
                    Console.WriteLine("\n0. salir");
                    byte opc = Convert.ToByte(Console.ReadLine());

                    switch (opc){
                        case 0:
                            Console.Clear();
                            salir = true;
                            break;
                        case 1:
                            bool volver = false;
                            do{
                                try{
                                    Console.Clear();
                                    Console.WriteLine("0. regresar\n");
                                    Console.WriteLine("Ingrese su nombre para entrar a la fila");
                                    string name = Console.ReadLine();
                                    if(name == "0") { break; }
                                    Console.WriteLine("Ingrese su numero de cuentas, este tiene que ser de 8 digitos");
                                    int nroCuenta = Convert.ToInt32(Console.ReadLine());
                                    if (nroCuenta == 0) { break; }
                                    if (Convert.ToString(nroCuenta).Length == 8){
                                        foreach(var item in listaClientes){
                                            if(item.numeroCuenta == nroCuenta){
                                                nroCuenta = 0;
                                            }
                                        }
                                        if (nroCuenta == 0) { break; }
                                        Console.WriteLine("Ingrese su saldo");
                                        double saldo = Convert.ToDouble(Console.ReadLine());
                                        if (saldo == 0) { break; }
                                        if (saldo > 0){
                                            listaClientes.Add(new Cliente(nroCuenta, saldo, name));
                                        }
                                        else{
                                            _Mensaje("Su saldo no puede estar debajo de 0");
                                        }
                                    }
                                    else{
                                        _Mensaje("El numero de cuenta tiene que tener 8 digitos");
                                    }
                                }
                                catch (FormatException) { _Mensaje("Error! ingrese un valor valido"); }
                                catch (IndexOutOfRangeException) { _Mensaje("Error! ingrese un valor valido"); }
                                catch (OverflowException) { _Mensaje("Error! ingrese un valor valido"); }
                            } while (!volver);
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
            void _Mensaje(string pMensaje){
                Console.Clear();
                Console.WriteLine(pMensaje);
                Console.ReadKey();
            }
            void _OrdenarLista(List<Cliente> list){
                List<Cliente> listaTemporal = new List<Cliente>();
                foreach(var item in list){
                    if(item.saldo > 10000){
                        listaTemporal.Add(item);
                    }
                }
                foreach(var item in list){
                    if(item.saldo <= 10000){
                        listaTemporal.Add(item);
                    }
                }for(int i = 0; i< list.Count; i++){
                    list[i] = listaTemporal[i];
                }
            }
        }
    }
}
