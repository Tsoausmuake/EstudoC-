using System;

namespace MembrosEstáticosPt2
{
    class Calculadora
    {

       public static double pi = 3.14;

       public static double Circunferencia(double r)
        {
            return 2.0 * pi * r;
        }
       public static double Volume(double r)
        {
            return pi * 4.0 / 3.0 * Math.Pow(r, 3.0);
        }
    }
}
