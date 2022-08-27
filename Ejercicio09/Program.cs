using System;

namespace Ejercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int numeroARestar = 0;
            int numeroASumar = 0;
            Console.WriteLine("Ingrese un numero ");
            int.TryParse(Console.ReadLine(), out numeroIngresado);
            while (numeroIngresado <= 0)
            {
                Console.WriteLine("Error! Reingrese el numero");
                int.TryParse(Console.ReadLine(), out numeroIngresado);
            }
            for (int i = 1; i < numeroIngresado; i++)
            {
                numeroARestar += 1;
                Console.Write("     ");
                for (int j = 0; j < numeroIngresado - numeroARestar; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i + numeroASumar; j++)
                {
                    Console.Write("*");
                }
                numeroASumar += 1;
                Console.WriteLine();
            }
        }
    }
}
