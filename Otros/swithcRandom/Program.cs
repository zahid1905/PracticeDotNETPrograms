using System;

namespace swithcRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random rnd = new Random();
            
            //int caseSwitch = 2;
            //int caseSwitch = rnd.Next(1, 4);
            Console.WriteLine("Que deseas hacer: \n1-Suma\n2-Resta\n3-Multiplicacion\n4-Division\n5-Potencia");
            byte caseSwitch = byte.Parse(Console.ReadLine());

            double resultado = 0, numero1 = 0, numero2 = 0;

            if (caseSwitch != 5 && caseSwitch < 6)
            {
                Console.WriteLine("Ingresa el primer numero a operar: ");
                numero1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingresa el segundo numero a operar: ");
                numero2 = double.Parse(Console.ReadLine());
            }

            else
            {
                if (caseSwitch == 5)
                {
                    Console.WriteLine("Ingresa el numero a operar: ");
                    numero1 = double.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine($"Opcion invalida ({caseSwitch})");
                }
            }

            switch (caseSwitch)
            {
                case 1:
                    resultado = numero1 + numero2;
                    break;
                case 2:
                    resultado = numero1 - numero2;
                    break;
                case 3:                
                    resultado = numero1 * numero2;
                    break;
                case 4:
                    resultado = numero1 / numero2;
                    break;
                case 5:
                    resultado = numero1 * numero1;
                    break;
                default: 
                    Console.WriteLine($"Opcion invalida ({caseSwitch})");
                    break;
            }

            Console.WriteLine("El resultado es: " + resultado);
        }
    }
}
