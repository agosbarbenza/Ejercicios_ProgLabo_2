namespace EjI01_Sumador
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Sumador numeroUno = new Sumador(10);
            int entero = (int)numeroUno; //Para convertir el objeto a entero


            Console.WriteLine(entero);
            //Cuando se pierde valor se hace explicita, si no pierde valor se hace implicita


            Sumador numeroDos = new Sumador();
            Sumador numeroTres = new Sumador(100);

            Console.WriteLine($"suma de objetos {numeroDos + numeroTres}");
            Console.WriteLine($"Suma de long : {numeroTres.Sumar(100, 687)} Sumador {numeroTres.CantidadSumas}");
            Console.WriteLine($"suma de objetos {numeroDos + numeroTres}");
            Console.WriteLine($"Suma de long : {numeroDos.Sumar("1234", "5555")} Sumador {numeroDos.CantidadSumas}");
            if (numeroDos | numeroTres)
            {
                Console.WriteLine("ES true");
            }
            Console.WriteLine($"suma de objetos {numeroDos + numeroTres}");


        }
    }
}