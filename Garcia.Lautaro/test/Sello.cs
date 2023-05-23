using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        public static string Imprimir()
        {
            return Sello.ArmarFormatoMensaje();
        }
        public static void Borrar()
        {
            Sello.mensaje = "";      
        }

        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;

            Console.WriteLine(Sello.Imprimir());

            Console.ResetColor();

        }

        public static string ArmarFormatoMensaje()
        {
            int len= Sello.mensaje.Length;
            string asterisco = "";
            string mensaje = "";

            if (len>0)
            {
                for (int i = 0; i <len + 2; i++)
                {
                    asterisco = asterisco + "*";
                }
                mensaje = asterisco + "\n*" + Sello.mensaje + "*\n" + asterisco;
            }

            return mensaje;
        }


    }
}
