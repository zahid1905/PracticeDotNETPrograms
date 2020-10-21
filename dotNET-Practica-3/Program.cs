using System;

namespace Practica2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Numero a evaluar: ");
            int.TryParse(Console.ReadLine(), out i);
            if (i != 0)
            {
                par(i);
            }
            else
            {
                Console.WriteLine("Valor invalido");
            }            

            Console.WriteLine("Cuantos numeros a evaluar: ");
            int.TryParse(Console.ReadLine(), out i);
            if (i != 0)
            {
                promedioImpares(i);
            }
            else
            {
                Console.WriteLine("Valor invalido");
            }
            
            Console.WriteLine("Cuantos numeros a evaluar: ");
            int.TryParse(Console.ReadLine(), out i);
            if (i != 0)
            {
                promedioImpares(i);
            }
            else
            {
                Console.WriteLine("Valor invalido");
            }
        }

        //Ejercicio 1
        public static void par(int x)
        {           
            if (x % 2 == 0)
            {
                Console.WriteLine("El numero " + x + " es par");
            }
            else
            {
                Console.WriteLine("El numero " + x + " es impar");
            }
        }

        //Ejercicio 2
        public static void promedioImpares(int x)
        {
            double suma = 0;
            int numero = 0;
            int divisor = 0;
            for (int c = 1; c <= x; c++)
            {
                Console.WriteLine("Ingresa un numero: ");
                numero = int.Parse(Console.ReadLine());
                if (numero % 2 != 0)
                {
                    suma += numero;
                    d|++;
                }
            }
            Console.WriteLine("El promedio es: " + suma / divisor);
        }

        //Ejercicio 3
        public static void promedioNegativos(int x)
        {
            double suma = 0;
            int numero = 0;
            int divisor = 0;
            for (int c = 1; c <= x; c++)
            {
                Console.WriteLine("Ingresa un numero: ");
                numero = int.Parse(Console.ReadLine());
                if (numero < 0)
                {
                    suma += numero;
                    divisor++;
                }
            }
            Console.WriteLine("El promedio es: " + suma / divisor);
        }     
    }
}
