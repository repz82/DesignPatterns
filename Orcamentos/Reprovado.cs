using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orcamentos
{
    public class Reprovado : EstadoOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamento reprovado não oferece desconto extra.");
        }
        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Não é possível reprovar o orçamento já reprovado.");
        }
        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Não é possível reprovar o orçamento novamente.");
        }
        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}
