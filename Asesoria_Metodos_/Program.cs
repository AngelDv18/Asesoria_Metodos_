using Asesoria_Metodos_.Funciones;
using System;
using System.ComponentModel.Design;

namespace Asesoria_Metodos_
{
    class Program
    {
        static void Main(string[] args)

        /*tipos de operaciones = operaciones aritmeticas, operaciones condicionales, operaciones logicas.*/
        {
            Console.WriteLine("Menu de Opciones");
            #region--Condicion if--
            //Console.WriteLine("Seleciona un dia de la semana");
            //string opcion = Console.ReadLine();


            //if (opcion == "Lu")
            //{
            //    Console.WriteLine("Seleccionaste Lunes ");
            //}
            //else
            //{
            //    if (opcion == "Ma")
            //    {
            //        Console.WriteLine("Seleccionaste Martes ");
            //    }
            //    else
            //    {
            //        if (opcion == "Mi")
            //        {
            //            Console.WriteLine("Sleccionaste Miercoles");
            //        }
            //        else
            //        {
            //            if (opcion == "Ju")
            //            {
            //                Console.WriteLine("Sleccionaste Jueves");
            //            }
            //            else
            //            {
            //                if (opcion == "Vi")
            //                {
            //                    Console.WriteLine("Sleccionaste Miercoles");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Seleciona una opcion valida");
            //                }
            //            }
            //        }
            //    }
            //}
            #endregion
            #region--CONDICION SWITCH--
            //Console.WriteLine("Seleciona un dia de la semana");
            //string opcion = (Console.ReadLine());
            //switch (opcion)
            //{
            //    case "A":
            //        Console.WriteLine("Dia lunes");
            //        break;
            //    case "B":
            //        Console.WriteLine("Dia Martes");
            //        break;
            //    case "C":
            //        Console.WriteLine("Dia Miercoles");
            //        break;
            //    case "D":
            //        Console.WriteLine("Dia Jueves");
            //        break;
            //    case "E":
            //        Console.WriteLine("Dia Viernes");
            //        break;

            //    default:
            //        Console.WriteLine("No Existe lo que ingresate");
            //        break;
            //}
            #endregion
            Menu menu = new Menu();
            menu.Opciones();
        }
    }
}