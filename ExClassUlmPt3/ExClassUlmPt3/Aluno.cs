using System;
using System.Collections.Generic;
using System.Text;

namespace ExClassUlmPt3
{
    class Aluno
    {
        public string Nome;
        public double PrimeiroTri;
        public double SegundoTri;
        public double TerceiroTri;

        public double NotaFinal()
        {
            return PrimeiroTri + SegundoTri + TerceiroTri;
        }

        public string TesteDeNota()
        {
            if (NotaFinal() < 60.00)
            {
                return "REPROVADO.\n" + 
                $"FALTARAM {60.00 - NotaFinal():F2} PONTOS";
            }
            else
            {
                return "APROVADO.";
            }
        }


        public override string ToString()
        {
            return $"Nota Final = {NotaFinal():F2} \n" +
               $"{TesteDeNota()}";
        }
    }

}
