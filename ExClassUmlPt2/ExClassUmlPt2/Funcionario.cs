using System;
using System.Collections.Generic;
using System.Text;

namespace ExClassUmlPt2
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public double AumentarSalario(double porcentagem)
        {
            
            return SalarioBruto = SalarioBruto + (SalarioBruto * (porcentagem / 100));
        }

        public override string ToString()
        {
            return $"{Nome}, $ {SalarioLiquido():F2}";
        }
    }
}
