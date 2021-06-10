using System;

namespace temperaturaEstaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa todos los datos separados por una coma");
            string datos = Console.ReadLine();
            string [] datosEstaciones = datos.Split(',');

            int [] datosEnteros = new int [20];

            int i = 2; //Las primeras dos posiciones no interesan, tienen
            int i1 = 0;
            int i2 = 0;

            while (i < 30)
            {
                while (i1 < 4)
                {
                    datosEnteros[i2] = int.Parse(datosEstaciones[i]);
                    i2++;
                    i1++;
                    i++;
                }
                i = i + 2;
                i1 = 0;
            }

            int [] temperatura = new int [5];

            i = 0;
            i1 = 0;

            while (i < 17)
            {
                temperatura[i1] = datosEnteros[i];
                i = i + 4;
                i1 ++;
            }

            i2 = 0;
            int mayor = 0;

            for (i = 0; i < 5; i++)
            {
                for (i1 = i + 1; i1 < 5; i1++)
                {
                    if (temperatura[i] < temperatura[i1])
                    {
                        i2 = temperatura[i1];
                        temperatura[i1] = temperatura[i];
                        temperatura[i] = i2;
                        mayor = i1;
                    }
                }
            }

            Console.Write("La temperatura mayor es " + temperatura[0] + " de la estacion " + mayor);
            
        }
    }
}
