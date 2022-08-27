using System;

namespace Ejercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            Console.WriteLine("Ingrese un numero ");
            int.TryParse(Console.ReadLine(), out numeroIngresado);
            while (numeroIngresado <= 0)
            {
                Console.WriteLine("Error! Reingrese el numero");
                int.TryParse(Console.ReadLine(), out numeroIngresado);
            }
            for (int i = 1; i < numeroIngresado; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
