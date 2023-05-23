using System;

namespace Ejercicio2_06
{
    class Program
    {
        static void Main(string[] args)
        {
            double longitudLado; // cuadrado
            double baseTriangulo; // triangulo
            double altura; // triangulo
            double radio; // circulo
            double area=0; // valor default ?? 
            int opcion;

            Console.Write("\nQue desea calcular?\n 1 : Area de un Cuadrado\n 2 : Area de un Triangulo\n 3 : Area de un Circulo\n \n\n Elija una opcion: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("\nIngrese la longitud : ");
                    longitudLado = int.Parse(Console.ReadLine());
                    area = CalculadoraDeArea.CalcularAreaCuadrado(longitudLado);
                break;
                case 2:
                    Console.Write("\nIngrese la base : ");
                    baseTriangulo = int.Parse(Console.ReadLine());
                    Console.Write("\nIngrese la altura : ");
                    altura = int.Parse(Console.ReadLine());
                    area = CalculadoraDeArea.CalcularAreaTriangulo(baseTriangulo,altura);
                break;
                case 3:
                    Console.Write("\nIngrese el radio : ");
                    radio = int.Parse(Console.ReadLine());
                    area = CalculadoraDeArea.CalcularAreaCirculo(radio);
                    break;
            }

            Console.Write("\n AREA: {0}",area);

        }
    }
}
