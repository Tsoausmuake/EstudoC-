using System;
using System.Globalization;

namespace uri1065
{
    class Program
    {
        static void Main(string[] args)
        {
            int nPos = 0;
            
            for (int i = 0; i < 5; i++)
            {
                double n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (n % 2 == 0)
                {
                    nPos++;
                }
            }

            Console.WriteLine(nPos + " valores pares");

        }
    }
}
