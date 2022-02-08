using System;
using System.Collections.Generic;


namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            List<string> list2 = new List<string> { "Maria", "bob", "Alex" };

            list2.Add("joana"); // Insere elemento a lista, não escolhendo o local para o elemento.
            list2.Add("marcos");
            list2.Add("Alexina");
            list2.Insert(2, "renata"); // insere um elemento a lista, designando a posição que o mesmo vai ficar.
            Console.WriteLine("------------------------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine();
            Console.WriteLine(list2.Count); // Conta quanto elementos há na lista
            Console.WriteLine("------------------------------");
            Console.WriteLine();

            string s1 = list2.Find(x => x[0] == 'A'); // eu quero o objeto x, tal que x na posição 0 seja igual a caracter 'A'
            Console.WriteLine("First 'A': " + s1);
            Console.WriteLine("------------------------------");
            Console.WriteLine();

            string s2 = list2.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);
            Console.WriteLine("------------------------------");
            Console.WriteLine();

            int pos1 = list2.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First Position 'A': " + pos1);
            Console.WriteLine("------------------------------");
            Console.WriteLine();

            int pos2 = list2.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("First Position 'A': " + pos2);
            Console.WriteLine("------------------------------");
            Console.WriteLine();

            List<string> obj1 = list2.FindAll(x => x.Length == 5);
            foreach (string x in obj1)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("------------------------------");

            list2.Remove("Alex"); // remove um elemento da lista
            foreach (string y in list2)
            {
                Console.WriteLine(y);
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine();

            list2.RemoveAll(x => x[0] == 'M');
            foreach (string j in list2)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine();

            list2.RemoveAt(2); //removeu a joana na posição 2 
            foreach (string kkk in list2)
            {
                Console.WriteLine(kkk);
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine();

            list2.RemoveRange(2, 2); // a partir da posição 2, remover 2 elementos.
            foreach (string s in list2)
            {
                Console.WriteLine(s);
            }
        }
    }
}
