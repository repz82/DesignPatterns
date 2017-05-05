using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orcamentos
{
    public class IHIT : TemplateImpostoCondicional
    {
        public IHIT(Imposto outroImposto) : base(outroImposto)
        {
            OutroImposto = outroImposto;
        }
        public IHIT() : base()
        {

        }
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            foreach (var item in orcamento.Itens)
            {
                if (orcamento.Itens.Count(p => p.Nome == item.Nome) > 1)
                    return true;
            }
            return false;
        }
        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.13) + 100;
        }
        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * (orcamento.Itens.Count * 0.01);
        }

        private bool TemItemMaiorQue100ReaisNo(Orcamento orcamento)
        {
            foreach (var item in orcamento.Itens)
            {
                if (item.Valor > 100)
                    return true;
            }

            return false;
        }
    }
}
