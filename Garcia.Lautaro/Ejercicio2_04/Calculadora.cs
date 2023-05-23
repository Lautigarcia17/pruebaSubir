using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_04
{
    class Calculadora
    {
        public static int Calcular(int operadorUno, int operadorDos, char operacion)
        {
            int resultado = 0;
            
            switch (operacion)
            {
                case '+':
                    resultado = operadorUno + operadorDos;
                break;
                case '-':
                    resultado = operadorUno - operadorDos;
                    break;
                case '*':
                    resultado = operadorUno * operadorDos;
                    break;
                case '/':
                    if (Calculadora.Validar(operadorDos))
                    {
                        resultado = operadorUno / operadorDos;
                    }
                    else
                    {
                        Console.Write("\nNO ES POSIBLE DIVIDIR CON EL OPERADOR 0");
                    }
                break;
            }


            return resultado;
        }

        private static bool Validar(int operador)
        {
            bool retorno=false;

            if (operador!=0)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
