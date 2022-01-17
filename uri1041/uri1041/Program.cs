using System;
using System.Globalization;

namespace uri1041
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            double x = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double y = double.Parse(vet[1], CultureInfo.InvariantCulture);

            if(x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            if(x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
            if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }

        }
    }
}
