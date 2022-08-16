using System;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Introduzca un numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca otro numero");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("La suma es: " + Suma(num1, num2));
            Console.WriteLine("La resta es: " + Resta(num1, num2));
            Console.WriteLine("La multiplicacion es: " + Multi(num1, num2));
            Console.WriteLine("La divicion es: " + Div(num1, num2));

            static int Suma(int num1, int num2)
            {
                var suma = num1 + num2;
                return suma;
            }
            static int Resta(int num1, int num2)
            { 
                return (num1 - num2); 
            }
            static int Multi(int num1, int num2) => num1 * num2;

            static double Div(int num1, int num2)
            {
                double numd1 = Convert.ToDouble(num1);
                double numd2 = Convert.ToDouble(num2);
                return numd1 / numd2;
            }
        }
    }
}
