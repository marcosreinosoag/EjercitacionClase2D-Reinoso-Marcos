using System;
using BibliotecaDeClases;
//titular que contendrá la razón social del titular de la cuenta.
//cantidad que será un número decimal que representa al monto actual de dinero en la cuenta.

//retirar recibirá un monto para debitar de la cuenta. La cuenta puede quedar en negativo.
//En el método Main, simular depósitos y extracciones de dinero de la cuenta, e ir mostrando como va variando el saldo.

namespace OrientadoObj01
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta[] cuentas = new Cuenta[3];
            string opcion = " ";
            string dniIngresado;
            int indiceDeCuenta = 0;

            Cliente cliente01 = new Cliente("40304546", "Marcos", "Reinoso");
            Cliente cliente02 = new Cliente("20355541", "Pablo", "Perez");
            Cliente cliente03 = new Cliente("19255554", "Eduardooo", "Veni A Buscar A Juan Cruz");

            Cuenta cuenta01 = new Cuenta(cliente01, cliente01.Dni, 20200);
            Cuenta cuenta02 = new Cuenta(cliente02, cliente02.Dni, 100000);
            Cuenta cuenta03 = new Cuenta(cliente03, cliente03.Dni, 5000);

            cuentas[0] = cuenta01;
            cuentas[1] = cuenta02;
            cuentas[2] = cuenta03;

            Console.WriteLine("\t Bienvenido ");

            Console.WriteLine("Ingrese dni ");
            dniIngresado = Console.ReadLine();

            foreach (Cuenta cliente in cuentas)
            {
                if (cliente.RazonSocial == dniIngresado)
                {
                    break;
                }
                indiceDeCuenta++;
            }
            while (indiceDeCuenta != 3 && opcion != "0")
            {
                Console.WriteLine("Ingrese \n1)Ingresar dinero\n2)Retirar dinero\n3)Informacion sobre la cuenta\n0)Salir");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        int montoIngresado = 0;
                        Console.WriteLine("Ingrese el monto que desea ingresar");
                        int.TryParse(Console.ReadLine(), out montoIngresado);
                        cuentas[indiceDeCuenta].Ingresar(montoIngresado);
                        Console.WriteLine(cuentas[indiceDeCuenta].Mostrar()); 
                        break;
                    case "2":
                        Console.Clear();
                        int montoARetirar = 0;
                        Console.WriteLine("Ingrese el monto que desea retirar");
                        int.TryParse(Console.ReadLine(), out montoARetirar);
                        cuentas[indiceDeCuenta].Retirar(montoARetirar);
                        Console.WriteLine(cuentas[indiceDeCuenta].Mostrar());
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine(cuentas[indiceDeCuenta].Mostrar());
                        break;
                }
            }
        }
    }
}
