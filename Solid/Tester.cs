using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public class Tester : Cargo
    {
        public Tester(IRegraCalculo regra) : base(regra)
        {
            Regra = regra;
        }
    }
}
