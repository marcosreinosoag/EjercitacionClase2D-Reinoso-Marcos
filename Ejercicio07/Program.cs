using System;
using System.Text;

namespace Ejercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string opcion = " ";
            double valorHora = 300;
            double totalBruto;
            double totalNeto;
            int antiguedad;
            double calcularDescuento;
            double horasTrabajadas;
            StringBuilder datosDelTrabajador = new StringBuilder();
            DateTime hora = new DateTime();
            do
            {
                totalBruto = 0;
                totalNeto = 0;
                antiguedad = 0;
                calcularDescuento = 0;
                horasTrabajadas = 0;

                Console.WriteLine("Ingrese Hora: ");
                while (DateTime.TryParse(Console.ReadLine(), out hora) != true)
                {
                    Console.WriteLine("Error reingrese Hora: ");
                }


                Console.WriteLine("Ingrese el nombre: ");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese antiguedad: ");
                while (int.TryParse(Console.ReadLine(), out antiguedad) != true)
                {
                    Console.WriteLine("Error!! Ingrese antiguedad: ");
                }

                Console.WriteLine("Ingrese la cantidad de horas trabajadas: ");
                while (double.TryParse(Console.ReadLine(), out horasTrabajadas) != true)
                {
                    Console.WriteLine("Error!! Ingrese la cantidad de horas trabajadas: ");
                }

                totalBruto = horasTrabajadas * valorHora;
                antiguedad *= 150;
                totalBruto += antiguedad;
                calcularDescuento = totalBruto * 0.13;
                totalNeto = totalBruto - calcularDescuento;

                Console.WriteLine($"Hora:{hora.TimeOfDay} \tNombre del Trabajador: {nombre}\tAntiguedad:{antiguedad}\tHoras Trabajadas{horasTrabajadas}\tSalario Bruto $ {totalBruto}\tSalario Neto ${totalNeto}");
                Console.WriteLine("Presione ENTER si desea cargar otro empleado o ingrese Salir");
                opcion = Console.ReadLine().Trim().ToUpper();
            } while (opcion != "SALIR");
        }
    }
}
