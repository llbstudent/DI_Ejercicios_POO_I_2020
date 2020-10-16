using System;
using System.Collections.Generic;
using System.Text;

namespace DI_Ejercicios_POO
{
    /// <summary>
    /// Clase Dado, de la relación de ejercicios de Programación Orientada a Objetos.
    /// 
    /// Nos pide: Ingresar  valor a su lado, imprimir su perímetro y su superficie.
    /// </summary>
    class Cuadrado
    {
        //Atributos
        private Double lado;

        //Constructores
        public Cuadrado() { }

        public Cuadrado(Double lado) {
            this.lado = lado;
        }


        //Modificadores de acceso (Setters y Getters)
        public Double LADO
        {
            get { return this.lado; }
            set { this.lado = value; }
        }


        //Métodos
        public Double calcularPerimetro_y_Superficie()
        {
            return this.lado * 4;
        }
    }
}
