using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EjI01_Sumador
{
    internal class Sumador
    {
        private int _cantidadSumas;

        public int CantidadSumas { get => _cantidadSumas; set => _cantidadSumas = value; }

        //Crear dos constructores:
        public Sumador(int cantidadSumas) 
        {
            _cantidadSumas = cantidadSumas;
        }
        public Sumador() : this(0) { }

        //El método Sumar incrementará cantidadSumas en 1 y
        //adicionará sus parámetros con la siguiente lógica:

        /*En el caso de Sumar(long, long) sumará los valores numéricos
          En el de Sumar(string, string) concatenará las cadenas de texto.*/

        public int Sumar(int cantSumas){            
            return cantSumas++;
        }

        public long Sumar(long numeroUno, long numeroDos)
        {
            CantidadSumas += 1;
            return numeroUno + numeroDos;
        }

        public string Sumar(string cadenaUno, string cadenaDos)
        {
            CantidadSumas += 1;
            return string.Format($"{cadenaUno}{cadenaDos}");

        }
        //Generar una conversión explícita que retorne cantidadSumas.
        public static explicit operator int(Sumador sumador) {
            return sumador._cantidadSumas;
        }

        // Sobrecargar el operador + (suma) con dos operadores de tipo Sumador.
        // El resultado será un long correspondiente al resultado de la suma del atributo cantidadSumas
        // de cada argumento.
        public static long operator +(Sumador sumadorUno, Sumador sumadorDos)
        {
            return (int)sumadorUno + (int)sumadorDos;
        }

        //Sobrecargar el operador | (pipe) con dos operadores de tipo Sumador.
        //Deberá retornar true si ambos sumadores tienen igual valor en el atributo cantidadSumas.

        public static bool operator |(Sumador sumadorUno, Sumador sumadorDos)
        {
            bool result = false;
            if ((int)sumadorUno == (int)sumadorDos) {
                result = true;
            } 
            return result;
            
        }

    }
}
