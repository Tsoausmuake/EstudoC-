using System;
using System.Globalization;

namespace uri1008
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que leia o número de um funcionário, 
             * seu número de horas trabalhadas, o valor que recebe por hora 
             * e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas decimais.*/


            int nDoFuncionario = int.Parse(Console.ReadLine());
            int horasTrabalhadas = int.Parse(Console.ReadLine());
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NUMBER = " + nDoFuncionario);
            Console.WriteLine("SALARY = U$ " + (horasTrabalhadas*valorHora).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
