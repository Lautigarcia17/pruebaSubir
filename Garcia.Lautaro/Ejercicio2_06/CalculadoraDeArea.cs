using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_06
{
    class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            double area;

            area = Math.Pow(longitudLado, 2);
            
            return area; 
        }

        public static double CalcularAreaTriangulo(double baseTriangulo,double altura)
        {
            double area;

            area = (baseTriangulo * altura) / 2;


            return area; 
        }

        public static double CalcularAreaCirculo(double radio)
        {
            double area;

            area = 3.14 * Math.Pow(radio, 2);

            return area; 
        }
    }
}
