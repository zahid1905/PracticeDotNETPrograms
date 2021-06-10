using System;

namespace ejercicioMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3,4];

            Random random = new Random();

            for (int x = 0; x < matriz.GetLength(0); x++)//Este ciclo cambia la fila
            {
                for (int y = 0; y < matriz.GetLength(1); y++)//Este ciclo inserta x datos a la fila
                {
                    matriz[x,y] = random.Next(0, 9);
                }
            }

            Console.WriteLine(matriz.GetLength(0));//<--Se refiere a las filas
            Console.WriteLine(matriz.GetLength(1));//<--Se refiere a las columnas
            Console.WriteLine("\n");
            
            for (int x = 0; x < matriz.GetLength(0); x++)
            {
                for (int y = 0; y < matriz.GetLength(1); y++)
                {
                    Console.Write(matriz[x,y] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            
            for (int y = 0; y < matriz.GetLength(1); y++)
            {
                Console.Write(matriz[2,y] + " ");
            }
            Console.WriteLine("\n");

            for (int y = 0; y < matriz.GetLength(1); y++)
            {
                Console.Write(matriz[0,y] + " ");
            }
            Console.WriteLine("\n");

            for (int y = 0; y < matriz.GetLength(1); y++)
            {
                Console.Write(matriz[1,y] + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
