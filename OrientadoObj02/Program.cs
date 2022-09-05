using System;
using BibliotecaOrientadoObj02;

namespace OrientadoObj02
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona01 = new Persona("Marcos",new DateTime(1997,12,2), "403222222");
            Console.WriteLine(persona01.Mostrar());
            Console.WriteLine(persona01.EsMayorDeEdad());
            
            Persona persona02 = new Persona("Pablo", new DateTime(2000,02,15), "401111111");
            Console.WriteLine(persona02.Mostrar());
            Console.WriteLine(persona02.EsMayorDeEdad());

            Persona persona03 = new Persona("Pedro", new DateTime(2010,02,15), "401112334");
            Console.WriteLine(persona03.Mostrar());
            Console.WriteLine(persona03.EsMayorDeEdad());
        }
    }
}
