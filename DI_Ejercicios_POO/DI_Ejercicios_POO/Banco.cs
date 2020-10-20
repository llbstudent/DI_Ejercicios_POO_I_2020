using System;
using System.Collections.Generic;
using System.Text;

namespace DI_Ejercicios_POO
{
    class Banco
    {
        //Atributos
        Cliente cli1, cli2, cli3;

        //Constructores
        public Banco() { }

        public Banco(Cliente c1, Cliente c2, Cliente c3) {
            this.cli1 = c1;
            this.cli2 = c2;
            this.cli3 = c3;
        }


        //Modificadores de acceso
        public Cliente CLIENTE1
        {
            get { return this.cli1; }
            set { this.cli1 = value; }
        }


        public Cliente CLIENTE2
        {
            get { return this.cli2; }
            set { this.cli2 = value;}
        }


        public Cliente CLIENTE3
        {
            get { return this.cli3; }
            set { this.cli3 = value; }
        }


        // ============================
        //  Métodos
        // ============================


        /// <summary>
        /// Con este método comprobaremos que funcionan correctamente todos los métodos de la clase 'Cliente'
        /// Es más dinámico y te permite elegir insertando enteros la opció que desee realizar
        /// </summary>
        public void operar()
        {
            Console.WriteLine("***********************************" +
                "\n[1]- Cliente 1" +
                "\n[2]- Cliente 2" +
                "\n[3]- Cliente 3" +
                "\n***********************************");

            Console.Write("Seleccione al cliente con el que desee operar: ");
            int opcionCliente = Convert.ToInt32(Console.ReadLine());

            switch (opcionCliente)
            {
                case 1:
                    Console.WriteLine(".:. CLIETE 1 .:." +
                        "\n[1]-Extraer Dinero" +
                        "\n[2]-Depositar" +
                        "\n[3]-Ver ingresos");

                    Console.Write("Seleccione operacion: ");
                    int operacion = Convert.ToInt32(Console.ReadLine());

                    gestionOperacion(this.cli1, operacion);
                    break;

                case 2:
                    Console.WriteLine(".:. CLIETE 2 .:." +
                        "\n[1]-Extraer Dinero" +
                        "\n[2]-Depositar" +
                        "\n[3]-Ver ingresos");

                    Console.Write("Seleccione operacion: ");
                    int operacion2 = Convert.ToInt32(Console.ReadLine());

                    gestionOperacion(this.cli2, operacion2);
                    break;

                case 3:
                    Console.WriteLine(".:. CLIETE 3 .:." +
                        "\n[1]-Extraer Dinero" +
                        "\n[2]-Depositar" +
                        "\n[3]-Ver ingresos");

                    Console.Write("Seleccione operacion: ");
                    int operacion3 = Convert.ToInt32(Console.ReadLine());

                    gestionOperacion(this.cli3, operacion3);
                    break;

                default:
                    Console.Write("Cliente no registrado");
                    break;
            }
        }

        public void verDepositosTotales()
        {
            Console.WriteLine("********** INGRESOS TOTALES **********" +
                "\nCliente 1: " + this.cli1.retornaDinero() +
                "\nCliente 2: " + this.cli2.retornaDinero() +
                "\nCliente 3: " + this.cli3.retornaDinero() +
                "\n******************************");
        }
        
        /// <summary>
        /// Método complementario de la clase 'operacion'
        /// Que nos ayudará a gestionar mejor las operaciones
        /// </summary>
        /// <param name="cli"></param>
        /// <param name="operacion"></param>
        private void gestionOperacion(Cliente cli, int operacion)
        {
            switch (operacion)
            {
                case 1:
                    Console.Write("Seleccione la cantidad que desee extraer: ");
                    Double subs = Convert.ToDouble(Console.ReadLine());
                    cli.extraer(subs);
                    break;

                case 2:
                    Console.Write("Seleccione la cantidad que desee depositar: ");
                    Double dep = Convert.ToDouble(Console.ReadLine());
                    cli.depositar(dep);
                    break;

                case 3:
                    Console.WriteLine("Ingresos del cliente 1: " + cli.retornaDinero());
                    break;

                default:
                    break;
            }
        }
    }
}
