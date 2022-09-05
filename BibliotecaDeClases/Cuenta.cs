using System;

namespace BibliotecaDeClases
{
    public class Cuenta
    {
        Cliente cliente;
        string razonSocial;
        decimal cantidad;
        public Cuenta(Cliente auxCliente, string razonSocial, decimal cantidad)
        {
            this.cliente = auxCliente;
            this.razonSocial = razonSocial;
            this.cantidad = cantidad;
        }
        public string RazonSocial { get { return this.razonSocial; } }
        public decimal Cantidad { get { return this.cantidad; } }
        public string Mostrar()
        {
            string datosUsuario;
            datosUsuario = $"El usuario {razonSocial} tiene en la cuenta: {cantidad}";
            return datosUsuario;
        }
        public void Ingresar(int ingresoDeDinero)
        {
            if (ingresoDeDinero > 0)
            {
                this.cantidad += ingresoDeDinero;
            }
            else
            {
                Console.WriteLine("Ingrese un monto mayor a 0");
            }
        }
        public void Retirar(int retiroDeDinero)
        {
            if (retiroDeDinero > 0)
            {
                this.cantidad -= retiroDeDinero;
            }
            else
            {
                Console.WriteLine("Ingrese un monto mayor a 0");
            }
        }
    }
}
