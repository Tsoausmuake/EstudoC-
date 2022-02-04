using System;
using System.Globalization;

namespace ExCotaçãoDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dolar? ");
            ConversorDeMoedas.CotaçãoDoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dolares você vai comprar? ");
            ConversorDeMoedas.QuantidadeDeDolaresComprados = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Valor a ser pago em reais: ");
            Console.WriteLine(ConversorDeMoedas.ConversaoDoDolar().ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
