using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orcamentos
{
    public abstract class TemplateImpostoCondicional : Imposto
    {
        public TemplateImpostoCondicional() : base()
        {
            OutroImposto = null;
        }

        public TemplateImpostoCondicional(Imposto outroImposto) : base(outroImposto)
        {
            OutroImposto = outroImposto;
        }

        public override double Calcula(Orcamento orcamento)
        {
            return (DeveUsarMaximaTaxacao(orcamento) ? MaximaTaxacao(orcamento) : MinimaTaxacao(orcamento)) + CalculoDoOutroImposto(orcamento);
        }

        public abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
        public abstract double MaximaTaxacao(Orcamento orcamento);
        public abstract double MinimaTaxacao(Orcamento orcamento);
    }
}
