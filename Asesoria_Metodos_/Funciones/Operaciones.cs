using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asesoria_Metodos_.Funciones
{
    class Operaciones
    {
            public int SumaDosNumeros(int n1, int n2) /*int n3 int n4*/ /*parametros*/ /*string mensaje, bool*/
            {
                int resultado = n1 + n2; /* + n3 + n4;*/
                return resultado;
            }
            public int Resta(int n1, int n2)
            {
                int resultado = n1 - n2;
                return resultado;
            }
            public int Multiplicacion(int n1, int n2)
            {
                int resultado = n1 * n2;
                return resultado;
            }
            public int Division(int n1, int n2)
            {
                int resultado = n1 / n2;
                return resultado;
            }
    }
}