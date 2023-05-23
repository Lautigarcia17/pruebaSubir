using System;

namespace Ejercicio_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string caracter = "*";
            string espacio = " ";
            int aux;

            Console.Write("Ingrese la altura del triangulo: ");
            numero = int.Parse(Console.ReadLine());
            aux = numero;

            for (int i = 0; i < numero; i++)
            {
                for (int j = aux; j > 0; j--)
                {
                    Console.Write("{0}", espacio);
                }
                aux--;

                Console.WriteLine("{0}", caracter);
                caracter = caracter + '*' + '*';
            }
        }
    }
}
