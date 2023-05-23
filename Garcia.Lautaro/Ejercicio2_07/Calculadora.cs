using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_07
{
    class Calculadora
    {
        public static double CalcularHipotenusa(double baseTriangulo, double altura)
        {
            double resultado;
            double suma;

            suma = Math.Pow(baseTriangulo, 2) + Math.Pow(altura, 2);
            resultado = Math.Sqrt(suma);


            return resultado;
        }


    }
}
