using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investimentos
{
    public class RealizadorDeInvestimento
    {
        public void RealizaCalculo(ContaBancaria contaBancaria, TipoInvestimento tipoInvestimento)
        {
            var valor = tipoInvestimento.Calcula(contaBancaria);
            contaBancaria.Deposita(valor * 0.75);
            Console.WriteLine(contaBancaria.Saldo);
        }
    }
}
