using Entidades;

namespace ClasePoo
{
    public class Program
    {
        public class Persona
        {
            public string nombre;

            public Persona(string nombre)
            {
                this.nombre = nombre;
            }
        }

        public static void Main(string[] arg)
        {
            #region Arrays
            /*
            int[] array = new int[2];

            array[0] = 1;
            array[1] = 2;

            for (int i = 0; i <= array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }*/
            /*
            Persona[] personas =
            {
                new Persona("Luis"),
                new Persona("Maxi"),
                new Persona("Lucas"),
            };

            foreach (Persona persona in personas)
            {
                Console.WriteLine(persona.nombre);   
            }*/
            /*
            int[,,] array = new int[2, 2,2];

            array[0,0,0] = 1;

            Console.WriteLine(array[0, 0, 0]);*/
            /*
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(i + " - " + j + " = " + array[i, j]);
                }
            }*/
            /*
            int[][] matrizE = new int[2][];

            matrizE[0] = new int[] { 2, 3, 4 };
            matrizE[1] = new int[] { 3, 4, 6, 2, 3 };

            Console.WriteLine(matrizE[1][3]);
            */


            #endregion


            #region Colecciones NO genéricas
            //Incluir libreria System.Collections
            /*
            Console.WriteLine("--------------------------");
            Console.WriteLine("-COLECCIONES NO GENÉRICAS-");
            Console.WriteLine("--------------------------\n\n");

            
            Console.WriteLine("PILA----> Comportamiento tipo LIFO");
            Console.WriteLine("-----------------------------------\n");
            System.Collections.Stack pilaNoGenerica = new System.Collections.Stack();

            Console.WriteLine("Apilo con método Push:\n");
            Console.WriteLine();
            pilaNoGenerica.Push("Juan");
            pilaNoGenerica.Push(true);
            pilaNoGenerica.Push("Pablo");
            pilaNoGenerica.Push(5);

            foreach (object item in pilaNoGenerica)
            {
                Console.WriteLine("Elemento: " + item);
            }

            Console.Write("\nDevuelvo el próximo a salir con método Peek: ");
            Console.WriteLine(pilaNoGenerica.Peek());

            Console.WriteLine("\nDesapilo con método Pop\n");
            pilaNoGenerica.Pop();
            pilaNoGenerica.Pop();

            foreach (object item in pilaNoGenerica)
            {
                Console.WriteLine("Elemento: " + item);
            }
            */
            /*
            Console.WriteLine("COLA----> Comportamiento tipo FIFO");
            Console.WriteLine("----------------------------------\n");
            System.Collections.Queue colaNoGenerica = new System.Collections.Queue();

            Console.WriteLine("Agrego elementos:\n");
            colaNoGenerica.Enqueue(2.5f);
            colaNoGenerica.Enqueue("Juan");
            colaNoGenerica.Enqueue(false);
            colaNoGenerica.Enqueue(new Mascota("Tobi",3));

            foreach (object item in colaNoGenerica)
            {
                if(item is Mascota)
                Console.WriteLine(((Mascota)item).nombre);
                else
                Console.WriteLine("Elemento: " + item);
            }

            Console.Write("\nDevuelvo el próximo a salir con método Peek: ");
            Console.WriteLine(colaNoGenerica.Peek());

            Console.WriteLine("\nElimino elementos:\n");
            colaNoGenerica.Dequeue();
            colaNoGenerica.Dequeue();

            foreach (object item in colaNoGenerica)
            {
                if (item is Mascota)
                    Console.WriteLine(((Mascota)item).nombre);
                else
                    Console.WriteLine("Elemento: " + item);
            }
            
            */

            /*
           Console.WriteLine("Listas dinámicas");
           Console.WriteLine("----------------\n");
           System.Collections.ArrayList listaNoGenerica = new System.Collections.ArrayList();

            Console.WriteLine("Agrego elementos:\n");
            Mascota mascota = new Mascota("Thaís", 6);
            listaNoGenerica.Add(4);
            listaNoGenerica.Add("Juan");
            listaNoGenerica.Add(mascota);
            listaNoGenerica.Add(false);
            listaNoGenerica.Add(8);
            

            foreach (object item in listaNoGenerica)
           {
               Console.WriteLine("Elemento: " + item);
           }


            Console.WriteLine("\nElimino elementos:\n");
            listaNoGenerica.Remove(false);
            listaNoGenerica.Remove(mascota);
            listaNoGenerica.Remove(8);

            foreach (object item in listaNoGenerica)
           {
               Console.WriteLine("Elemento: " + item);
           }
            */

            /*
            Console.WriteLine("Hashtable ---> Clave - Valor");
            Console.WriteLine("----------------------------\n");
            System.Collections.Hashtable hashtable = new System.Collections.Hashtable();

            Console.WriteLine("Agrego elementos: \n");
            hashtable.Add(3, "Pedro");
            hashtable.Add(false, 3.4f);
            hashtable.Add(DateTime.Now, new Mascota("Lobo", 9));

            foreach(System.Collections.DictionaryEntry item in hashtable)
            {
                Console.WriteLine("Clave: " + item.Key + " - Valor: " + item.Value);
            }

            Console.WriteLine("\nElimino elementos: \n");
            hashtable.Remove(false);
            hashtable.Remove(3);


            foreach (System.Collections.DictionaryEntry item in hashtable)
            {
                Console.WriteLine("Clave: " + item.Key + " - Valor: " + item.Value);
            }
            */
            #endregion


            #region Colecciones genéricas
            //Incluir libreria System.Collections.Generic
            /*
            Console.WriteLine("-----------------------");
            Console.WriteLine("-COLECCIONES GENÉRICAS-");
            Console.WriteLine("-----------------------\n\n");
            
            Console.WriteLine("PILA----> Comportamiento tipo LIFO");
            Console.WriteLine("-----------------------------------\n");
            Stack<string> pila = new Stack<string>();

            Console.WriteLine("Apilo con método Push:\n");
            Console.WriteLine();
            pila.Push("Juan");
            pila.Push("Pedro");
            pila.Push("Pablo");
            pila.Push("Lucas");

            foreach (string item in pila)
            {
                Console.WriteLine("Elemento: " + item);
            }

            Console.Write("\nDevuelvo el próximo a salir con método Peek: ");
            Console.WriteLine(pila.Peek());

            Console.WriteLine("\nDesapilo con método Pop\n");
            pila.Pop();
            pila.Pop();

            foreach (string item in pila)
            {
                Console.WriteLine("Elemento: " + item);
            }
            */

            /*
            Console.WriteLine("COLA----> Comportamiento tipo FIFO");
            Console.WriteLine("----------------------------------\n");
            Queue<int> cola = new Queue<int>();

           Console.WriteLine("Agrego elementos:\n");
           cola.Enqueue(2);
           cola.Enqueue(4);
           cola.Enqueue(6);
           cola.Enqueue(8);

            foreach (int item in cola)
           {
               Console.WriteLine("Elemento: " + item);
           }

            Console.Write("\nDevuelvo el próximo a salir con método Peek: ");
            Console.WriteLine(cola.Peek());

            Console.WriteLine("\nElimino elementos:\n");
            cola.Dequeue();
            cola.Dequeue();

           foreach (int item in cola)
           {
               Console.WriteLine("Elemento: " + item);
           }
            */

            /*
           Console.WriteLine("Listas dinámicas");
           Console.WriteLine("----------------\n");
           List<int> lista = new List<int>();

           //Agrego elementos.
           lista.Add(4);
           lista.Add(6);
           lista.Add(2);
           lista.Add(8);

           Console.WriteLine("Ordeno ascendente:\n");
            lista.Sort();

           foreach (int item in lista)
           {
               Console.WriteLine("Elemento: " + item);
           }

           Console.WriteLine("\nOrdeno descendente:\n");
           lista.Reverse();

           foreach (int item in lista)
           {
               Console.WriteLine("Elemento: " + item);
           }

           Console.WriteLine("\nElimino elementos:\n");
           lista.Remove(2);
           lista.Remove(4);
            foreach (int item in lista)
           {
               Console.WriteLine("Elemento: " + item);
           }
          
            */
            /*
            Console.WriteLine("Dictionary ---> Clave - Valor");
            Console.WriteLine("-----------------------------\n");
            Dictionary<int, string> diccionario = new Dictionary<int, string>();

            Console.WriteLine("Agrego elementos:\n");
            diccionario.Add(1, "Federico");
            diccionario.Add(2, "Juan");
            diccionario.Add(3, "Lucas");
            diccionario.Add(4, "Pedro");

             foreach (KeyValuePair<int,string> item in diccionario)
            {
                Console.WriteLine("Clave: " + item.Key + " Valor: " + item.Value);
            }
             Console.WriteLine("\nElimino elementos:\n");

             diccionario.Remove(2);

             foreach (KeyValuePair<int, string> item in diccionario)
             {
                 Console.WriteLine("Clave: " + item.Key + " Valor: " + item.Value);
             }*/

            #endregion

            

            Veterinaria vet = new Veterinaria(3);

            vet += new Mascota("Chicho", 3);
            vet += new Mascota("Juan", 4);
            vet += new Mascota("Pancho", 2);

            foreach (Mascota item in vet.lista)
            {
                Console.WriteLine(item.ToString());
            }


            Console.ReadKey();
        }
    }
}