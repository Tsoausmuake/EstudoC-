using System;
using System.Globalization;

namespace uri1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanciaTotal = int.Parse(Console.ReadLine());
            double combustivelGasto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double consumoTotal = distanciaTotal / combustivelGasto;

            Console.WriteLine(consumoTotal.ToString("F3", CultureInfo.InvariantCulture) + " km/l"); 
        }
    }
}
