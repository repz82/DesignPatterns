﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orcamentos
{
    public interface Desconto
    {
        double Desconta(Orcamento orcamento);
        Desconto Proximo { get; set; }
    }
}
