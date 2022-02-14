using System;

namespace ExMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int negativeNumber = 0;

            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];


            //Montando a Matriz tamanho N
            for (int i = 0; i < n; i++)
            {
                string[] value = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(value[j]);
                }

            }
            Console.WriteLine();
            // Diagonal Principal
            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{mat[i, i]} "); ;
            }
        
        Console.WriteLine();
            //Mostrando os números negativos
            for (int i = 0; i<n; i++)
            {
                for (int j = 0; j<n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        negativeNumber++;
                    }
}
            }
            Console.WriteLine($"Negative numbers = {negativeNumber}");

        }
    }
}
