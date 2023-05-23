using System.Runtime.CompilerServices;
using System.Text;

namespace Entidades
{
     public class Mascota
    {
        #region Atributos

        public string nombre;
        public int edad;
        public bool vacuna;
        public ETipoMascota mascota;

        public static bool estatico;

        #endregion

        #region Constructores
        static Mascota()
        {
            Mascota.estatico = true;
        }

        public Mascota()
        {
            this.nombre = "Sin nombre";
            this.edad = 1;
            this.vacuna = true;
            this.mascota = ETipoMascota.Gato;
        }

        public Mascota(string nombre) : this()
        {
            this.nombre = nombre;

        }

        public Mascota(string nombre, int edad) : this(nombre)
        {
            this.edad = edad;
        }


        public Mascota(string nombre, int edad, bool vacuna) : this(nombre, edad)
        {
            this.vacuna = vacuna;
        }

        #endregion

        #region Metodos
        public string Operar()
        {
            return " Se operó";
        }

        public string Operar(string nombre)
        {
            return nombre + this.Operar();
        }

        public string Operar(string nombre, int edad)
        {
            return nombre + " " + edad + this.Operar();
        }

        public int Operar(int edad, string nombre)
        {
            return 3;
        }

        private string ObtenerDatos()
        {
            StringBuilder sb = new StringBuilder();
   
            sb.AppendLine("Nombre: " + this.nombre);
            sb.AppendLine("Edad: " + this.edad);
            sb.AppendLine("Vacunado:" + this.vacuna);

            return sb.ToString();
        }
        
        public override string ToString()
        {
            return this.ObtenerDatos();
        }
        
        


        #endregion

        #region Sobrecarga de operadores

        public static bool operator ==(Mascota mascota, Mascota mascota2)
        {
            return mascota.nombre == mascota2.nombre && mascota.edad == mascota2.edad;

            //return mascota == mascota2;
        }

        public static bool operator !=(Mascota mascota, Mascota mascota2)
        {
            return !(mascota == mascota2);
        }


        public static implicit operator Mascota(string nombre)
        {
            return new Mascota(nombre);
        }

        public static explicit operator string(Mascota mascota)
        {
            return mascota.nombre;
        }

        public static implicit operator int(Mascota mascota)
        {
            return mascota.edad;
        }

        #endregion

    }
}