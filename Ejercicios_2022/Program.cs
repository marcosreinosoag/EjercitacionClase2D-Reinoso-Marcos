using System;

namespace Ejercicios_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int numeroMaximo = int.MinValue;
            int numeroMinimo = int.MaxValue;
            double acumulador = 0;

            int i = 0;

            while (i < 5)
            {
                Console.WriteLine("Ingrese un numero");
                int.TryParse(Console.ReadLine(), out numeroIngresado);

                if (numeroIngresado > numeroMaximo)
                {
                    numeroMaximo = numeroIngresado;
                }
                if (numeroIngresado < numeroMinimo)
                {
                    numeroMinimo = numeroIngresado;
                }
                i++;
                acumulador += numeroIngresado;
            }
            Console.WriteLine($"El numero maximo ingresado es: {numeroMaximo} y el numero minimo es: {numeroMinimo}, El promedio es: {acumulador/5}");
        }
    }
}
