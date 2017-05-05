using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orcamentos
{
    public class EmAprovacao : EstadoOrcamento
    {
        private bool DescontoAplicado = false;
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (!DescontoAplicado)
            {
                orcamento.Valor -= orcamento.Valor * 0.05;
                DescontoAplicado = true;
            }
            else
                throw new Exception("Desconto já aplicado!");
        }
        public void Aprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Aprovado();
        }
        public void Reprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Reprovado();
        }
        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Não é possível finalizar o orçamento antes da aprovação/reprovação.");
        }
    }
}
