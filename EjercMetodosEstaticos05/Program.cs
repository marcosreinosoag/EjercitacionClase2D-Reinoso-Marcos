using System;
using System.Text;

//Desarrollar un método estático que reciba un número y devuelva la tabla de multiplicación de ese número en formato string.
//Se deberá utilizar la clase StringBuilder combinada con strings interpolados para armar el resultado.
//Mostrar en la consola el resultado.
//Por ejemplo, si se ingresa el número 2 la salida deberá ser:

namespace EjercMetodosEstaticos05
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroUno;
            string resultado;
            Console.WriteLine("ingrese un numero");
            int.TryParse(Console.ReadLine(), out numeroUno);
            resultado = TablasDelNumero(numeroUno);
            Console.WriteLine($"{resultado}");
        }
        private static string TablasDelNumero(int numero)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i < 10; i++)
            {
                sb.AppendLine($"{numero} x {i} = {numero * i}");
            }
            return sb.ToString();
        }
    }
}
