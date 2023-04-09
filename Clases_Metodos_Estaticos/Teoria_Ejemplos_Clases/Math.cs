using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//se le puede colocar un alias por ej:
// using M = System.Math;

//namespace agrupa clases
namespace Teoria_Ejemplos_Clases
{
    internal class Math
    {
        static public int ElevarAlCuadrado(int resultado)
        {
            return resultado * resultado;
        }
        //Si el metodo es estático no tengo que instanciarlo para usarlo
        static public int Sumar(int numeroUno, int numeroDos)
        {
            return numeroUno + numeroDos;
        }
    }
}
