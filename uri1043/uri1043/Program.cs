using System;
using System.Globalization;

namespace uri1043
{
    class Program
    {
        static void Main(string[] args)
        {

            
            double perimetro, area;
            string[] vet = Console.ReadLine().Split(' ');

            double A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double C = double.Parse(vet[2], CultureInfo.InvariantCulture);


            if ((A + B) > C)
            {
                if((A + C) > B)
                {
                    if((C + B) > A)
                    {
                        perimetro = A + B + C;

                        Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
                    }
                    else
                    {
                        area = ((A + B) * C) / 2;
                        Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
                    }
                }
                else
                {
                    area = ((A + B) * C) / 2;
                    Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
            else
            {
                area = ((A + B) * C) / 2;
                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
            }

        }
    }
}
