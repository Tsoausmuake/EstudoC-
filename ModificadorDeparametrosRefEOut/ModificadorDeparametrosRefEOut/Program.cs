using System;

namespace ModificadorDeparametrosRefEOut
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Modificador de parâmetros ref
            int a = 10;

            Calculator.Triple(ref a);
            Console.WriteLine(a);
            */

            // Modificador de parâmetros out
            int a = 10;
            int triple;
            Calculator.Triple(a, out triple);
            Console.WriteLine(triple);






            
        }
    }
}
