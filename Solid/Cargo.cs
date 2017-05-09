using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public abstract class Cargo
    {
        public IRegraCalculo Regra { get; set; }

        public Cargo(IRegraCalculo regra)
        {
            Regra = regra;
        }
    }
}
