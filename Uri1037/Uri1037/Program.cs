using System;
using System.Globalization;

namespace Uri1037
{
    class Program
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (N >= 0 && N <= 25.00)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            if (N > 25.00 && N <= 50.00)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            if (N > 50.00 && N <= 75.00)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            if (N > 75.00 && N <= 100.00)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            if (N < 0.00 || N > 100.00)
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}
