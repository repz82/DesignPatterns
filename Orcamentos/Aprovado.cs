using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orcamentos
{
    public class Aprovado : EstadoOrcamento
    {
        private bool DescontoAplicado = false;
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (!DescontoAplicado)
            {
                orcamento.Valor -= orcamento.Valor * 0.02;
                DescontoAplicado = true;
            }
            else
                throw new Exception("Desconto já aplicado!");
        }
        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Não é possível aprovar o orçamento novamente.");
        }
        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Não é possível reprovar o orçamento já aprovado");
        }
        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}
