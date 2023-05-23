using System;

namespace Ejercicio2_07
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseTriangulo; // triangulo
            double altura; // triangulo
            double hipotenusa;

            Console.Write("\nIngrese la base : ");
            baseTriangulo = int.Parse(Console.ReadLine());
            Console.Write("\nIngrese la altura : ");
            altura = int.Parse(Console.ReadLine());

            hipotenusa = Calculadora.CalcularHipotenusa(baseTriangulo, altura);

            Console.Write("\n\nLA HIPOTENUSA DA COMO RESULTADO {0:N2} cm",hipotenusa); // :N2 para limitar los caracteres desp de la coma
        }
    }
}
