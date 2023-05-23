using System;

namespace Ejercicio2_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int opcion;
            string numeroBinario;
            int numeroDecimal;

            Console.Write("\n1.DECIMAL A BINARIO\n2.BINARIO A DECIMAL\n\nINGRESE UNA OPCION: ");
            opcion = int.Parse(Console.ReadLine());

            Console.Write("\nIngrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    numeroBinario = Conversor.ConvertirDecimalABinario(numero);
                    Console.Write("\n NUMERO: {0} EN BINARIO -------- >  {1}", numero, numeroBinario);
                break;
                case 2:
                    numeroDecimal= Conversor.ConvertirBinarioADecimal(numero);
                    Console.Write("\n NUMERO: {0} EN DECIMAL -------- >  {1}", numero, numeroDecimal);
                break;
            }

        }
    }
}
