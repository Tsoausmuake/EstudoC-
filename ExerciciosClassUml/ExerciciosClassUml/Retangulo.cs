using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosClassUml
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double ValorDeArea()
        {
            return Largura* Altura;
        }
        public double ValorDoPerimetro()
        {
            return 2.0 * Largura + Altura * 2.0;
        }

        public double CalculoDeDiagonal()
        {
            return Math.Sqrt(Math.Pow(Largura, 2.0) + Math.Pow(Altura, 2.0));
        }
    }
}
