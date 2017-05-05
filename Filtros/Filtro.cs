using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtros
{
    public abstract class Filtro
    {
        public Filtro OutroFiltro { get; set; }
        public Filtro(Filtro outroFiltro)
        {
            OutroFiltro = outroFiltro;
        }

        public Filtro()
        {
            OutroFiltro = null;
        }

        public abstract IList<Conta> Filtra(IList<Conta> contas);

        protected IList<Conta> FiltroOutroFiltro(IList<Conta> contas)
        {
            return OutroFiltro == null ? contas : OutroFiltro.Filtra(contas);
        }
    }
}
