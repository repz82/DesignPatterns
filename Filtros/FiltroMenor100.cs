using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtros
{
    public class FiltroMenor100 : Filtro
    {
        public FiltroMenor100() : base()
        {
            OutroFiltro = null;
        }

        public FiltroMenor100(Filtro outroFiltro) : base(outroFiltro)
        {
            OutroFiltro = outroFiltro;
        }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            var c = contas.Where(p => p.Saldo < 100).ToList();
            if (OutroFiltro != null)
                c = FiltroOutroFiltro(c).ToList();

            return c;
        }

    }
}
