using System;

namespace DI_Ejercicios_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atributo que nos permitirá tener el menu activado
            Boolean menuActivado = true;
            do
            {
                Console.WriteLine("\n************************************.:. EJERCICIOS .:.**************************************************" +
                    "\n[1]-EJ1: Desarrollar un programa que tenga una clase que represente un Cuadrado" +
                    "\n[2]-EJ2: Implementar la clase operaciones" +
                    "\n[3]-EJ3: Clase Banco" +
                    "\n[4]-EJ4: Clase Persona" +
                    "\n[5]-SALIR" +
                    "\n**********************************************************************************************************");

                Console.Write("Inserte una de las opciones (inserte un número entero): ");
                int opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear(); //Limpiamos la consola

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine(".:. Ejercicio 1 .:.");
                        Console.Write("Inserte cuanto valen los lados del cuadrado \nRecuerde que son todos iguales: ");
                        Double ladoCuadrado = Convert.ToDouble(Console.ReadLine());
                        Cuadrado c1 = new Cuadrado(ladoCuadrado);

                        Console.WriteLine("\nSolución:");
                        Console.WriteLine("El perímetro es: " + c1.calcularPerimetro_y_Superficie());
                        Console.WriteLine("La superficie es: " + c1.calcularPerimetro_y_Superficie());
                        break;

                    case 2:
                        Console.WriteLine(".:. Ejercicio 2 .:.");
                        Console.WriteLine("Inserte dos números enteros para poder realizar con ellos las operaciones básicas");
                        //Insercción de números
                        Console.Write("Inserte el primer número: ");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Inserte el segundo número: ");
                        int num2 = Convert.ToInt32(Console.ReadLine());

                        //Creación del objeto 'Operaciones'
                        Operaciones op = new Operaciones(num1, num2);

                        Console.WriteLine("Seleccione el tipo de operacion que desea realizar:" +
                            "\n[1]- SUMA" +
                            "\n[2]- RESTA" +
                            "\n[3]- MULTIPLICACIÓN" +
                            "\n[4]- DIVISION");

                        Console.Write("Inserte un número entero para seleccionar la opción: ");
                        int opcionOperaciones = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Solución:");
                        //Seleccionamos la operación que deseamos realizar
                        switch (opcionOperaciones)
                        {
                            case 1:
                                Console.WriteLine("El resultado de la suma es: " + op.calculaSuma());
                                break;

                            case 2:
                                Console.WriteLine("El resultado de la resta es: " + op.calculaResta()); 
                                
                                break;

                            case 3:
                                Console.WriteLine("El resultado de la suma es: " + op.calculaMultiplicacion()); 
                                break;

                            case 4:
                                Console.WriteLine("El resultado de la suma es: " + op.calculaDivision());
                                break;

                            default:
                                Console.WriteLine("Opción disponible por el momento");
                                break;
                        }                        
                        break;

                    case 3:
                        Console.WriteLine(".:. Ejercicio 3 .:.");
                        //Nos creamos una serie de clientes por defecto
                        Cliente cli1 = new Cliente("Ana", 15203.26);
                        Cliente cli2 = new Cliente("Pedro", 12034.46);
                        Cliente cli3 = new Cliente("Marcial", 3152.58);

                        //Nos creamos nuestro Banco
                        Banco miBanco = new Banco(cli1, cli2, cli3);
                        //Variable que nos ayudará con nuestras gestiones de la clase Banco
                        Boolean salirBanco = false;

                        //Bucle que nos ayudará a mejorar la eficiencia para cuando ejecutemos las opciones de la clase banco
                        do
                        {
                            Console.WriteLine("***********************" +
                            "\n[1]-Operar" +
                            "\n[2]-Ver ingresos totales" +
                            "\n[3]-SALIR" +
                            "\n***********************");

                            Console.Write("Seleccione opcion (inserte un entero): ");
                            int opBanco = Convert.ToInt32(Console.ReadLine());

                            switch (opBanco)
                            {
                                case 1:
                                    miBanco.operar();
                                    break;

                                case 2:
                                    miBanco.verDepositosTotales();
                                    break;

                                case 3:
                                    salirBanco = true;
                                    break;
                            }
                        } while (!salirBanco);                        
                        break;

                    case 4:
                        Console.WriteLine(".:. Ejercicio 4 .:.");
                        Console.Write("¿Cómo se llama la primera persona? ");
                        String nombre1 = Console.ReadLine();
                        Console.Write("¿Cómo se llama la segunda persona? ");
                        String nombre2 = Console.ReadLine();

                        //Nos creamos a las personas
                        Persona per1 = new Persona(nombre1);
                        Persona per2 = new Persona(nombre2);

                        Console.WriteLine("Solución:");
                        per1.saludar();
                        per2.saludar();
                        break;

                    case 5:
                        menuActivado = false;
                        Console.WriteLine("Hasta pronto");
                        break;

                    default:
                        Console.WriteLine("Opción no disponible");
                        break;

                }//Fin switch opción (Menú principal)
            } while (menuActivado); //Fin do-While (Ejecución en bucle del menú principal)
            Console.ReadLine();
        }
    }
}
