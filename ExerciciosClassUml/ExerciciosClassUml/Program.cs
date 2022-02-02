using System;
using System.Globalization;
namespace ExerciciosClassUml
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo a = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retângulo: ");
            
            a.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"AREA = {a.ValorDeArea():F2}");
            Console.WriteLine($"PERÍMETRO = {a.ValorDoPerimetro():F2}");
            Console.WriteLine($"DIAGONAL = {a.CalculoDeDiagonal():F2}");

        }
    }
}
