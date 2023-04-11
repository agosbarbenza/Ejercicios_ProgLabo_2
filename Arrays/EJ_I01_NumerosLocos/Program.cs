using System;

namespace EJ_I01_NumerosLocos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();

            Random randomm = new Random();

            
            
                lista.Add(randomm.Next(1, 100));
                Console.WriteLine(randomm.Next(-100, 100));
            
        }
    }
}