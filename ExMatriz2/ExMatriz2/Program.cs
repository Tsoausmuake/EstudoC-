using System;

namespace ExMatriz2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] collums = Console.ReadLine().Split(' ');
            int m = int.Parse(collums[0]);
            int n = int.Parse(collums[1]);

            int[,] mat = new int[m, n];


            // Criando a Matriz
            for (int i = 0; i < m; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(vet[j]);
                }
            }

            // Percorrendo a Matriz
            int positionNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (positionNumber == mat[i, j])
                    {
                        Console.WriteLine($"Position: {i},{j}:");
                        if (i < m && j - 1 < n && i >= 0 && j - 1 >= 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i < m && j + 1 < n && i >= 0 && j + 1 >= 0)
                        {
                            Console.WriteLine("Right:" + mat[i, j + 1]);
                        }
                        if (i - 1 < m && j < n && i - 1 >= 0 && j >= 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (i + 1 < m && j < n && i + 1 >= 0 && j >= 0)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }








                    }
                }
            }
        }
    }
}
