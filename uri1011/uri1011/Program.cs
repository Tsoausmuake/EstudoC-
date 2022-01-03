using System;
using System.Globalization;
namespace uri1011
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que calcule e mostre o volume de uma
            //esfera sendo fornecido o valor de seu raio (R). A fórmula para
            //calcular o volume é: (4/3) * pi * R3. Considere (atribua) para pi o valor 3.14159.

            int r = int.Parse(Console.ReadLine());

            double pi = 3.14159;
            double calcVolume = (4.0 / 3) * pi * Math.Pow(r, 3);

            Console.WriteLine("VOLUME = " + calcVolume.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
