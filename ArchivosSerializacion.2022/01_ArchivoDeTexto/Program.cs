using System;
using System.IO;

namespace _01_ArchivoDeTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Escritura de archivo

            try
            {
                // Abro un archivo
                StreamWriter sw = new StreamWriter("C:\\archivos\\Test.txt");
                // Escribo
                sw.WriteLine("Hola mundo!!!");
                // Cierro el archivo
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            #endregion

            #region Escritura de archivo con bloque using

            try
            {
                //El bloque using asegura que el objeto invocará al método Dispose()
                using (StreamWriter sw = new StreamWriter("C:\\archivos\\Test.txt"))
                {
                    sw.Write("Este es el ");
                    sw.WriteLine("encabezado para el archivo.");
                    sw.WriteLine("-----------------------------");

                    // Objetos arbitrarios tambien pueden ser escritos en el archivo.
                    sw.Write("LA FECHA ES: ");
                    sw.WriteLine(DateTime.Now);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            #endregion

            #region Lectura de archivo

            try
            {
                // Crea una instancia de StreamReader para leer desde el archivo.
                using (StreamReader sr = new StreamReader("C:\\archivos\\Test.txt"))
                {
                    String linea;

                    // Lee y muestra líneas desde el comienzo del archivo 
                    // hasta el fin del mismo.
                    while ((linea = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(linea);
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            #endregion

            #region Escritura con encoding y append

            System.Text.Encoding miCodificacion = System.Text.Encoding.ASCII;//.UTF8;

            try
            {
                //Al colocar el parámetro append en false, se sobrescribe.
                using (StreamWriter sw = new StreamWriter(@"C:\archivos\Test.txt", false, miCodificacion))
                {
                    sw.WriteLine("-----------------------------");
                    sw.WriteLine("ARCHIVO SOBRESCRITO....");
                    sw.WriteLine("-----------------------------");
                }

                //Al colocar el parámetro append en true, agrego datos.
                using (StreamWriter sw = new StreamWriter(@"C:\archivos\Test.txt", true, miCodificacion))
                {
                    sw.WriteLine("Línea agregada al archivo original...");
                }

                //con ReadToEnd, se lee el archivo completo
                using (StreamReader sr = new StreamReader(@"C:\archivos\Test.txt", miCodificacion))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }

                using (StreamWriter sw = new StreamWriter(@"C:\archivos\Test.txt"))
                {
                    sw.WriteLine("Línea agregada al archivo original...");
                }

                //con Read, se lee un sólo caracter
                using (StreamReader sr = new StreamReader(@"C:\archivos\Test.txt"))
                {
                    Console.WriteLine(sr.Read());
                    Console.WriteLine(sr.Read());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadLine();
            }

            #endregion

            #region Métodos de la clase File

            try
            {
                // Si no existe el archivo, lo copio de C:\Test.txt
                if (!File.Exists(@"C:\Users\Maxi\Desktop\miArchivo.txt"))
                {
                    File.Copy(@"C:\archivos\Test.txt", @"C:\Users\Maxi\Desktop\miArchivo.txt");
                }
                else // Si existe, lo borro.
                {
                    File.Delete(@"C:\Users\Maxi\Desktop\miArchivo.txt");
                }

                using (StreamReader sr = new StreamReader(@"C:\Users\Maxi\Desktop\miArchivo.txt"))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadLine();
            }

            #region Mejora

            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            try
            {
                using (StreamWriter sw = new StreamWriter(escritorio + @"\miArchivo.txt", true))
                {
                    sw.WriteLine("Otra línea agregada al archivo...");
                }

                using (StreamReader sr = new StreamReader(escritorio + @"\miArchivo.txt"))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            #endregion

            #endregion

        }
    }
}
