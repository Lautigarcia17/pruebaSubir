using System;

namespace Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int numInicio;
            int numFinal;

            Console.Write("Ingrese un año de inicio: ");
            numInicio = int.Parse(Console.ReadLine());

            Console.Write("Ingrese un año de final: ");
            numFinal = int.Parse(Console.ReadLine());


            Console.Write("\n------------- AÑOS BISIESTOS ----------------");
            for (int i = numInicio; i <= numFinal; i++)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine("- {0}", i);
                }
            }

        }
    }
}
