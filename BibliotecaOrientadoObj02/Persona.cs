using System;
using System.Text;

namespace BibliotecaOrientadoObj02
{
    public class Persona
    {
        string nombre;
        DateTime fechaDeNacimiento;
        string dni;
        public Persona(string nombre, DateTime fechaDeNac, string dni)
        {
            this.Nombre = nombre;
            this.FechaDeNac = fechaDeNac.Date;
            this.Dni = dni;
        }
        public string Nombre
        {
            get{ return nombre; } 
            set{ this.nombre = value; }
        }
        public DateTime FechaDeNac
        {
            get { return fechaDeNacimiento; }
            set { this.fechaDeNacimiento = value; }
        }
        public string Dni
        {
            get{return dni;}
            set{this.dni = value;}
        }
        private int CalcularEdad()
        {
            DateTime fechaDeNacimiento = this.fechaDeNacimiento;
            DateTime fechaActual = DateTime.Now;
            int edad;
            edad = fechaActual.Year - fechaDeNacimiento.Year;

            return edad;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"\nNombre: {this.nombre} Dni {this.dni} Nacimiento:{this.fechaDeNacimiento.ToString("D")} Edad:{this.CalcularEdad()}");
            return sb.ToString();
        }
        public string EsMayorDeEdad()
        {
            if(this.CalcularEdad() > 17)
            {
                return "Es mayor de edad";
            }
            return "Es menor de edad";
        }





    }
}
