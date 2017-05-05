using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orcamentos
{
    public class ICCC : Imposto
    {
        public ICCC(Imposto outroImposto) : base(outroImposto)
        {
            OutroImposto = outroImposto;
        }
        public ICCC() : base()
        {

        }
        public override double Calcula(Orcamento orcamento)
        {
            double valor;
            if (orcamento.Valor < 1000)
                valor = orcamento.Valor * 0.05;
            else if (orcamento.Valor >= 1000 && orcamento.Valor <= 3000)
                valor = orcamento.Valor * 0.07;
            else
                valor = (orcamento.Valor * 0.08) + 30;

            return valor + CalculoDoOutroImposto(orcamento);
        }
    }
}
