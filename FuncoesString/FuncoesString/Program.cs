using System;

namespace FuncoesString
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde ABCDE ABC abc DEFG     ";

            string s1 = original.ToUpper(); // converte tudo para maiusculo
            string s2 = original.ToLower(); // converte tudo para minúsculo
            string s3 = original.Trim(); // removo os espaços em branco, antes e depois da string;

            int n1 = original.IndexOf("bc"); // mostra a primeira incidência do "bc" na string.
            int n2 = original.LastIndexOf("bc"); // mostra a última incidência do bc na string 

            string s4 = original.Substring(3); //corta da posição 3 em diante.
            string s5 = original.Substring(3, 5); // corta da posição 3 em diante e apenas 5 caracteres.
            string s6 = original.Replace('a', 'x'); // substituir todo caracter 'a' pelo caracter 'x'

            bool b1 = string.IsNullOrEmpty(original); // Verificando se a variável original é nula ou vazia.
            bool b2 = string.IsNullOrWhiteSpace(original); // vericando se a variável é null ou espaços em branco.

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-"); //
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf 'bc': " + n1 + "-");
            Console.WriteLine("LastIndexOf 'bc': " + n2 + "-");
            Console.WriteLine("SubsTring: " + s4 + "-");
            Console.WriteLine("SubsTring: " + s5 + "-");
            Console.WriteLine("Replace: " + s6 + "-");
            Console.WriteLine("IsNullOrEmpty(original): " + b1);
            Console.WriteLine("IsNullOrWhiteSpace(original): " + b2);





        }
    }
}
