using System;

namespace Ejercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string caracter = "*";

            Console.Write("Ingrese la altura del triangulo: ");
            numero = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine("{0}",caracter);
                caracter = caracter + '*' + '*';
            }
        }
    }
}
