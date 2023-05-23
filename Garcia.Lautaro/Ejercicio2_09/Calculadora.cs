using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_09
{
    class Calculadora
    {
        public static int CalcularFactorial(int numeroEntero)
        {
            int factorial = 0;


            if (numeroEntero==0)
            {
                factorial = 1;
            }
            else
            {
                factorial = numeroEntero * CalcularFactorial(numeroEntero - 1);
            }
             
            return factorial;
        }


    }
}
