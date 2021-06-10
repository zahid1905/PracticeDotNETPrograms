using System;

namespace Práctica1
{
    class Program
    {
        static void Main(string[] args)
        {
            multiplo(130, 5);
        }

        //Ejercicio 1
        public static void multiplo(int x, int m) {
            if (x % m == 0) {
                Console.WriteLine(x + " es múltiplo de " + m);
            }
            else {
                Console.WriteLine(x + " no es múltiplo de " + m);
            }
        }
    }
}
