using System;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int contador;

            while (true)
            {
                Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());
                if(numero>2) // El primer numero primo es el 2, por eso pongo que debe ser mayor a 2 
                {
                    for (int i = numero-1; i > 1; i--)
                    {
                        contador = 0;
                        for (int j = 1; j < i + 1; j++) //  i + 1  o  <= i  , es para incluir y dividirse por si mismo
                        {
                            if (i % j == 0)
                            {
                                contador++;
                            }
                        }
                        if (contador == 2) // si se divide solo 2 veces el numero , es primo
                        {
                            Console.WriteLine("{0}",i);
                        }

                    }
                }
                else
                {
                    Console.WriteLine("El numero {0} no tiene numeros primos atras",numero);
                }
            }
        }

    }
}

