using System.Globalization;

namespace ExContaBancaria
{
    class ContaBancaria
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria()
        {

        }
        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular)
        {
           Saldo = saldo;
            
        }

        public double Deposito(double valor)
        {
            return Saldo += valor;
        }
        public double Saque(double valor)
        {
            return Saldo -= (valor + 5.0);
        }

        public override string ToString()
        {
            return $"Conta {Numero}, Titular: {Titular}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
