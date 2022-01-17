using System;
using System.Globalization;
using System.Data;
namespace uri1047
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            int hi = int.Parse(vet[0]);
            int mi = int.Parse(vet[1]);
            int hf = int.Parse(vet[2]);
            int mf = int.Parse(vet[3]);

            int iniciom = hi * 60 + mi;
            int fimm = hf * 60 + mf;
            int duracao = fimm - iniciom;

            if (iniciom == fimm)
            {
                duracao = 24 * 60;
            }
            if (fimm > iniciom)
            {
                duracao = fimm - iniciom;
            }
            if (fimm < iniciom)
            {
                duracao = (24 * 60 - iniciom) + fimm;
            }

            int dh = duracao / 60;
            int dm = duracao % 60;
            Console.WriteLine("O JOGO DUROU " + dh + " HORA(S) E " + dm + " MINUTO(S)");
            Console.ReadLine();
        }
    }
}
