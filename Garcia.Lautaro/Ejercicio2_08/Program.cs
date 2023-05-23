using System;

namespace Ejercicio2_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia;
            int mes;
            int anio;
            int cantidadDias;

           Console.Write("\nIngrese el dia: ");
            dia = int.Parse(Console.ReadLine());
            Console.Write("\nIngrese el mes: ");
            mes = int.Parse(Console.ReadLine());
            Console.Write("\nIngrese el año: ");
            anio = int.Parse(Console.ReadLine());

            cantidadDias = Calendario.CalcularDiferenciaDiasHastaActualidad(dia, mes, anio);

            Console.Write("Pasaron {0} dias", cantidadDias);

        }
    }
}
