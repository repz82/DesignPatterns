using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoBancaria
{
    public class RespostaPorcento : Resposta
    {
        public Resposta Proximo { get; set; }

        public RespostaPorcento(Resposta proximo)
        {
            Proximo = proximo;
        }

        public void Responde(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato == Formato.PORCENTO)
                Console.WriteLine($"{conta.Nome}%{conta.Saldo}");
            else
                Proximo.Responde(requisicao, conta);
        }
    }
}
