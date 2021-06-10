using System;

namespace Ejemplo_3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Precio base por kilo: ");
            double precioBase = double.Parse(Console.ReadLine());

            Console.WriteLine("Tipo de uva: \na-Tipo A\nb-Tipo B");
            string tipo = Console.ReadLine();

            Console.WriteLine("Tamaño de uva: \n1-Tamano 1\n2-Tamano 2");
            byte tamano = byte.Parse(Console.ReadLine());

            double cargo = 0;

            if (tipo == "a")
            {
                if (tamano == 1)
                {
                    cargo = 0.20;
                }
                else
                {
                    cargo = 0.30;
                }
            }
            else
            {
                if (tamano == 1)
                {
                    cargo = -0.30;
                }
                else
                {
                    cargo = -0.50;
                }
            }

            double total = precioBase + cargo; 

            Console.WriteLine("Subtotal = " + precioBase + "\nCargo = " + cargo + "\nTotal = " + total);

        }
    }
}
