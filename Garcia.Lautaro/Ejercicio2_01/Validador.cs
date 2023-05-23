using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_01
{
    class  Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool retorno = false;


            if (valor >= min && valor <= max)
            {
                retorno = true;
            }

            return retorno;
        }

        public static int BuscarMaximo(int valor, int maximo)
        {
            int valorMaximo = maximo;

            if (valor >maximo)
            {
                valorMaximo = valor;
            }

            return valorMaximo;
        }

        public static int BuscarMinimo(int valor, int minimo)
        {
            int valorMinimo = minimo;

            if (valor < minimo)
            {
                valorMinimo = valor;
            }

            return valorMinimo;
        }

        public static float CalcularPromedio(int acumulador, int contador)
        {
            float promedio;

            promedio = (float)acumulador / contador;

            return promedio;
        }

    }
}
