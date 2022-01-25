using System;

namespace uri1066
{
    class Program
    {
        static void Main(string[] args)
        {
            int valPar = 0, valImp = 0, valPos = 0, valNeg = 0;
           
            for (int i = 0; i < 5; i++)
            {
                int n = int.Parse(Console.ReadLine());

                if (n % 2 == 0)
                {
                    valPar++;
                }
                if(n % 2 != 0)
                {
                    valImp++;
                }
                if (n > 0)
                {
                    valPos++;
                }
                if (n < 0)
                {
                    valNeg++;
                }
            }
            Console.WriteLine(valPar + " valor(es) par(es)");
            Console.WriteLine(valImp + " valor(es) impar(es)");
            Console.WriteLine(valPos + " valor(es) positivo(s)");
            Console.WriteLine(valNeg + " valor(es) negativo(s)");
        }
    }
}
