using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asesoria_Metodos_.Funciones
{
    internal class Operaciones
    {
        public Operaciones() 
        {
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
                    resultado = SumaTresNumeros(n1, n2); /*,n3,10);*/
                    Console.WriteLine("El resultado de la suma es: " + resultado);
                    break;
                case 2:
                    Console.Clear();
                    resultado = Resta(n1, n2);
                    Console.WriteLine("El resultado de la resta es: " + resultado);
                    break;

                case 3:
                    Console.Clear();
                    resultado = Multiplicacion(n1, n2);
                    Console.WriteLine("El resultado de la multiplicacion es: " + resultado);
                    break;
                case 4:
                    Console.Clear();
                    resultado = Division(n1, n2);
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
        public static int SumaTresNumeros(int n1, int n2) /*int n3 int n4*/ /*parametros*/ /*string mensaje, bool*/
        {
            int resultado = n1 + n2; /* + n3 + n4;*/
            return resultado;
        }
        public static int Resta(int n1, int n2)
        {
            int resultado = n1 - n2;
            return resultado;
        }
        public static int Multiplicacion(int n1, int n2)
        {
            int resultado = n1 * n2;
            return resultado;
        }
        public static int Division(int n1, int n2)
        {
            int resultado = n1 / n2;
            return resultado;
        }
    }
}

