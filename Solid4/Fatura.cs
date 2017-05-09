using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid4
{
    public class Fatura
    {
        public string Cliente { get; private set; }
        public double Valor { get; private set; }
        private IList<Pagamento> pagamentos;
        public bool Pago { get; private set; }

        public Fatura(string cliente, double valor, List<Pagamento> pagamentos, bool pago)
        {
            Cliente = cliente;
            Valor = valor;
            this.pagamentos = pagamentos;
            Pago = pago;
        }

        public Fatura(string cliente, double valor)
        {
            Cliente = cliente;
            Valor = valor;
        }

        public void AdicionaPagamento(Pagamento pagamento)
        {
            if (pagamentos == null)
                pagamentos = new List<Pagamento>();

            pagamentos.Add(pagamento);

            if (ValorTotalDosPagamentos() >= Valor)
                Pago = true;
        }

        private double ValorTotalDosPagamentos()
        {
            double total = 0;
            foreach (var pag in pagamentos)
            {
                total += pag.Valor;
            }
            return total;
        }
    }
}
