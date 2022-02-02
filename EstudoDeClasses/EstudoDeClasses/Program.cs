using System;

namespace EstudoDeClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triângulo y: ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            Console.WriteLine($"Área de X = {x.Area():F4}");
            Console.WriteLine($"Área de Y = {y.Area():F4}");

            Console.WriteLine(y.Area() > x.Area() ? $"Maior Área: Y {y.Area():F4}" : $"Maior Área: X {x.Area():F4}");

            {

            }
        }
    }
}
