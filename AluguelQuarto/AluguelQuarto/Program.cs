using System;

namespace AluguelQuarto
{
    class Program
    {
        static void Main(string[] args)
        {
            Quarto[] vet = new Quarto[10];

            Console.Write("Quantos alunos irão alugar os quartos? ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Rent #{i}");

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write($"Room: ");
                int number = int.Parse(Console.ReadLine());
                
                vet[number] = new Quarto(name, email);
                Console.WriteLine();

            }

            for (int i = 0; i < 10; i++)
            {
                if (vet[i] != null)
                {
                    Console.WriteLine($"{i}: {vet[i]}");
                }
            }







        }
    }
}
