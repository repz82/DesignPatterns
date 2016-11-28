using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investimentos
{
    public interface TipoInvestimento
    {
        double Calcula(ContaBancaria contaBancaria);
    }
}
