using System;

namespace LacoForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            //Laço Foreach

            string[] vect = new string[] {"Maria", "João", "Bob"};

            foreach (string obj in vect)
            {
                Console.Write($"{obj}, ");
            }
        }
    }
}
