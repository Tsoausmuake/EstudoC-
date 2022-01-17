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
            Console.WriteLine(s);
            // Output similar to: 'At 4/10/2015 9:29:41 AM, the temperature is 20.4°C.'
            */


            double a = Convert.ToDouble(Console.ReadLine());
            double b, c;

            if (a >= 0.00 && a <= 2000.00)
            {
                Console.WriteLine("Isento"); ;
            }
            if (a > 2000.00 && a <= 3000.00)
            {
                b = a - 2000;
                c = b * 0.08;
                Console.WriteLine("R$ " + string.Format("{0:0.00}", c));
            }
            if (a > 3000.00 && a <= 4500.00)
            {
                b = a - 3000;
                c = b * 0.18 + 1000 * 0.08;
                Console.WriteLine("R$ " + string.Format("{0:0.00}", c));
            }
            if (a > 4500.00)
            {
                b = a - 4500;
                c = b * 0.28 + 1500 * 0.18 + 1500 * 0.08;
                Console.WriteLine("R$ " + string.Format("{0:0.00}", c));
            }
        }
    }
}
