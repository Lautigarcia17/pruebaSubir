using System;

namespace Clase03
{
    class Program
    {
        static void Main(string[] args)
        {

            MiClase.doble = 5.44;

            MiClase.MetodoDeClase();

            MiClase obj = new MiClase();

            obj.cadena = "algo";
            obj.entero = 5;

            obj.MetodoInstancia();

            MiClase obj2 = new MiClase();

            obj2.cadena = "asadsad";

            MiClase.doble = 888;

        }
    }
}
