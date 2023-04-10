using Teoria_Ejemplos_Clases.Models;

namespace Teoria_Ejemplos_Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int numero = 2;
            int resultado = Math.ElevarAlCuadrado(numero);
            Console.WriteLine(resultado);*/
            Persona p1 = new Persona("Agostina", "Bar", 666);
            Persona p2 = new Persona(666);

            if(p1 == p2 )
            {
                Console.WriteLine("SON IGUALES");
            }
            else {
                Console.WriteLine("SON DISTINTOS");
            }

            Console.WriteLine(p1 + p2);//Ya esta encapsulada la logica cuando queremos sumar los legajos de ambos objetos
            CD acdc = new CD(11);
            acdc.titulo = "Back in black";
            acdc.anio = 1980;

            //Console.WriteLine(p.GetDatos());
            Console.WriteLine(p1);
        }
    }
}