using System;
using System.Collections.Generic;
using System.Text;

namespace DI_Ejercicios_POO
{

    /// <summary>
    /// Clase Cliente para la resolución del ejercicio 3
    /// </summary>
    class Cliente
    {
        //Variables
        private String nombre;
        private Double dinero;

        //Cosntructores
        public Cliente() { }

        public Cliente(String nombre, Double dinero) {
            this.nombre = nombre;
            this.dinero = dinero;
        }

        //Modificadores de acceso
        public String NOMBRE
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public Double DINERO
        {
            get { return this.dinero; }
            set { this.dinero = value; }
        }


        /*
         
           nombre
        dinero
    métodos
        constructor
        Depositar
        Extraer
        Retornardiner
         */
    }
}
