using System;
using System.Globalization;

namespace uri1094
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double rato = 0.0, sapo = 0.0, coelho = 0.0;
            double perRato, perSapo, perCoelho;

            for (int i = 0; i < N; i++)|
            {
                string[] cobaias = Console.ReadLine().Split(' ');
                double qnt = double.Parse(cobaias[0]);
                char c = char.Parse(cobaias[1]);

                if (c == 'R')
                {
                    rato += qnt;
                }
                if (c == 'S')
                {
                    sapo += qnt;
                }
                if (c == 'C')
                {
                    coelho += qnt;
                }
            }
            perCoelho = (coelho * 100) / (sapo + rato + coelho);
            perRato = (rato * 100) / (sapo + rato + coelho);
            perSapo = (sapo * 100) / (sapo + rato + coelho);

            Console.WriteLine("Total: " + (rato + sapo + coelho) + " cobaias");
            Console.WriteLine("Total de coelhos: " + coelho);
            Console.WriteLine("Total de ratos: " + rato);
            Console.WriteLine("Total de sapos: " + sapo);
            Console.WriteLine("Percentual de coelhos: " + perCoelho.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de ratos: " + perRato.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de sapos: " + perSapo.ToString("F2", CultureInfo.InvariantCulture) + " %");


        }
    }
}
