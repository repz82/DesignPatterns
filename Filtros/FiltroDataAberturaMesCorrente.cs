using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtros
{
    public class FiltroDataAberturaMesCorrente : Filtro
    {
        public FiltroDataAberturaMesCorrente() : base()
        {
            OutroFiltro = null;
        }

        public FiltroDataAberturaMesCorrente(Filtro outroFiltro) : base(outroFiltro)
        {
            OutroFiltro = outroFiltro;
        }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            var c = contas.Where(p => p.DataAbertura.Year == DateTime.Now.Year && p.DataAbertura.Month == DateTime.Now.Month).ToList();
            if (OutroFiltro != null)
                c = FiltroOutroFiltro(c).ToList();

            return c;
        }

    }
}
