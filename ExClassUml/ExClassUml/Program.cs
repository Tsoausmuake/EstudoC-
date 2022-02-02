using System;
using System.Globalization;

namespace ExClassUml
{
    class Program
    {
        static void Main(string[] args)
        {
            int qte = 0;

            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
                        
            p.AdicionarProdutos(qte = int.Parse(Console.ReadLine()));

            Console.WriteLine($"Dados Atualizados: {p}");

            Console.Write("Digite o número de produtos a ser removidos do estoque: ");
            p.RemoverProdutos(qte = int.Parse(Console.ReadLine()));
            Console.WriteLine($"Dados Atualizados: {p}");

        }
    }
}
