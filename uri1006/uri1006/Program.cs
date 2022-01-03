using System;
using System.Globalization;

namespace uri1006
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mediaPOnderada = ((a * 2) + (b * 3) + (c * 5)) / 10;

            Console.WriteLine("MEDIA = " + mediaPOnderada.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
