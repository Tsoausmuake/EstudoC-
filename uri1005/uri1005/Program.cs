using System;
using System.Globalization;

namespace uri1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double notaA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double notaB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mediaPonderada = ((notaA * 3.5) + (notaB * 7.5)) / 11;

            Console.WriteLine("MEDIA = " + mediaPonderada.ToString("F5", CultureInfo.InvariantCulture));

        }
    }
}
