using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            var resposta = new RespostaDaRequisicao();

            var requisicao = new Requisicao(Formato.XML);
            var conta = new Conta("Rodolfo", 10000);

            resposta.ResponderRequisicao(requisicao, conta);

            Console.ReadKey();
        }
    }
}
