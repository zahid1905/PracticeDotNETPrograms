using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, c2 = 0, z, c;
            float a = 0;

            Console.WriteLine("Ingresa la cantidad de numeros: ");
            x = Convert.ToInt32(Console.ReadLine());

            for (c = 1; c <= x; c++)
            {
                Console.WriteLine("Ingrese el numero " + c + "\n");
                z = Convert.ToInt32(Console.ReadLine());

                if (z % 2 != 0)
                {
                    a = a + z;

                    c2++;
                }
            }
            Console.WriteLine("Promedio: " + a / c2);
        }
    }
}
