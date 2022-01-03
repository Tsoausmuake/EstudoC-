using System;
using System.Globalization;

namespace uri1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double totalDeVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double comissao = totalDeVendas * 0.15;

            Console.WriteLine("TOTAL = R$ " + (comissao + salario).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
