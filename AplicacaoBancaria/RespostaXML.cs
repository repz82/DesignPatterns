using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoBancaria
{
    public class RespostaXML : Resposta
    {
        public Resposta Proximo { get; set; }

        public RespostaXML()
        {
            Proximo = null;
        }

        public RespostaXML(Resposta proximo)
        {
            Proximo = proximo;
        }

        public void Responde(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato == Formato.XML)
                Console.WriteLine($"<conta><titular>{conta.Nome}</titular><saldo>{conta.Saldo}</saldo></conta>");
            else if (requisicao != null)
                Proximo.Responde(requisicao, conta);
            else
                throw new Exception("Próxima requisição não informada");
        }
    }
}
