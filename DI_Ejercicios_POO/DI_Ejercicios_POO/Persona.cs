using System;
using System.Collections.Generic;
using System.Text;

namespace DI_Ejercicios_POO
{
    /// <summary>
    /// Clase persona
    /// Instanciaremos 2 de ellas en 'program'
    /// Tendrán el único método de saludar
    /// </summary>
    class Persona
    {
        //Atributo
        private String nombre;

        //Constructor
        public Persona(String nombre)
        {
            this.nombre = nombre;
        }

        //Métodos acceso
        public String NOMBRE
        {
            set { this.nombre = value; }
            get { return this.nombre; }
        }

        //Método saludar
        public void saludar()
        {
            Console.WriteLine("Hola, soy " + this.nombre);
        }
    }
}
