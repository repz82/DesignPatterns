using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relatorios
{
    public abstract class TemplateRelatorio : Relatorio
    {
        public void Imprimir(Banco banco)
        {
            ImprimirCabecalho(banco);
            ImprimirContas(banco);
            ImprimirRodape(banco);
        }

        protected abstract void ImprimirCabecalho(Banco banco);
        protected abstract void ImprimirContas(Banco banco);
        protected abstract void ImprimirRodape(Banco banco);
    }
}
