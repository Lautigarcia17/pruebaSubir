using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03
{
    class MiClase
    {
        #region Atributos NO estaticos o de instancia
        public string cadena;
        public int entero;
        #endregion

        #region Atributos  estaticos o de clase
        public static double doble;
        #endregion

        #region Metodos NO estaticos o de instancia
        public void MetodoInstancia()
        {
            Console.WriteLine("valor cadena: {0} valor entero: {2} valor doble: {1}",this.cadena,MiClase.doble,this.entero);
        }
        #endregion

        #region Metodos  estaticos o de clase
        public static void MetodoDeClase()
        {
            Console.WriteLine("valor doble: {0}", MiClase.doble);
        }
        #endregion
    }
}
