using System;

namespace Solid3
{
    public class TabelaDePrecoPadrao : ITabelaDePreco
    {
        public TabelaDePrecoPadrao()
        {
        }

        public double DescontoPara(double valor)
        {
            if (valor > 5000) return 0.03;
            else if (valor > 1000) return 0.05;
            return 0;
        }
    }
}