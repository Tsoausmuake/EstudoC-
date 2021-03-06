using System;
using System.Globalization;

namespace ExContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaBancaria p;
            Console.Write("Entre com o número da conta: ");
            int NumeroConta = int.Parse(Console.ReadLine());

            Console.Write("Entre com o Titular da Conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá um depósito inicial (s/n)? ");
            char escolha = char.Parse(Console.ReadLine());


            if (escolha == 's' || escolha == 'S')
            {
                Console.Write("Entre com o valor do depósito inicial: ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                p = new ContaBancaria(NumeroConta, titular, deposito);
                p.Deposito(deposito);
            }
            else
            {
                p = new ContaBancaria(NumeroConta, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(p);

            Console.WriteLine();
            Console.Write("Entre com um valor para deposito: ");
            p.Deposito(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(p);

            Console.WriteLine();
            Console.Write("Entre com um valor para saque: ");
            p.Saque(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(p);




        }
    }
}
