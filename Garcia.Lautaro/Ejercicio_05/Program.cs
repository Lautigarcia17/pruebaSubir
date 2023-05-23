using System;

namespace Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int acumuladorPre;
            int acumuladorPost;

            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            for (int i = 2; i < numero; i++) // arranca en 2 por que no existen numeros perfectos anteriores
            {
                acumuladorPre = 0;
                acumuladorPost = 0;

                for (int j = 0; j < i; j++)
                {
                    acumuladorPre += j;
                }

                for (int k = i+1; acumuladorPost < acumuladorPre; k++) // los numeros perfectos dividen , osea no incluyen al propio numero
                {
                    acumuladorPost += k;
                }

                if (acumuladorPost == acumuladorPre)
                {
                    Console.WriteLine("El numero {0} ES PERFECTO", i);
                }

            }

        }
    }
}
