using System;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            while (true)
            {
                Console.Write("\nIngrese el numero: ");
                numero = int.Parse(Console.ReadLine());
                if (numero>0)
                {
                    Console.Write("\nNumero: {0}\nElevado al cuadrado: {1}\nElevado al cubo: {2}\n",numero,Math.Pow(numero,2), Math.Pow(numero, 3));
                }
                else
                {
                    Console.WriteLine("\nERROR. ¡Reingresar número!");
                }

            }


        }
    }
}
