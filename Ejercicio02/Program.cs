using System;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            Console.WriteLine("Ingrese un numero");
            int.TryParse(Console.ReadLine(), out numeroIngresado);
            while (numeroIngresado <= 0)
            {
                Console.WriteLine("Error! Reingresar numero");
                int.TryParse(Console.ReadLine(), out numeroIngresado);
            }
            Console.WriteLine($"El numero al cuadrado es: {Math.Pow(numeroIngresado,2)}, El numero al cubo es {Math.Pow(numeroIngresado,3)}");
        }
    }
}
