using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class CD
    {
        public string titulo { get; set; }

        //Esto **encapsula** a la propiedad de abajo, se hace una funcion:
        public int anio//Propiedad que sirve para encapsular el atributo anio de abajo
        {/*
            //Con esto ya no es necesario crear getters y setters
            get { return _anio; }
            set { //si el set es privado se puede usar acá en la clase pero no por fuera
                if(value > 1900) //defino una condicion
                    _anio = value; //value es el parametro del setter
            }
            Es lo mismo poner:*/
            get => _anio;
            set => _anio = value > 1900 ? value : 0;
            //Se puede lanzar una excepcion para cuando se quiera agregar un dato invalido y que lance un error.
        }
        //Cuando trabajamos con atributos privados se acostumbra a ponerle _
        private int _anio; //Esto es un atributo

        public int Total { get => _id; }
        private int _id;

        public CD(int total)
        {
            _id = total;
        }
    }
}
