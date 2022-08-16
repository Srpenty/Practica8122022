using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el numero a evaluar: ");
            int multiplo = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el numero limite: ");
            int limite = int.Parse(Console.ReadLine());
            for (int i = 0; i <= limite; i++)
                if (i % multiplo == 0)
                    Console.Write(i + " ");
        }
    }
}
