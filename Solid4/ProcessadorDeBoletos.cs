using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid4
{
    public class ProcessadorDeBoletos
    {
        public void Processa(IList<Boleto> boletos, Fatura fatura)
        {
            foreach (var boleto in boletos)
            {
                var pagamento = new Pagamento(boleto.Valor, MeioDePagamento.BOLETO);
                fatura.AdicionaPagamento(pagamento);
            }

        }
    }
}
