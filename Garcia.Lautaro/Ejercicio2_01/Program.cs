using System;

namespace Ejercicio2_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int valorMaximo=int.MinValue;
            int valorMinimo = int.MaxValue;
            int acumulador = 0;
            int contador = 0;
            float promedio;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());
                
                if (Validador.Validar(numero, 0, 10))
                {
                    valorMaximo = Validador.BuscarMaximo(numero, valorMaximo);
                    valorMinimo = Validador.BuscarMinimo(numero, valorMinimo);
                }
                else
                {
                    Console.WriteLine("\nFUERA DE RANGO");
                }
                acumulador += numero;
                contador++;
            }
            promedio = Validador.CalcularPromedio(acumulador, contador);
            Console.Write("VALOR MAXIMO : {0}\nVALOR MINIMO : {1}\nPROMEDIO : {2}",valorMaximo,valorMinimo,promedio);
        }
    }
}
