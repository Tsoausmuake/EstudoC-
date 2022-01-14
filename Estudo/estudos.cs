using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;


namespace uri1038
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {


                int a = 0;
                int b = 0;
                int c = 0;
                int d = 0;
                int e = 0;

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
                        Console.WriteLine();


                        Console.WriteLine("Código e Quantidade:");
                        string[] vet = Console.ReadLine().Split(' ');


                        /*
                        while (vet.Length < 2) throw new Exception("Você deve informar a opção e quantidade.");


                        if (int.Parse(vet[0]) == 0 || int.Parse(vet[0]) > 5) throw new Exception("Você deve informar um valor de 1 a 5!");


                        int opcao = int.Parse(vet[0]);
                        ulong quantidade = vet.Length == 2 ? ulong.Parse(vet[1]) : 1; // : operador ternário
                        //(condicao) ? [valor caso seja for verdadeiro] : [valor caso seja falso]

                        if (quantidade >= 1000) throw new Exception("Ta doidão??");

                        List<string> opcoes = new List<string>
                        {
                            "dogao",
                            "hamburguer"
                        };
                        */

                        while (int.Parse(vet[0]) == 0 || ulong.Parse(vet[0]) > 5)
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
                                    a += qnt;
                                    break;
                                case 2:
                                    valortotal += qnt * 4.5;
                                    b += qnt;
                                    break;
                                case 3:
                                    valortotal += qnt * 5.0;
                                    c += qnt;
                                    break;
                                case 4:
                                    valortotal += qnt * 2.0;
                                    d += qnt;
                                    break;
                                case 5:
                                    valortotal += qnt * 1.5;
                                    e += qnt;
                                    break;

                            }

                        Console.WriteLine("Deseja mais algo?");
                        resposta = Console.ReadLine();
                    }
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("PEDIDO");
                    Console.WriteLine();
                    Console.WriteLine("QUANTIDADE" + "\t" + "DESCRIÇÃO" + "\t" + "PREÇO UNITÁRIO" + "\t" + "TOTAL" + "\t");
                    if (a > 0)
                    {
                        Console.WriteLine(a + "\t\t" + "Cachorro quente"  + "\t" + "4,00 R$"  +"             "+ (a * 4.00).ToString("F2", CultureInfo.InvariantCulture) + " R$" + "\t");
                    }
                    if (b > 0)
                    {
                        Console.WriteLine("    " + b + "             X-Salada      " + "       4,50 R$           " + (b * 4.50).ToString("F2", CultureInfo.InvariantCulture) + " R$");
                    }
                    if (c > 0)
                    {
                        Console.WriteLine("    " + c + "             X-Bacon       " + "       5,00 R$           " + (c * 5.00).ToString("F2", CultureInfo.InvariantCulture) + " R$");
                    }
                    if (d > 0)
                    {
                        Console.WriteLine("    " + d + "          Torrada Simples  " + "       2,00 R$           " + (d * 2.00).ToString("F2", CultureInfo.InvariantCulture) + " R$");
                    }
                    if (e > 0)
                    {
                        Console.WriteLine("    " + e + "            Refrigerante     " + "     1,50 R$           " + (e * 1.50).ToString("F2", CultureInfo.InvariantCulture) + " R$");
                    }
                    Console.WriteLine("######################################################################################");
                    Console.WriteLine("Total: " + valortotal.ToString("F2", CultureInfo.InvariantCulture) + " R$");
                    Console.WriteLine("######################################################################################");
                    Console.WriteLine();
                    Console.WriteLine(DateTime.Now);
                    Console.WriteLine();
                    Console.WriteLine("Muito Obrigado e Volte Sempre!!");
                }
                else
                {
                    Console.WriteLine("Muito Obrigado e Volte Sempre!!");
                }
            }
            catch (Exception err)
            {
                Console.WriteLine("Message" + err.Message);
            }



        }
    }
}
