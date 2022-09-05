using System;

namespace EjercMetodosEstaticos01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int numeroMinimo = int.MaxValue;
            int numeroMaximo = int.MinValue;
            double acumulador = 0;
            int i = 1;
            do
            {
                Console.WriteLine("Ingrese un numero: ");
                while (int.TryParse(Console.ReadLine(), out numeroIngresado) == false || Validador.Validar(numeroIngresado, -100, 100) == false)
                {
                    Console.WriteLine("Error reingrese un numero: ");
                }
                if (numeroIngresado > numeroMaximo)
                {
                    numeroMaximo = numeroIngresado;
                }
                if (numeroIngresado < numeroMinimo)
                {
                    numeroMinimo = numeroIngresado;
                }
                acumulador += numeroIngresado;
                i++;
            } while (i < 11);
            Console.WriteLine($"El numero minimo ingresado es: {numeroMinimo} \nEl numero Maximo ingresado es: {numeroMaximo}\nEl promedio es {acumulador/10}");
        }
    }
}
