using System;

namespace ContaBancaria
{
    public class Conta
    {
        public Conta()
        {
        }

        public string Titular { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public string Extrato { get; private set; }

        public void Depositar(double valorOperacao)
        {
            this.Saldo += valorOperacao;
            this.Extrato += "Debito: ( + ) " + valorOperacao.ToString("C") + Environment.NewLine;
        }

        public void Creditar(double valorOperacao)
        {
            this.Saldo -= valorOperacao;
            this.Extrato += "Credito: ( - ) " + valorOperacao.ToString("C") + Environment.NewLine;
        }
    }
}