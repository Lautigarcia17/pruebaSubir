using System;
using System.Text;

namespace Ejercicio2_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string tablas;

            Console.Write("Ingrese el numero a calcular su tabla : ");
            numero = int.Parse(Console.ReadLine());

            tablas = CalcularTablas(numero);

            Console.WriteLine("Tabla de multiplicar del numero {0}", numero);
            Console.Write("{0}", tablas);
          
        }

        public static string CalcularTablas(int numeroEntero)
        {
            StringBuilder tablas = new StringBuilder();
            int resultado;
            string tabla = "";
            
            for (int i = 1; i < 10; i++)
            {
                resultado = numeroEntero * i;
                tablas.AppendFormat($"{numeroEntero} x {i} = {resultado}\n");
               
            }
            tabla = tablas.ToString();

            return tabla;
        }
    }
}
