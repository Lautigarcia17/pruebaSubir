using System;

namespace Ejercicio2_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroUno;
            int numeroDos;
            char operador;
            int resultado;
            string respuesta;

            do
            {
                Console.Write("\nIngrese el primer numero: ");
                numeroUno = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo numero: ");
                numeroDos= int.Parse(Console.ReadLine());

                Console.Write("Que operacion desea realizar ?\n + = SUMA\n - = RESTA\n * = MULTIPLICACION \n / = DIVISION\n\n Elija una opcion: ");
                operador = char.Parse(Console.ReadLine());

                resultado = Calculadora.Calcular(numeroUno, numeroDos, operador);

                Console.Write("\n\nRESULTADO : {0}",resultado);

                Console.Write("\n\nDesea continuar ?(si/no): ");
                respuesta = Console.ReadLine();
                respuesta=respuesta.ToLower();

            } while (respuesta == "si");




        }
    }
}
