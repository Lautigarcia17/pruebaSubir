using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_08
{
    class Calendario
    {
        public static int CalcularDiferenciaDiasHastaActualidad(int dia, int mes, int anio)
        {
            DateTime fecha = new DateTime(anio, mes, dia);
            DateTime fechaActual =DateTime.Today;

            int cantidadDias;

            cantidadDias = fechaActual.Subtract(fecha).Days;

            return cantidadDias;
        }


    }
}
