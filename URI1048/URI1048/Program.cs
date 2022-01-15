using System;
using System.Globalization;

namespace URI1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine());

            if (salario >= 0.00 && salario <= 400.00)
            {
                Console.WriteLine("Novo salario: " + ((salario * 0.15) + salario).ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + (salario * 0.15).ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 15 %");
            }
            if (salario > 400.00 && salario <= 800.00)
            {
                Console.WriteLine("Novo salario: " + ((salario * 0.12) + salario).ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + (salario * 0.12).ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 12 %");
            }
            if (salario > 800.00 && salario <= 1200.00)
            {
                Console.WriteLine("Novo salario: " + ((salario * 0.10) + salario).ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + (salario * 0.10).ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 10 %");
            }
            if (salario > 1200.00 && salario <= 2000.00)
            {
                Console.WriteLine("Novo salario: " + ((salario * 0.07) + salario).ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + (salario * 0.07).ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 7 %");
            }
            if (salario > 2000.00)
            {
                Console.WriteLine("Novo salario: " + ((salario * 0.04) + salario).ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + (salario * 0.04).ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 4 %");
            }

        }
    }
}
