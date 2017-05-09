using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Multiplicador : AcaoNF
    {
        public double Fator { get; private set; }

        public Multiplicador(double fator)
        {
            Fator = fator;
        }
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine($"NF {nf.Cnpj} valor anterior {nf.ValorBruto} valor atual {nf.ValorBruto * Fator}.");
        }
    }
}
