using System;

namespace ExForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] vet = new string[n];
            for (int i = 0; i < n; i++)
            {
                vet[i] = Console.ReadLine();
            }
            foreach (string x in vet)
            {
                Console.WriteLine(x);
            }
        }
    }
}
