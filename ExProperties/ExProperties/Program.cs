using System;

namespace ExProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            p.Nome = "Manel";

            Console.WriteLine(p.Nome);
        }
    }
}
