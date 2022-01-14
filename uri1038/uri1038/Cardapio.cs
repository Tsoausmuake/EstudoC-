using System;
using System.Collections.Generic;
using System.Text;


namespace uri1038
{
    class Cardapio
    {
        string[] cardapio = new string[5] { "Cachorro Quente", "X-Salada", "X-Bacon", "Torrada Simples", "Refrigerante" };

        string cachorroQuente = "Cachorro quente";

        private String nome;
        private int id;
        private double valor;

        public Cardapio() { }

        public Cardapio(String nome, int id, double valor)
        {
            this.nome = nome;
            this.id = id;
            this.valor = valor;

        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public int getId()
        {
            return this.id;
        }
        public void setValor(double valor)
        {
            this.valor = valor;
        }
        public double getValor()
        {
            return this.valor;
        }

        public void testevet0()
        {

        }

    }
}
