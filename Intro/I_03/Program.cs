using System.Text;
namespace I_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
           // int numeroIngresado = int.Parse(Console.ReadLine());
           // bool sePudo = int.TryParse(numeroIngresado, out int resultado); 
           //Console.WriteLine(ListarNumerosPrimos(numeroIngresado));
           //Ya no usamos puntero, usamos ref o out                declaro la variable result
            bool respuesta = int.TryParse(Console.ReadLine(), out int result);
        }

        public static string ListarNumerosPrimos(int hasta)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 2; i <= hasta; i++)
            {
                //Aca va la funcion que determina si un nuermo es primo
                if (EsPrimo(i))
                {
                    sb.Append($"{i}, "); //El $ es interpolacion de strings, y codigo C# entre llaves.

                }
            }
            return sb.ToString(); //Tengo que ponerle el toString porque estoy devolviendo un string
        }

        public static bool EsPrimo(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }

                
            }
            return true;
        }
    }
}