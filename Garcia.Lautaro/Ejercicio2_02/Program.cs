using System;

namespace Ejercicio2_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int acumulador=0;
            int contador=0;
            string respuesta;
            bool retorno;

            do
            {
                contador++;
                acumulador += contador;
                Console.Write("\nSUMA: {0}", acumulador);

                Console.Write("\n¿Desea Continuar?(S/N) : ");
                respuesta =Console.ReadLine();
                retorno = Validador.ValidarRespuesta(respuesta);

            } while (retorno == true);

            

        }
    }
}
