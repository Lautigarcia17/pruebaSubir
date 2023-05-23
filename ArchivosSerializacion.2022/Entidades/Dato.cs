using System;
using System.Text;

namespace Entidades
{
    //La clase debe ser pública
    public class Dato
    {
        public string nombre;
        public int edad;

        //El constructor por defecto es requerido 
        //para poder serializar a XML
        public Dato()
        {

        }

        public Dato(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();

            cadena.Append("Nombre: ");
            cadena.AppendLine(this.nombre);
            cadena.Append("Edad: ");
            cadena.AppendLine(this.edad.ToString());

            return cadena.ToString();
        }
    }
}
