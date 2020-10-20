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

        //Métodos
        /// <summary>
        /// Nos deposita más dinero en nuestra cuenta
        /// </summary>
        /// <param name="ingreso"></param>
        public void depositar(Double ingreso)
        {
            this.dinero += ingreso;
        }

        /// <summary>
        /// Método que nos extrae dienro de nuestra cuenta
        /// Si la cantidad a retirar es mayor que lo que tenemos depositado o
        /// no hay dinero suficiente nos aparecerá un error
        /// </summary>
        /// <param name="subs"></param>
        public void extraer(Double subs)
        {
            if(this.dinero <= 0 || this.dinero < subs)
            {
                Console.WriteLine("No se disponene de suficientes fondos para extraer la cantidad deseada");
            }
            else
            {
                this.dinero -= subs;
            }
        }

        /// <summary>
        /// Nos devuelve el dinero del que dispone el cliente actualmente
        /// </summary>
        /// <returns></returns>
        public Double retornaDinero()
        {
            return this.dinero;
        }
    }
}
