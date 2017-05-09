using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public class Desenvolvedor : Cargo
    {
        public Desenvolvedor(IRegraCalculo regra) : base(regra)
        {
            Regra = regra;
        }
    }
}
