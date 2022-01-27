using System;
using System.Globalization;

namespace WhileIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double media = 0.0, soma = 0.0;
            int qnt = 0;

            while (idade >= 0)
            {
                soma += idade;
                qnt++;
                idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
            }
            media = soma / qnt;
            Console.WriteLine(qnt == 0 ? "Impossível Calcular": media.ToString("0.##"));
            
            
        }
    }
}
