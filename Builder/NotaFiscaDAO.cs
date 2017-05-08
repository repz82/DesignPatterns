using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class NotaFiscalDAO : AcaoNF
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine($"NF {nf.Cnpj} salva no Banco de Dados.");
        }
    }
}
