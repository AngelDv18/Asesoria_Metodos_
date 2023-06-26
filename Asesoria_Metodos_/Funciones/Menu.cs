using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Asesoria_Metodos_.Funciones
{
    class Menu
    {
        public void Opciones()
        {
            Operaciones funciones = new Operaciones();
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("Ingresa una de las opciones");
                Console.WriteLine("1) Suma");
                Console.WriteLine("2) Resta");
                Console.WriteLine("3) Multiplicación");
                Console.WriteLine("4) Division");
                Console.WriteLine("5) Salir del Programa");
                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                int resultado;
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingresa un numero");
                        int n0 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa otro numero");
                        int n1 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        resultado = funciones.SumaDosNumeros(n0, n1); /*,n3,10);*/
                        Console.WriteLine("El resultado de la suma es: " + resultado);
                        break;
                    case 2:
                        Console.WriteLine("Ingresa un numero");
                        int n3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa otro numero");
                        int n4 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        resultado = funciones.Resta(n3, n4);
                        Console.WriteLine("El resultado de la resta es: " + resultado);
                        break;
                    case 3:
                        Console.WriteLine("Ingresa un numero");
                        int n5 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa otro numero");
                        int n6 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        resultado = funciones.Multiplicacion(n5, n6);
                        Console.WriteLine("El resultado de la multiplicacion es: " + resultado);
                        break;
                    case 4:
                        Console.WriteLine("Ingresa un numero");
                        int n7 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa otro numero");
                        int n8 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        resultado = funciones.Division(n7, n8);
                        Console.WriteLine("El resultado de la Division es: " + resultado);
                        break;
                    case 5:
                        Console.WriteLine("Saliste del programa");
                        break;
                    default:
                        Console.WriteLine("opcion invalida. Selecciona otra occion");
                        break;
                }
                if (!salir)
                {
                    Console.WriteLine("¿Deseas regresar al Menú de opciones o salir del programa?");
                    Console.WriteLine("1) Regresar al Menú de opciones");
                    Console.WriteLine("2) Salir del programa");
                    int opcionMenu = int.Parse(Console.ReadLine());

                    switch (opcionMenu)
                    {
                        case 1:
                            Console.Clear();
                            break;
                        case 2:
                            Console.WriteLine("Saliendo del programa...");
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Opción inválida. Seleccionando regresar al Menú de opciones.");
                            Console.Clear();
                            break;
                    }
                }
            }
        }
    }
}

