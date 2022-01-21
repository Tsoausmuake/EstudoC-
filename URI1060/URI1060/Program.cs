using System;
using System.Globalization;

namespace URI1060
{
    class Program
    {
        static void Main(string[] args)
        {
            int nPos = 0;
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            if (a > 0)
            {
                nPos++;
            }
            if (b > 0)
            {
                nPos++;
            }
            if (c > 0)
            {
                nPos++;
            }
            if (d > 0)
            {
                nPos++;
            }
            if (e > 0)
            {
                nPos++;
            }
            if (f > 0)
            {
                nPos++;
            }

            Console.WriteLine(nPos + " valores positivos");

        }
    }
}
