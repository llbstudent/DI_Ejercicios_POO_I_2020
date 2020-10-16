using System;
using System.Collections.Generic;
using System.Text;

namespace DI_Ejercicios_POO
{
    class Operaciones
    {
        //Variables
        private int num1, num2;

        //Constructores
        public Operaciones() { }

        public Operaciones(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }


        //Modificadores de acceso
        public int NUM1
        {
            get { return this.num1; }
            set { this.num1 = value; }
        }


        public int NUM2
        {
            get { return this.num2; }
            set { this.num2 = value; }
        }



        //Métodos de la clase 'Operaciones' para hacer las operaciones básicas
        
        //SUMA
        public int calculaSuma() {
            return this.num1 + this.num2;
        }

        //RESTA
        public int calculaResta()
        {
            return this.num1 - this.num2;
        }


        //MULTIPLICACIÓN
        public int calculaMultiplicacion()
        {
            return this.num1 * this.num2;
        }


        //DIVISIÓN
        public int calculaDivision()
        {
            return this.num1 / this.num2;
        }
    }
}
