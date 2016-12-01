using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orcamentos
{
    public class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            var d1 = new DescontoMaisCincoItens();
            var d2 = new DescontoMaisQuinhentosReais();
            var d3 = new DescontoVendaCasada();
            var d4 = new DescontoSemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;
            d3.Proximo = d4;

            return d1.Desconta(orcamento);
        }
    }
}
