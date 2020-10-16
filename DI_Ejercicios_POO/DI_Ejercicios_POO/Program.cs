using System;

namespace DI_Ejercicios_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean menuActivado = true;
            do
            {
                Console.WriteLine("\n*********************************************************************************************" +
                    "\n[1]-EJ1: Desarrollar un programa que tenga una clase que represente un Cuadrado" +
                    "\n[2]-EJ2: Implementar la clase operaciones" +
                    "\n[3]-EJ3: Clase Banco" +
                    "\n[4]-EJ4: Clase Persona" +
                    "\n[5]-SALIR" +
                    "\n*********************************************************************************************");

                Console.Write("Inserte una de las opciones (inserte un número entero): ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine(".:. Ejercicio 1 .:.");
                        Console.Write("Inserte cuanto valen los lados del cuadrado \nRecuerde que son todos iguales: ");
                        Double ladoCuadrado = Convert.ToDouble(Console.ReadLine());
                        Cuadrado c1 = new Cuadrado(ladoCuadrado);

                        Console.WriteLine("Solución:");
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

                        Console.WriteLine("Solución:");
                        break;

                    case 4:
                        Console.WriteLine(".:. Ejercicio 4 .:.");

                        Console.WriteLine("Solución:");
                        break;

                    case 5:
                        menuActivado = false;
                        Console.WriteLine("Hasta pronto");
                        break;

                    default:
                        Console.WriteLine("Opción no disponible");
                        break;

                }

            } while (menuActivado);
            Console.ReadLine();
        }
    }
}
