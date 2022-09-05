using System;

namespace EjercMetodosEstaticos02
{
    class Program
    {
        static void Main(string[] args)
        {
            bool respuesta;
            double numeroUno;
            double numeroDos;
            double resultado;
            do
            {
                Console.WriteLine("Ingrese un numero");
                double.TryParse(Console.ReadLine(), out numeroUno);
                Console.WriteLine("Ingrese un numero");
                double.TryParse(Console.ReadLine(), out numeroDos);
                resultado = numeroUno + numeroDos;
                Console.WriteLine($"La suma de ambos numeros ingresados es {resultado}");
                Console.WriteLine("Desea continuar?(S/N)");
                respuesta = Validador.ValidarRespuesta(Console.ReadLine());
            } while (respuesta != false);
        }
    }
}
