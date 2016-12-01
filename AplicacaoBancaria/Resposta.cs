using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoBancaria
{
    public interface Resposta
    {
        Resposta Proximo { get; set; }
        void Responde(Requisicao requisicao, Conta conta);
    }
}
