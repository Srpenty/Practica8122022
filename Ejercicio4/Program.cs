using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool condition = true;
            int cont = 0;
            Console.WriteLine("Ingrese un numero: ");
            int limite = int.Parse(Console.ReadLine());

            while (condition)
                if (cont == limite)
                    condition = false;
                cont++;
                Console.WriteLine(cont);

        }
    }
}
