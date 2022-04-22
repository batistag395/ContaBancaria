using System.Globalization;

namespace Banco
{
    internal class Conta
    {
        private string Titular { get; set; } = default!;
        public int ContaNum { get; private set; }
        public double Saldo { get; private set; }

        public static double TaxaSaque = 5.0;

        public Conta(string nome, int contaNum)
        {
            Titular = nome;
            ContaNum = contaNum;
        }
        public Conta(string nome, int contaNum, double saldo) : this(nome, contaNum)
        {
            Deposito(saldo);
        }
        public string Nome
        {
            get { return Titular; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    Titular = value;
                }
            }
        }
        public void Deposito(double depositar)
        {
            Saldo += depositar;
        }
        public void Saque(double saque)
        {
            Saldo -= saque + TaxaSaque;
        }
        public override string ToString()
        {
            return

                "Numero da conta:  "
                + ContaNum
                + ", Titular: "
                + Nome
                + ", Saldo: R$ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
