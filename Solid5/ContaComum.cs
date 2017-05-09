using System;

namespace Solid5
{
    public class ContaComum
    {
        public double Saldo { get; protected set; }

        public ContaComum()
        {
            Saldo = 0;
        }
        public virtual void Deposita(double valor)
        {
            Saldo += valor;
        }

        public void Saca(double valor)
        {
            if (valor <= Saldo)
                Saldo -= valor;
            else
                throw new ArgumentException();
        }

        public virtual void SomaInvestimento()
        {
            Saldo += Saldo * 0.1;
        }
    }
}