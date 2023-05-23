using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_03
{
    class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero) 
        {
            string binario = "";


            while (numeroEntero > 0)
            {
                binario = numeroEntero % 2 + binario;
                numeroEntero = numeroEntero / 2;
            }

            return binario;
        }

        public static int ConvertirBinarioADecimal(int numeroEntero)
        {
            int resto;
            int basePotencia = 2;
            int exponente = 0;
            int acumulador = 0;

            do
            {

                resto = numeroEntero % 10;
                numeroEntero = numeroEntero / 10;

                acumulador += resto * (int)Math.Pow(basePotencia, exponente);

                exponente++;

            } while (numeroEntero > 0);


            return acumulador;
        }
    }
}

/*
             int numero;
            int resto;
            float division ;
            int cociente;

            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
            cociente = numero;

            Console.Write("\nNumero en Binario: ");
            do
            {
           
                resto = (int)cociente % 2;
                division = (float)cociente / 2;
                cociente = (int)Math.Floor(division);
                Console.Write("{0}",resto);
                if (cociente == 1)
                {
                    Console.Write("{0} ", cociente);
                }      
            }while (cociente != 1);
 */