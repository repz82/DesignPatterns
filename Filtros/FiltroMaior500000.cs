using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtros
{
    public class FiltroMaior500000 : Filtro
    {
        public FiltroMaior500000() : base()
        {
            OutroFiltro = null;
        }

        public FiltroMaior500000(Filtro outroFiltro) : base(outroFiltro)
        {
            OutroFiltro = outroFiltro;
        }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            var c = contas.Where(p => p.Saldo > 500000).ToList();
            if (OutroFiltro != null)
                c = FiltroOutroFiltro(c).ToList();

            return c;
        }

    }
}
