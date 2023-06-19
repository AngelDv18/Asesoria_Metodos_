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
        { /*Console.WriteLine("Ingresa otro numero");
            int n3 = int.Parse(Console.ReadLine());*/
            Operaciones funciones = new Operaciones();

            Console.WriteLine("Ingresa una de las opciones");
            Console.WriteLine("1) Suma");
            Console.WriteLine("2) Resta");
            Console.WriteLine("3) Multiplicación");
            Console.WriteLine("4) Division");
            Console.WriteLine("5) Salir del programa");
            int resultado;
            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Ingresa un numero");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa otro numero");
            int n2 = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    resultado = funciones.SumaDosNumeros (n1, n2); /*,n3,10);*/
                    Console.WriteLine("El resultado de la suma es: " + resultado);
                    break;
                case 2:
                    Console.Clear();
                    resultado = funciones.Resta(n1, n2);
                    Console.WriteLine("El resultado de la resta es: " + resultado);
                    break;
                case 3:
                    Console.Clear();
                    resultado = funciones.Multiplicacion(n1, n2);
                    Console.WriteLine("El resultado de la multiplicacion es: " + resultado);
                    break;
                case 4:
                    Console.Clear();
                    resultado = funciones.Division(n1, n2);
                    Console.WriteLine("El resultado de la Division es: " + resultado);
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Saliste del programa");
                    break;
                default:
                    Console.WriteLine("opcion invalida. Selecciona otra occion");
                    break;
            }
        }
    }
}


