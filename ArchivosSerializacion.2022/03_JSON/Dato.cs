using System;

namespace JSON
{
    public class Dato
    {
        public string cadena;
        protected int entero;
        private bool booleano;

        public Dato()
        {
            this.cadena = "valor inicial";
            this.entero = 1;
            this.booleano = true;
        }

        public string Mostrar()
        {
            return $"cadena: {this.cadena} - entero: {this.entero} - booleano: {this.booleano}";
        }
    }
}
