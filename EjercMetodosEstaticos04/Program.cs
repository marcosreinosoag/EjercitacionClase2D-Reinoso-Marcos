//Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división).
//Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
//Calcular(público): Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática. El método devolverá el resultado de la operación.
//Validar (privado): Recibirá como parámetro el segundo operando. Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá true si el operando es distinto de cero.
//Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (ingresando el caracter +, -, * o /)
//El usuario decidirá cuándo finalizar el programa.

using System;

namespace EjercMetodosEstaticos04
{
    class Program
    {
        static void Main(string[] args)
        {
            double numeroUno;
            double numeroDos;
            string operacion;
            double resultado;
            Console.WriteLine("ingrese numero");
            double.TryParse(Console.ReadLine(), out numeroUno);
            Console.WriteLine("ingrese numero");
            double.TryParse(Console.ReadLine(), out numeroDos);
            Console.WriteLine("Ingrese la operacion matematica que desea realizar -,+,/,* ");
            operacion = Console.ReadLine();
            resultado = Calculadora.Calcular(numeroUno, numeroDos, operacion);
            if (resultado != double.MinValue)
            {
                Console.WriteLine($"El resultado de {numeroUno} {operacion} {numeroDos} es {resultado} ");
            }
        }
    }
}
