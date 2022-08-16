using System;

namespace Tarea
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("Introdusca un numero: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Introdusca otro numero: ");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Precione uno de los siguientes numeros segun la operacion matematica que desea hacer");
                Console.WriteLine("1-Suma");
                Console.WriteLine("2-Resta");
                Console.WriteLine("3-Multiplicacion");
                Console.WriteLine("4-Division");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        static int suma(int num1, int num2) => num1 + num2;
                        Console.WriteLine("El resultado es: " + suma(num1, num2));
                        break;
                    case 2:
                        static int resta(int num1, int num2) => num1 - num2;
                        Console.WriteLine("El resultado es: " + resta(num1, num2));
                        break;
                    case 3:
                        static int multiplicacion(int num1, int num2) => num1 * num2;
                        Console.WriteLine("El resultado es: " + multiplicacion(num1, num2));
                        break;
                    case 4:
                        static double division(int num1, int num2)
                        {
                            double numd1 = Convert.ToDouble(num1);
                            double numd2 = Convert.ToDouble(num2);
                            return numd1 / numd2;
                        }
                        Console.WriteLine("El resultado es: " + division(num1, num2));
                        break;
                    default:
                        Console.WriteLine("Esta opcion no esta disponible");
                        break;
                }
                Console.WriteLine("Precione cualquier numero para hacer otra operacion matematica y 1 para salir del programa");
                opcion = int.Parse(Console.ReadLine());
            } while (opcion != 1);

      
        }
    }
}
