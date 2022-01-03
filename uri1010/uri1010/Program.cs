using System;
using System.Globalization;

namespace uri1010
{
    class Program
    {
        static void Main(string[] args)
        {
            //Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o
            //valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o
            //valor unitário de cada peça 2. Após, calcule e mostre o valor a ser pago.

            string[] vet = Console.ReadLine().Split(' ');
            string[] vet1 = Console.ReadLine().Split(' ');

            int nPeca = int.Parse(vet[0]);
            int quantidadePecas = int.Parse(vet[1]);
            double valorPeca = double.Parse(vet[2], CultureInfo.InvariantCulture);

            int nPeca2 = int.Parse(vet1[0]);
            int quantidadePecas2 = int.Parse(vet1[1]);
            double valorPeca2 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            Console.WriteLine("VALOR A PAGAR: R$ " + ((quantidadePecas * valorPeca) + (quantidadePecas2 * valorPeca2)).ToString("F2", CultureInfo.InvariantCulture));




        }
    }
}
