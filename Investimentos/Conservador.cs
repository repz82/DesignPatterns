using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investimentos
{
    public class Conservador : TipoInvestimento
    {
        public double Calcula(ContaBancaria contaBancaria)
        {
            return contaBancaria.Saldo * 0.08;
        }
    }
}
