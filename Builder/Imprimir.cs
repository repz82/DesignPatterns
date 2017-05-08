using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Imprimir : AcaoNF
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine($"NF {nf.Cnpj} impressa.");
        }
    }
}
