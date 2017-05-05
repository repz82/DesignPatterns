using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class NotaFiscal
    {
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public DateTime DataEmissao { get; private set; }
        public double ValorBruto { get; private set; }
        public double Impostos { get; private set; }
        public IList<ItemNota> Itens { get; private set; }
        public string Observacoes { get; private set; }

        public NotaFiscal(string razaoSocial, string cnpj, DateTime data, double valor, double impostos, IList<ItemNota> itens, string obs)
        {
            RazaoSocial = razaoSocial;
            Cnpj = cnpj;
            DataEmissao = data;
            ValorBruto = valor;
            Impostos = impostos;
            Itens = itens;
            Observacoes = obs;
        }
    }
}
