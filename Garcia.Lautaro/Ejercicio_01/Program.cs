using System;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int valorMaximo = int.MinValue;
            int valorMinimo = int.MaxValue;
            int acumulador=0;
            int contador=0;
            float promedio;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese un numero (ingreso {0}): ",i);
                numero = int.Parse(Console.ReadLine());

                if (numero > valorMaximo )
                {
                    valorMaximo = numero;
                }
                else
                {
                    if (numero < valorMinimo )
                    {
                        valorMinimo = numero;
                    }
                }
                acumulador += numero;
                contador++;
            }

            promedio = (float)acumulador / contador;

            Console.WriteLine("\nMinimo: {3} -- Maximo: {4}\n\nLa suma de los numeros fue {0} , se ingresaron {1} y el promedio es {2:N2}", acumulador,contador,promedio,valorMinimo,valorMaximo); // EL :N2 es 2 numeros despues de la coma

        }
    }
}
