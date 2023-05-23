using System;

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int acumulador;

            for (int i = 1; i < 8129; i++)
            {
                acumulador = 0;

                for (int j = 1; j < i; j++)
                {
                    if(i % j == 0)
                    {
                        acumulador += j;
                    }
                }
                if (i == acumulador)
                {
                    Console.WriteLine("{0}  {1}", i, acumulador);      
                }
            }

        }
    }
}
