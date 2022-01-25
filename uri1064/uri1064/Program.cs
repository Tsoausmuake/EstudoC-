using System;
using System.Globalization;

namespace uri1064
{
    class Program
    {
        static void Main(string[] args)
        {
            int nPos = 0;
            int qnt = 0;
            double val = 0.0;

            for(int i = 0; i < 6; i++)
            {
                double n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (n > 0)
                {
                    nPos++;
                    qnt++;
                    val += n;
                }
            }
            Console.WriteLine(nPos + " valores positivos");
            Console.WriteLine(val / qnt);

        }
    }
}
