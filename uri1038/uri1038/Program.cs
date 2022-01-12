using System;
using System.Globalization;
using System.Linq;


namespace uri1038
{
    class Program
    {
        static void Main(string[] args)
        {
            double valortotal = 0.0;
            Console.WriteLine("Bem Vindo ao Gordões Buguer!!");
            Console.WriteLine("Deseja comer Alguma coisa? ");
            string resposta = Console.ReadLine();
            int nProd = 0;
            int qnt = 0;

            if (resposta == "Sim" || resposta == "sim" || resposta == "s" || resposta == "Yes" || resposta == "yes" || resposta == "y")
            {

                while (resposta == "Sim" || resposta == "sim" || resposta == "s" || resposta == "Yes" || resposta == "yes" || resposta == "y")
                {
                    Console.WriteLine("De uma olhada no nosso cardápio e digite o código e a quantidade de que você deseja comprar: ");
                    Console.WriteLine("Cod. 1 | Cachorro quente | Preço R$ 4.00");
                    Console.WriteLine("Cod. 2 | X-Salada        | Preço R$ 4.50");
                    Console.WriteLine("Cod. 3 | X-Bacon         | Preço R$ 5.00");
                    Console.WriteLine("Cod. 4 | Torrada Simples | Preço R$ 2.00");
                    Console.WriteLine("Cod. 5 | Refrigerante    | Preço R$ 1.50");

                    string[] vet = Console.ReadLine().Split(' ');

                    while (ulong.Parse(vet[0]) > 5 && int.Parse(vet[0]) < 1)
                    {
                        Console.WriteLine("Você digitou o código errado!!");
                        Console.WriteLine("Digite Novamente o seu pedido: ");
                        vet = Console.ReadLine().Split(' ');
                    }

                    while (vet.Length < 2)
                    {
                        Console.WriteLine("Você digitou o código errado!!");
                        Console.WriteLine("Digite Novamente o seu pedido: ");
                        vet = Console.ReadLine().Split(' ');
                    }
                    nProd = int.Parse(vet[0]);
                    qnt = int.Parse(vet[1]);

                    if (nProd <= 5)
                        switch (nProd)
                        {
                            case 1:
                                valortotal += qnt * 4.0;
                                break;
                            case 2:
                                valortotal += qnt * 4.5;
                                break;
                            case 3:
                                valortotal += qnt * 5.0;
                                break;
                            case 4:
                                valortotal += qnt * 2.0;
                                break;
                            case 5:
                                valortotal += qnt * 1.5;
                                break;

                        }

                    Console.WriteLine("Deseja mais algo?");
                    resposta = Console.ReadLine();
                }
                Console.WriteLine("Total: R$ " + valortotal.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Muito Obrigado e Volte Sempre!!");
            }
            else
            {
                Console.WriteLine("Muito Obrigado e Volte Sempre!!");
            }



        }
    }
}
