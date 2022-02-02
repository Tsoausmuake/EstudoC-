using System;
using System.Globalization;

namespace MembrosEstáticosPt2
{
    class Program
    {
        static void Main(string[] args)

        {

            Calculadora calc = new Calculadora();


            Console.WriteLine("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            Console.WriteLine("circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));

            double volume = Calculadora.Volume(raio);
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Valor de Pi: " + Calculadora.pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
