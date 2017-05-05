using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orcamentos
{
    public class Finalizado : EstadoOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamento finalizado não oferece desconto extra.");
        }
        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Não é possível aprovar o orçamento já finalizado.");
        }
        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Não é possível reprovar o orçamento já finalizado.");
        }
        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Não é possível finalizar o orçamento já finalizado.");
        }
    }
}
