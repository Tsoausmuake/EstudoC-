using System;
using System.Globalization;

namespace ExClassUlmPt3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            Console.Write("Nome do Aluno: ");
            a.Nome = Console.ReadLine();

            Console.WriteLine("Digite as 3 Notas do Aluno: ");
            a.PrimeiroTri = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.SegundoTri = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.TerceiroTri = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(a);
            
        }
    }
}
