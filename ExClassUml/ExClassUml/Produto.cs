using System;
using System.Collections.Generic;
using System.Text;

namespace ExClassUml
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

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
            return $"{Nome}, $ {Preco:00}, {Quantidade} unidades, Total: $ {ValorTotalEmEstoque():F2}";
        }
    }
}
