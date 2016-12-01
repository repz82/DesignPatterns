using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoBancaria
{
    public class RespostaCSV : Resposta
    {
        public Resposta Proximo { get; set; }

        public RespostaCSV(Resposta proximo)
        {
            Proximo = proximo;
        }

        public void Responde(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato == Formato.CSV)
                Console.WriteLine($"{conta.Nome};{conta.Saldo}");
            else
                Proximo.Responde(requisicao, conta);
        }
    }
}
