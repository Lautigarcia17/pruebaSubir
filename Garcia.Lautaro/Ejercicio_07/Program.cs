using System;

namespace Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora;
            string nombre;
            int antiguedad;
            int cantidadHoras;
            int sueldoBruto;
            int cantidadHorasTrabajadas;
            int porcentaje=13;
            int descuento;
            int reciboSueldo=0;
            string respuesta;

            do
            {
                Console.Write("\n\nIngrese el valor de la hora: ");
                hora = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el nombre: ");
                nombre = Console.ReadLine();

                Console.Write("Ingrese la antiguedad: ");
                antiguedad = int.Parse(Console.ReadLine());

                Console.Write("Ingrese la cantidad de horas: ");
                cantidadHoras = int.Parse(Console.ReadLine());

                cantidadHorasTrabajadas = antiguedad * 150;

                sueldoBruto = hora * cantidadHoras + cantidadHorasTrabajadas;

                descuento = (sueldoBruto * porcentaje) / 100;

                reciboSueldo += sueldoBruto - descuento;

                Console.Write("\n\n Nombre: {0}" +
                              "\n Antiguedad: {1}" +
                              "\n Valor hora: {2}" +
                              "\n Sueldo bruto: {3}" +
                              "\n Sueldo neto: {4}", nombre, antiguedad, hora, sueldoBruto, reciboSueldo);



                Console.Write("\nDesea ingresar otro empleado? (si / no) :");
                respuesta = Console.ReadLine();

            } while (respuesta=="si");


        }
    }
}
