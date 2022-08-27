using System;

namespace Ejercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroingresado;
            Console.WriteLine("ingrese un anio");
            int.TryParse(Console.ReadLine(), out numeroingresado);
            while (numeroingresado <= 999 && numeroingresado >= 99999)
            {
                Console.WriteLine("error! reingrese el anio");
                int.TryParse(Console.ReadLine(), out numeroingresado);
            }
            if ( numeroingresado% 100 == 0 && numeroingresado % 400 == 0 || numeroingresado % 4 == 0)
            {
                Console.WriteLine($"El anio {numeroingresado} es biciesto");
            }
            //for (int i = 1000; i < 9999; i++)
            //{
            //    if (i % 100 == 0 && i % 400 == 0 || i % 4 == 0)
            //    {
            //        Console.WriteLine($"El anio {i} ingresado es biciesto");
            //    }
            //}
        }
    }
}
