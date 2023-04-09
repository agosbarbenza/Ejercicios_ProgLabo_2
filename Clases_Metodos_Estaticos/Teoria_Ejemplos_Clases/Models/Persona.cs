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
        private string nombre;
        private string apellido; 
        private int legajo; //Solo lo vamos a poder ver dentro de la clase porque es privado

        //Acciones 

        public Persona(string nombre, string apellido, int legajo) {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }
        public void SetLegajo(int legajo)
        {
            //con el this accedo a la variable de la instancia
            this.legajo = legajo;
        }

        public int GetLegajo()
        {
           return this.legajo;
        }

        public int BuscarLetra(char letra)
        {
            var text = "alma";


            return 0;
        }
        public bool Equals(Persona persona) {
            return legajo == persona.legajo;
        }
        public void DarAsistencia() { 
        }
        //El override deja sobreescribir un metodo que es heredado
        //public override string ToString()
        public string GetDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("====================");
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Apellido: {apellido}");
            sb.AppendLine($"Legajo: {legajo}");
            sb.AppendLine("====================");
            return sb.ToString(); 
        }


        static void MetodoEstatico()
        {
        }

        /*Metodo estatico, se genera un solo lugar en memoria. No necesitamos instanciarlo.
        Si es estático lo accedo desde la clase:
        Persona.MetodoEstatico();

        Si no es estático, lo accedo desde la instancia

        Persona personaUno;

        personaUno = new Persona();

        personaUno.nombre = "Agos";
         */
    }
}
