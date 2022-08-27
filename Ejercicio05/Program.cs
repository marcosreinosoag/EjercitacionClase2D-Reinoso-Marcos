using System;

namespace Ejercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumaPrimerGrupo;
            int sumaSegundoGrupo;
            int numeroIngresado;
            Console.WriteLine("Ingrese un numero ");
            int.TryParse(Console.ReadLine(), out numeroIngresado);
            while (numeroIngresado <= 0)
            {
                Console.WriteLine("Error! Reingrese el numero");
                int.TryParse(Console.ReadLine(), out numeroIngresado);
            }
            Console.WriteLine($"Los numeros centricos que hay hasta el numero ingresado {numeroIngresado} son: ");

            for (int j = 2; j <= numeroIngresado; j++)
            {
                sumaPrimerGrupo = 0;
                sumaSegundoGrupo = 0;

                for (int i = 1; i < j; i++)
                {
                    sumaPrimerGrupo += i;
                }
                for (int k = j + 1; sumaSegundoGrupo < sumaPrimerGrupo; k++)
                {
                    sumaSegundoGrupo += k;
                }
                if (sumaPrimerGrupo == sumaSegundoGrupo)
                {
                    Console.WriteLine($"El numero {j} es un numero centrico");
                }
            }
        }
    }
}
