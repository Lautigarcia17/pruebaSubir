using System;
using System.Text;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Xml;
using Entidades;

namespace _02_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Serializar y Deserializar objeto

            Dato d = new Dato("Pepe", 20);

            try
            {
                //Creo un objeto que 'sabe' como escribir en XML
                using (XmlTextWriter writer = new XmlTextWriter("Datos.xml", System.Text.Encoding.UTF8))
                {
                    //Creo un objeto que 'sabe' como serializar a XML
                    //Le tengo que indicar que tipo de objeto se va a serializar
                    XmlSerializer ser = new XmlSerializer(typeof(Dato));

                    //Utilizo el método Serialize, pasándole el 'escritor' de XML
                    //y el objeto a serializar
                    ser.Serialize(writer, d);
                }

                //Creo un objeto que 'sabe' como leer de XML
                using (XmlTextReader reader = new XmlTextReader("Datos.xml"))
                {
                    //Creo un objeto que 'sabe' como deserializar de XML
                    //Le tengo que indicar que tipo de objeto se va a deserializar
                    XmlSerializer ser = new XmlSerializer(typeof(Dato));


                    //Utilizo el método Deserialize, pasándole el 'lector' de XML
                    //Debo 'castear' al tipo de dato específico, ya que 
                    //el método Deserialize retorna un Object
                    Dato aux = (Dato)ser.Deserialize(reader);

                    Console.WriteLine(aux.Mostrar());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Falló la serialización. Razones: " + e.Message);
            }

            #endregion

            #region Serializar y Deserializar colecciones

            List<Dato> listaDato = new List<Dato>();
            List<Dato> listaDatoXML;

            Dato d1 = new Dato("juan", 22);
            Dato d2 = new Dato("pedro", 33);
            Dato d3 = new Dato("mara", 44);
            Dato d4 = new Dato("carmen", 55);

            listaDato.Add(d1);
            listaDato.Add(d2);
            listaDato.Add(d3);
            listaDato.Add(d4);

            try
            {
                using (XmlTextWriter writer = new XmlTextWriter("C:\\archivos\\DatosLista.xml", Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer((typeof(List<Dato>)));
                    ser.Serialize(writer, listaDato);
                }

                using (XmlTextReader reader = new XmlTextReader(@"C:\archivos\DatosLista.xml"))
                {
                    XmlSerializer ser = new XmlSerializer((typeof(List<Dato>)));

                    listaDatoXML = (List<Dato>)ser.Deserialize(reader);
                }

                foreach (Dato miDato in listaDatoXML)
                {
                    Console.WriteLine(miDato.Mostrar());
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Error al Serializar/Deserializar los Datos");
            }

            #endregion

        }
    }
}
