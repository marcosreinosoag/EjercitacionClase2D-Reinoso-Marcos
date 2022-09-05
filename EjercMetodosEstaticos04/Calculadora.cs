using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Calcular(público): Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática. El método devolverá el resultado de la operación.
//Validar (privado): Recibirá como parámetro el segundo operando. Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá true si el operando es distinto de cero.

namespace EjercMetodosEstaticos04
{
    class Calculadora
    {

        public static double Calcular(double operandoUno, double operandoDos, string operacionMatematica)
        {
            double retorno = double.MinValue;
            bool divisionValida;

            switch (operacionMatematica)
            {
                case "-":
                    {
                        retorno = operandoUno - operandoDos;
                        break;
                    }
                case "+":
                    {
                        retorno = operandoUno + operandoDos;
                        break;
                    }
                case "*":
                    {
                        retorno = operandoUno * operandoDos;
                        break;
                    }
                case "/":
                    {
                        divisionValida = Validar(operandoDos);
                        if (divisionValida == false)
                        {
                            Console.WriteLine("La division no se pudo realizar");
                            break;
                        }
                        retorno = operandoUno / operandoDos;
                        break;
                    }
            }
            return retorno;
        }
        private static bool Validar(double operadorDos)
        {
            bool retorno = false;
            if (operadorDos != 0)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
