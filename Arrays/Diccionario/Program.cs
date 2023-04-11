namespace Diccionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> maquinaExpendedora = new Dictionary<int,string>();
            maquinaExpendedora.Add(1, "Bolsa de papas");
            maquinaExpendedora.Add(2, "Coca Cola");
            maquinaExpendedora.Add(3, "Doritos");


            foreach (var item in maquinaExpendedora)
            {
                Console.WriteLine("ID:"+item.Key+"Valor: "+ item.Value);
            }


        }
    }
}