using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Veterinaria
    {
        #region Atributos
        //public string mascotas;
        public int capacidad;
        public List<Mascota> lista;
        #endregion

        #region Constructores
        public Veterinaria()
        {
            this.lista = new List<Mascota>();
            this.capacidad = 4;
        }

        public Veterinaria(int capacidad) : this()
        {
            this.capacidad = capacidad;
        }
        #endregion

        #region Sobrecargas

        public static bool operator ==(Veterinaria veterinaria, Mascota m)
        {
            bool esta = false;
            foreach (Mascota item in veterinaria.lista)
            {
                if (item == m)
                {
                    esta = true;
                    break;
                }
            }
            return esta;
        }

        public static bool operator !=(Veterinaria veterinaria, Mascota m)
        {
            return !(veterinaria == m);
        }

        public static Veterinaria operator +(Veterinaria veterinaria, Mascota m)
        {
            if (veterinaria.lista.Count < veterinaria.capacidad)
            {
                if (veterinaria != m)
                {
                    veterinaria.lista.Add(m);
                }
                else
                {
                    Console.WriteLine("Ya se encuentra en la veterinaria\n");
                }
            }
            else
            {
                Console.WriteLine("No hay lugar en la veterinaria!\n");
            }
            return veterinaria;
        }

    

        public static Veterinaria operator -(Veterinaria veterinaria, Mascota m)
        {
            for (int i = 0; i < veterinaria.lista.Count; i++)
            {
                if (veterinaria.lista[i] == m)
                {
                    veterinaria.lista.RemoveAt(i);
                    break;
                }
            }
            return veterinaria;
        }


        #endregion



    }
}
