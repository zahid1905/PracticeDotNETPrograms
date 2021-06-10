using System;

namespace imprimirCosas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa n: ");
            int n = int.Parse(Console.ReadLine());

            int c;

            //Ejercicio 1
            for (c = 0; c < n; c++)
            {
                Console.Write("*");
            }
            Console.WriteLine("\n");

            int c2;

            //Ejercicio 2
            for(c = 0; c < n; c++)
            {
                for(c2 = 0; c2 <= c; c2++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Ejercicio 3
            for(c = 0; c < n; c++)
            {
                for(c2 = c; c2 < n; c2++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("");

            //Ejercicio 4
            for(c = 0; c < n; c++)
            {
                for(c2 = c; c2 < n; c2++)
                {
                    Console.Write(" ");
                }
                for(c2 = 0; c2 <= c; c2++)
                {
                    Console.Write("*");
                }
                for(c2 = 0; c2 < c; c2++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("");
        }
    }
}
