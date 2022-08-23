using System;

namespace Ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            string palabraIngresada;
            int restoDaCero = 0;
            do
            {
                Console.WriteLine("Ingrese un numero (El numero ingresado debe ser mayor que 1");
                int.TryParse(Console.ReadLine(), out numeroIngresado);
                while (numeroIngresado <= 1)
                {
                    Console.WriteLine("Error! Reingrese el numero");
                    int.TryParse(Console.ReadLine(), out numeroIngresado);
                }
                Console.WriteLine($"Los numeros primos que hay hasta el numero ingresado {numeroIngresado} son: ");
                for (int j = numeroIngresado; j > 1; j--)
                {
                    restoDaCero = 0;
                    for (int i = j; i > 0; i--)
                    {
                        if (j % i == 0)
                        {
                            restoDaCero++;
                        }
                    }
                    if (restoDaCero == 2)
                    {
                        Console.WriteLine(j);
                    }
                }
                Console.WriteLine("Ingrese Salir para terminar el programa");
                palabraIngresada = Console.ReadLine().Trim().ToUpper();
            } while (palabraIngresada != "SALIR");
        }
    }
}
