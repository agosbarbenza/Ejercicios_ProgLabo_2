using System.Collections;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 2, 3, 4, 5 };

            //int[,] bidi = new int[2, 2]; //Array bidireccional, cada posicion de mi array va a tener otro array
            int[,] bidi = { { 1, 2 }, { 3,4} };
            /**
             * En Coleccion No generica se guarda cualquier tipo de dato.En general no las vamos a utilizar
             * Listas: ArrayList - Hashtable - Queue - Stack
             */

            ArrayList arrayList = new ArrayList(); //reservamos espacio en memoria para un objeto de tipo ArrayList
            //arrayList[0] = 1;
            //arrayList.Add(12);

            arrayList.Add("Agos");
            arrayList.Add("Juan");
            arrayList.Add("Bilbo");

            foreach (var item in arrayList)
            {
                var i = arrayList.IndexOf(item);
                var s = item.ToString().ToUpper(); //Funciona pero que si el toString falla le estas haciendo un upper y va a romper
                Console.WriteLine($"{i} - {s}");
            }

            //Colecciones genericas
            List<string> lista = new List<string>();
            lista.Add("Agos");
            lista.Add("Juan");
            lista.Add("Bilbo");
            // lista.Add(1); no me deja hacerlo porque lo que le pase por parametros no es un string

            foreach (var item in lista)
            {
                Console.WriteLine($"{item.ToUpper()}");
            }

            //objetos en memoria son mutables cuando hago el new
           var cds = new List<CD>();

            cds.Add(new CD(2221));
            cds.Add(new CD(123));
            cds.Add(new CD(551));
            cds.Add(new CD(882));

            /*foreach (var item in cds)
            {
                
            }*/

        }
    }
}