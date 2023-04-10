using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teoria_Ejemplos_Clases.Models
{
    internal class Persona //Generalizacion, donde entran todas las unidades de Persona. Instancia se refiere a uno en particular
    {
        /*
         -- Abstraccion: caracteristicas esenciales
         -- Encapsulamiento: De los detalles de la implementacion, por ej solo algunas cosas visibles
         -- Herencia: Compartir o reutilizar comportamiento y atributos definidos en otra clase
         -- Polimorfismo: Objetos diferentes puedan hacer la misma accion
         -- Acoplamiento: Grado de independencia que tienen dos piezas de software entre sí
         -- Responsabilidad unica: cada pieza hace una tarea unica, no tenemos dos piezas que haga lo mismo

         */

        //Atributos (caracteristica o estado de un objeto)
        public string Nombre { get => _nombre; set => _nombre = value; }
        private string _nombre;
        public string Apellido { get => _apellido; set => _apellido = value; }
        private string _apellido;
        public int Promedio { get; set; } = 0; //DANDOLE VALOR DE INICIALIZACION
        public int Legajo { 
            get => _legajo;
            private init => _legajo = value < 100000 ? value : throw new InvalidOperationException(); 
        }
        private int _legajo; //Solo lo vamos a poder ver dentro de la clase porque es privado
        private static Random random;
        //Acciones 

        //LAS CLASES ESTATICAS NO SE LLAMAN, por lo tanto este metodo no lo ejecutamos,
        //sino que se ejecuta al primer uso de la clase
        static Persona() { 
            random = new Random();  
        }

        //Se pueda hacer una sobrecarga, es decir, un nuevo constructor de Persona con el mismo nombre pero tiene que recibir otros parametros distintos
        //al que ya existe:
        
        public Persona(int legajo)
        {
            Legajo = legajo;
        }

        //Puedo sobrecargar métodos, constructores, operadores e indexadores
       public Persona(string nombre, string apellido, int legajo) {
            this._nombre = nombre;
            this._apellido = apellido;
            Legajo = legajo; // ES UNA PROPIEDAD Y SE EJECUTA LA PROPIEDAD DE ARRIBA
        }
        //SI LOS ATRIBUTOS SON PRIVADOS TENGO QUE RECURRIR A SETTERS Y GETTERS
        public void SetLegajo(int legajo)
        {
            //con el this accedo a la variable de la instancia
            this._legajo = legajo;
        }

        public int GetLegajo()
        {
           return this._legajo;
        }

        public int BuscarLetra(char letra)
        {
            var text = "alma";


            return 0;
        }
        public bool Equals(Persona persona) {
            return _legajo == persona._legajo;
        }
        public void DarAsistencia() { 
        }
        //El override deja sobreescribir un metodo que es heredado
        //public override string ToString()
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("====================");
            sb.AppendLine($"Nombre: {_nombre}");
            sb.AppendLine($"Apellido: {_apellido}");
            sb.AppendLine($"Legajo: {_legajo}");
            sb.AppendLine("====================");
            return sb.ToString(); 
        }

        //Para sobrecargar un operador tiene que ser un metodo publico y estatico
                                   //operador ==
        public static bool operator ==(Persona p1, Persona p2) {
            return p1.Legajo == p2.Legajo;
        }

        public static bool operator !=(Persona p1, Persona p2)
        {
            return !(p1 == p2); 
        }
        public static int operator +(Persona p1, Persona p2)
        {
            return p1.Legajo + p2.Legajo;
        } //ESTO SE PUEDE SOBRECARGAR:

        public static int operator +(Persona p1, int numero)
        {
            return p1.Legajo + numero;
        }
        /*static void MetodoEstatico()
        {
        }

         Metodo estatico, se genera un solo lugar en memoria. No necesitamos instanciarlo.
        Si es estático lo accedo desde la clase:
        Persona.MetodoEstatico();

        Si no es estático, lo accedo desde la instancia

        Persona personaUno;

        personaUno = new Persona();

        personaUno.nombre = "Agos";
         */
    }
}
