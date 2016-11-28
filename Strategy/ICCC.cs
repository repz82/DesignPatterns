using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ICCC : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            double valor;
            if (orcamento.valor < 1000)
                valor = orcamento.valor * 0.05;
            else if (orcamento.valor >= 1000 && orcamento.valor <= 3000)
                valor = orcamento.valor * 0.07;
            else
                valor = (orcamento.valor * 0.08) + 30;

            return valor;
        }
    }
}
