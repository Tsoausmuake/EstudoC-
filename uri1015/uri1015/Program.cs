using System;
using System.Globalization;

namespace uri1015
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            string[] vet1 = Console.ReadLine().Split(' ');

            double x1 = double.Parse(vet[0]);
            double y1 = double.Parse(vet[1]);

            double x2 = double.Parse(vet1[0]);
            double y2 = double.Parse(vet1[1]);

            double distancia = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}
