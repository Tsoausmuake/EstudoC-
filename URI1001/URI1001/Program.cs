using System;

namespace URI1001
{
    class Program
    {
        static void Main(string[] args)
        {
            // beecrowd | 1001
            /*
             * Leia 2 valores inteiros e armazene-os nas variáveis A e B. 
             * Efetue a soma de A e B atribuindo o seu resultado na variável X. 
             * Imprima X conforme exemplo apresentado abaixo. 
             * Não apresente mensagem alguma além daquilo que está sendo especificado 
             * e não esqueça de imprimir o fim de linha após o resultado, caso contrário, 
             * você receberá "Presentation Error".
             */

            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            int soma = A + B;

            Console.WriteLine("x = " + soma);

        }
    }
}
