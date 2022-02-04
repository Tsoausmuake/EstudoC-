using System.Globalization;

namespace ConstrutoresSobrecarga
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto() // sobrecarga com construtor padrão
        {

        }
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco) //Sobrecarga
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 0; // mas se não definir nenhum valor, o valor inicial por padrão, já é 0;

        }
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
