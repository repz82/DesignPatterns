using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investimentos
{
    public class Arrojado : TipoInvestimento
    {
        private Random random;
        public Arrojado()
        {
            this.random = new Random();
        }
        public double Calcula(ContaBancaria contaBancaria)
        {
            var probabilidade = random.Next(10);

            if (probabilidade >= 0 && probabilidade <= 1)
                return contaBancaria.Saldo * 0.5;
            else if (probabilidade >= 2 && probabilidade <= 4)
                return contaBancaria.Saldo * 0.3;
            else return
                    contaBancaria.Saldo * 0.006;
        }
    }
}
