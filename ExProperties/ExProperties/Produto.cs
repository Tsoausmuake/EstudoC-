using System.Globalization;

namespace ExProperties
{
    class Produto
    {
        private string _nome;  //Atributos
        private double _preco; //Atributos
        private int _quantidade;//Atributos

        public Produto() // sobrecarga com construtor padrão
        {

        }
        public Produto(string nome, double preco, int quantidade) //Sobrecarga com um construtor de 3 parâmetros
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string Nome // properties
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }


        public Produto(string nome, double preco) //Sobrecarga com um construtor de 2 parâmetros
        {
            _nome = nome;
            _preco = preco;
            _quantidade = 0; // mas se não definir nenhum valor, o valor inicial por padrão, já é 0;

        }
        public double ValorTotalEmEstoque() //Métodos
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade) //Métodos
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) //Métodos
        {
            _quantidade -= quantidade;
        }
        public override string ToString() //Método ToString, para imprimir na tela só chamando o objeto da classe.
        {
            return Nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
