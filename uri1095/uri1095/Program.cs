using System;

namespace uri1095
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, j = 60;

            while (i <= 31 || j >= 0)
            {
                Console.Write("I=" + i + " ");
                Console.WriteLine("J=" + j);
                i += 3;
                j -= 5;

            }
            
        }
    }
}
