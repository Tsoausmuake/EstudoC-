using System;

namespace ModificadoDeParametrosParams
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum(2, 4);
            int s2 = Calculator.Sum(new int[] {2, 4, 10, 55, 98756, 4654});


            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
