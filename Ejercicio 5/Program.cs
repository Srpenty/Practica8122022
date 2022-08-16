using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            string linea;
            do
            {
                Console.Write("Ingrese un valor entre 0 y 999 (0 finaliza): ");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                if (valor >= 100)

                    Console.WriteLine("Tiene 3 digitos.");

                else if (valor >= 10)

                    Console.WriteLine("Tiene 2 digitos");

                else

                    Console.WriteLine("Tiene 1 digito");
            } while (valor != 0);


        }
    }
}
