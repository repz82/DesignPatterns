using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orcamentos
{
    public class ICMS : Imposto
    {
        public ICMS(Imposto outroImposto) : base(outroImposto)
        {
            OutroImposto = outroImposto;
        }
        public ICMS() : base()
        {

        }
        public override double Calcula(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.05) + 50 + CalculoDoOutroImposto(orcamento);
        }
    }
}
