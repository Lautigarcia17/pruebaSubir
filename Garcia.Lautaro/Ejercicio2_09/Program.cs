using System;

namespace Ejercicio2_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int factorial;

            Console.Write("Ingrese el numero: ");
            numero = int.Parse(Console.ReadLine());


            factorial = Calculadora.CalcularFactorial(numero);

            Console.Write("\n\n\n NUMERO FACTORIZADO: {0}\n", factorial);
        }
    }
}
