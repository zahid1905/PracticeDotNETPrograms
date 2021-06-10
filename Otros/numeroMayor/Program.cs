using System;

namespace numeroMayor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0, numero2 = 0, numero3 = 0, mayor = 0;

            Console.WriteLine("Dame el primer numero: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Dame el segundo numero: ");
            numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Dame el tercer numero: ");
            numero3 = int.Parse(Console.ReadLine());

            if (numero1 > numero2 && numero1 > numero3)
            {
                mayor = numero1;
            }
            else
            {
                if (numero2 > numero3)
                {
                    mayor = numero2;
                }
                else
                {
                    mayor = numero3;
                }
            }
            
            Console.WriteLine("El numero mayor es: " + mayor);
        }
    }
}
