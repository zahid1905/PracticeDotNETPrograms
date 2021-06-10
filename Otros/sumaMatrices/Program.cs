using System;

namespace sumaMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz1 = new int[15,15];
            int[,] matriz2 = new int[15,15];
            int[,] matriz3 = new int[15,15];

            Random random = new Random();

            for (int x = 0; x < matriz1.GetLength(0); x++)//Este ciclo cambia la fila
            {
                for (int y = 0; y < matriz1.GetLength(1); y++)//Este ciclo inserta x datos a la fila
                {
                    matriz1[x,y] = random.Next(0, 9);
                    matriz2[x,y] = random.Next(0, 9);
                }
            }

            for (int x = 0; x < matriz3.GetLength(0); x++)//Este ciclo cambia la fila
            {
                for (int y = 0; y < matriz3.GetLength(1); y++)//Este ciclo inserta x datos a la fila
                {
                    matriz3[x,y] = matriz1[x,y] + matriz2[x,y];
                }
            }

            for (int x = 0; x < matriz1.GetLength(0); x++) //Imprime la primera matriz
            {
                for (int y = 0; y < matriz1.GetLength(1); y++)
                {
                    Console.Write(matriz1[x,y] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("+");

            for (int x = 0; x < matriz2.GetLength(0); x++) //Imprime la segunda matriz
            {
                for (int y = 0; y < matriz2.GetLength(1); y++)
                {
                    Console.Write(matriz2[x,y] + " ");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("=");

            for (int x = 0; x < matriz3.GetLength(0); x++) //Imprime la tercera matriz
            {
                for (int y = 0; y < matriz3.GetLength(1); y++)
                {
                    Console.Write(matriz3[x,y] + " ");                    
                }
                Console.WriteLine();
            }

            Console.WriteLine("");

            for (int x = 0; x < matriz3.GetLength(0); x++) //Imprime la tercera matriz
            {
                for (int y = 0; y < matriz3.GetLength(1); y++)
                {
                    Console.Write(matriz1[x,y] + "+");
                    Console.Write(matriz2[x,y] + "=");
                    Console.Write(matriz3[x,y] + " ");                    
                }
                Console.WriteLine();
            }
        }
    }
}
