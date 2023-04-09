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
            Persona p = new Persona("Agostina", "Bar", 123456);

            Console.WriteLine(p.GetDatos());
        }
    }
}