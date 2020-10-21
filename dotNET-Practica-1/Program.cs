using System;

namespace Práctica1
{
    class Program
    {
        static void Main(string[] args)
        {
            multiplo(66, 5);
            primo(11);

        }

        //Ejercicio 1
        public static void multiplo(int x, int m)
        {
            if (x % m == 0)
            {
                Console.WriteLine(x + " es múltiplo de " + m);
            }
            else
            {
                Console.WriteLine(x + " no es múltiplo de " + m);
            }
        }

        //Ejercicio 2
        public static void primo(int x)
        {
            bool esprimo = true;
            for (int contador = 2; contador < x; contador++)
            {
                if ((x % contador) == 0)
                {
                    Console.WriteLine(x + " no es numero primo ");
                    esprimo = false; 
                    break;
                }
            }
            if (esprimo)
            {
                Console.WriteLine(x + " es numero primo ");
            }
        }
    }
}
