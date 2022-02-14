using System;
using System.Globalization;

namespace FuncaoTernaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor do salário: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto = salario > 5000.00 ? salario * 0.27 : salario * 0.15;
            
            Console.Write($"Valor do desconto do imposto de renda é de: {imposto:F2} R$");


        }
    }
}
