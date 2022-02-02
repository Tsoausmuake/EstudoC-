using System;

namespace ExercíciosClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa A, B;

            A = new Pessoa();
            B = new Pessoa();

            Console.WriteLine("Dados da Primeira Pessoa: ");
            Console.Write("Nome: ");
            A.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            A.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados da Segunda Pessoa: ");
            Console.Write("Nome: ");
            B.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            B.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine(A.Idade > B.Idade ? $"Pessoa mais velha: {A.Nome}" : $"Pessoa mais velha: {B.Nome}");


        }
    }
}
