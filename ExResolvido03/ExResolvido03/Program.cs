using System;
using System.Globalization;
namespace ExResolvido03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] vet;
            double alt = 0.0;
            int cont = 0;
            string[] nome = new string[n];
            int[] idade = new int[n];
            double[] altura = new double[n];

            for (int i = 0; i < n; i++)
            {
                vet = Console.ReadLine().Split(' ');
                nome[i] = vet[0];
                idade[i] = int.Parse(vet[1]);
                altura[i] = double.Parse(vet[2], CultureInfo.InvariantCulture);
                alt += altura[i];

            }

            for (int i = 0; i < n; i++)
            {

                if(idade[i] < 16)
                {
                    cont++;
                }
            }
            double idade16 = (double) cont / n;

            Console.WriteLine("Altura média: " + (alt / n).ToString("#.00"));
            Console.WriteLine("Pessoas com Menos de 16 Anos: " + idade16.ToString("#.0%"));

        }
    }
}
