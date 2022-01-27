using System;
using System.Globalization;

namespace ExDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            char sn;
            double temp = 0.0;
            do
            {
                Console.Write("Digite a temperatura em celsius: ");
                temp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Equivalente em Fahrenheit: " + ((9 * temp)/5 + 32).ToString("#.0"));
                Console.Write("Deseja Repetir? ");
                sn = char.Parse(Console.ReadLine());
            }
            while (sn == 's');
        }
    }
}
