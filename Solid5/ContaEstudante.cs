using System;

namespace Solid5
{
    public class ContaEstudante : ContaComum
    {
        public int Milhas { get; private set; }

        public override void Deposita(double valor)
        {
            base.Deposita(valor);
            Milhas += (int)valor;
        }
    }
}