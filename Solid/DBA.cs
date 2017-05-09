using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public class DBA : Cargo
    {
        public DBA(IRegraCalculo regra) : base(regra)
        {
            Regra = regra;
        }
    }
}
