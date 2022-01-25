using System;
using System.Globalization;

namespace URI1040
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, media, exame;

            string[] vet = Console.ReadLine().Split(' ');
            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);
            d = double.Parse(vet[3], CultureInfo.InvariantCulture);

            media = (a * 2.0 + b * 3.0 + c * 4.0 + d * 1.0) / 10.0;
            exame = 0.0;

            if (media >= 7.0)
            {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno aprovado.");
            }
            if (media < 7.0 && media >= 5.0)
            {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno em exame.");
                Console.Write("Nota do exame: ");
                exame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Aluno aprovado.");
                Console.WriteLine("Media final: " + ((exame + media) / 2.0).ToString("F1", CultureInfo.InvariantCulture));
            }
            if (media < 5.0)
            {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno reprovado.");
            }
        }
    }
}
