using System;

namespace matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear matriz
            int[,] matriz = new int[10,10];

            Random random = new Random();

            Console.WriteLine(matriz.GetLength(0));//<--Se refiere a las filas
            Console.WriteLine(matriz.GetLength(1));//<--Se refiere a las columnas
            Console.WriteLine();
            
            //Llenar la matriz
            for (int x = 0; x < matriz.GetLength(0); x++)//Este ciclo cambia la fila
            {
                for (int y = 0; y < matriz.GetLength(1); y++)//Este ciclo inserta x datos a la fila
                {
                    matriz[x,y] = random.Next(0, 9);
                }
            }

            //Imprimir la matriz
            for (int x = 0; x < matriz.GetLength(0); x++)
            {
                for (int y = 0; y < matriz.GetLength(1); y++)
                {
                    Console.Write(matriz[x,y] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
