using System;
using System.Globalization;

namespace MembrosEstáticos
{
    class Program
    {
        static double pi = 3.14;
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);
            Console.WriteLine("circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));

            double volume = Volume(raio);
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Valor de Pi: " + pi.ToString("F2", CultureInfo.InvariantCulture));
        }
        static double Circunferencia(double r)
        {
            return 2.0 * pi * r;
        }
        static double Volume(double r)
        {
            return pi * 4.0 / 3.0 * Math.Pow(r, 3.0);
        }
    }
}
