using System;

namespace Banco2
{
    public class Conta
    {
        public int Numero { get; internal set; }
        public double Saldo { get; private set; }
        public string Titular { get; set; }

        public void Deposita(double valorOpereacao)
        {
            this.Saldo = Saldo + valorOpereacao;
        }

        internal void Saque(double valorOperacao_s)
        {
            this.Saldo = Saldo - valorOperacao_s;
        }
    }
}