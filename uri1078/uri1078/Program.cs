using System;

namespace uri1078
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i <=10 ? i + " x " + n + " = " + i * n : "Fim!");
            }
        }
    }
}
