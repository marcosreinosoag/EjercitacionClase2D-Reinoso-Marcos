using System;

namespace Ejercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int sumaDeDivisores;

            for (int j = 2; i < 5; j++)
            {
                sumaDeDivisores = 0;
                for (int k = 1; k < j; k++)
                {
                    if (j % k == 0)
                    {
                        sumaDeDivisores += k;
                    }
                    if (k == j - 1 && sumaDeDivisores == j)
                    {
                        i++;
                        Console.WriteLine($"El numero {j} es un numero perfecto.");
                        break;
                    }
                }
            }
        }
    }
}
