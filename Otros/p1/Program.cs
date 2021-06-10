using System;

namespace p1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa tu nombre completo iniciando por apellidos: ");
            string nombre = Console.ReadLine();

            string [] nombres = nombre.Split(' ');
            Console.WriteLine("Tu apellido paterno es: " + nombres[0]);
            Console.WriteLine("Tu apellido materno es: " + nombres[1]);
            Console.WriteLine("Tu nombre es: " + nombres[2]);

            Console.WriteLine("Tu nombre tiene " + nombres[0].Length + " letras");
            Console.WriteLine(nombres[0].Substring(0,1));
        }
    }
}
