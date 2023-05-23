using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Sello.mensaje = "DALE BOCA";
            Sello.color = ConsoleColor.Cyan;
            string mensaje;

            mensaje = Sello.Imprimir();
            Sello.ImprimirEnColor();
            Console.WriteLine(mensaje);
        }
    }
}
