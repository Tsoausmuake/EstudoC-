using System;
using System.Globalization;

namespace URI1040
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            double n1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double n2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double n3 = double.Parse(vet[2], CultureInfo.InvariantCulture);
            double n4 = double.Parse(vet[3], CultureInfo.InvariantCulture);

            double media = ((n1 * 2.0) + (n2 * 3.0) + (n3 * 4.0) + (n4 * 1.0)) / 10.0;

            if(media >= 7.0)
            {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno Aprovado.");
            }
            if (media < 5.0)
            {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno Reprovado.");
            }
            if (media >= 5.0 && media < 7.0)
            {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno em Exame.");
                double notaExame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do Exame: " + notaExame.ToString("F1", CultureInfo.InvariantCulture));
                double mediaFinal = (media + notaExame) / 2.0;
                if (mediaFinal >= 5.0 )
                {
                    Console.WriteLine("Aluno Aprovado.");
                    Console.WriteLine("Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
                }
                if (mediaFinal < 5.0)
                {
                    Console.WriteLine("Aluno Reprovado.");
                    Console.WriteLine("Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
