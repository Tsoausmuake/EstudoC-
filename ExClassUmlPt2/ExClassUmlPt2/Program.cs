using System;
using System.Globalization;

namespace ExClassUmlPt2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario a = new Funcionario();

            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            a.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            a.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Funcionário: {a}");

            Console.Write("Digite a portentagem para aumentar o salário: ");
            a.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine($"Dados Atualizados: {a}");





        }
    }
}
