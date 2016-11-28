using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investimentos
{
    public class Moderado : TipoInvestimento
    {
        private Random random;
        public Moderado()
        {
            this.random = new Random();
        }
        public double Calcula(ContaBancaria contaBancaria)
        {
            if (random.Next(2) == 0)
                return contaBancaria.Saldo * 0.025;
            else
                return contaBancaria.Saldo * 0.007;
        }
    }
}
