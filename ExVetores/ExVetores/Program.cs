using System;

namespace ExVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double soma = 0.0;
            double[] s = new double[n];

            string[] vet = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                s[i] = double.Parse(vet[i]);
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(s[i].ToString("#.0") + " ");
                soma += s[i];
            }
            Console.WriteLine();
            Console.WriteLine(soma.ToString("#.00"));
            Console.WriteLine((soma / n).ToString("#.00"));


        }
    }
}
