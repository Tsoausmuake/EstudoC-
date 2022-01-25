using System;
using System.Globalization;

namespace uri1051
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            string s = String.Format("At {0}, the temperature is {1}°C.", DateTime.Now, 20.4);
            A cada {0}, é uma variável que é utilizada, ou valor em si..
            se tiver, "bla bla {0}, bla bla bla {1}, hahaha {2}" Datetime.Now, 20.5, 1500); >> depois que fecha a string, 
            depois de cada virgulo, equivale a cada número dentro das chaves.
            
            {0} >> DateTime.Now
            {1} >> 20.5
            {2} >> 1500

             Console.WriteLine(s);
            // Output similar to: 'At 4/10/2015 9:29:41 AM, the temperature is 20.4°C.'
            */

            double imposto;
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario >= 0 && salario <= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            if (salario > 2000.00 && salario <= 3000.00)
            {
                imposto = (salario - 2000.00) * 0.08;
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            if (salario > 3000.00 && salario <= 4500.00)
            {
                imposto = ((3000.00 - 2000.01) * 0.08) + ((salario - 3000.00) * 0.18);
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            if (salario > 4500.00)
            {
                imposto = ((3000.00 - 2000.01) * 0.08) + ((4500.00 - 3000.01) * 0.18) + ((salario - 4500.00) * 0.28);
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
