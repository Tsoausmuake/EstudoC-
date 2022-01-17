using System;

namespace uri1049
{
    class Program
    {
        static void Main(string[] args)
        {
            string p1 = Console.ReadLine();
            string p2 = Console.ReadLine();
            string p3 = Console.ReadLine();

            if (p1 == "vertebrado" && p2 == "ave" && p3 == "carnivoro")
            {
                Console.WriteLine("aguia");
            }
            if (p1 == "vertebrado" && p2 == "ave" && p3 == "onivoro")
            {
                Console.WriteLine("pomba");
            }
            if (p1 == "vertebrado" && p2 == "mamifero" && p3 == "onivoro")
            {
                Console.WriteLine("homem");
            }
            if (p1 == "vertebrado" && p2 == "mamifero" && p3 == "herbivoro")
            {
                Console.WriteLine("vaca");
            }
            if (p1 == "invertebrado" && p2 == "inseto" && p3 == "hematofago")
            {
                Console.WriteLine("pulga");
            }
            if (p1 == "invertebrado" && p2 == "inseto" && p3 == "herbivoro")
            {
                Console.WriteLine("lagarta");
            }
            if (p1 == "invertebrado" && p2 == "anelideo" && p3 == "hematofago")
            {
                Console.WriteLine("sanguessuga");
            }
            if (p1 == "invertebrado" && p2 == "anelideo" && p3 == "onivoro")
            {
                Console.WriteLine("minhoca");
            }
        }
    }
}
