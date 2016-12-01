using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoBancaria
{
    public class RespostaDaRequisicao
    {
        public void ResponderRequisicao(Requisicao requisicao, Conta conta)
        {
            var respostaXML = new RespostaXML();
            var respostaCSV = new RespostaCSV(respostaXML);
            var respostaPorcento = new RespostaPorcento(respostaCSV);

            respostaXML.Responde(requisicao, conta);
        }
    }
}
