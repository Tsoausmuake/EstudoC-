using System;

namespace URi1046
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            int horaInicial = int.Parse(vet[0]);
            int horaFinal = int.Parse(vet[1]);

            if (horaInicial == horaFinal)
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S)");
            }
            if (horaInicial > horaFinal)
            {

                Console.WriteLine("O JOGO DUROU " + (24 - horaInicial + horaFinal) + " HORA(S)");
            }
            if (horaInicial < horaFinal)
            {
                Console.WriteLine("O JOGO DUROU " + (horaFinal - horaInicial) + " HORA(S)");
            }
        }
    }
}
