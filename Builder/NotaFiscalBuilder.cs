﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public double ValorTotal { get; private set; }
        public double Impostos { get; private set; }
        public DateTime Data { get; private set; }
        public string Observacoes { get; private set; }

        private IList<AcaoNF> Acoes = new List<AcaoNF>();

        private IList<ItemNota> Itens = new List<ItemNota>();

        public NotaFiscalBuilder()
        {
            Data = DateTime.Now;
        }

        public void NovaAcao(AcaoNF acao)
        {
            Acoes.Add(acao);
        }

        public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
        {
            RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComItem(ItemNota item)
        {
            Itens.Add(item);
            ValorTotal += item.Valor;
            Impostos += item.Valor * 0.05;
            return this;
        }

        public NotaFiscalBuilder NaDataAtual(DateTime data)
        {
            Data = data;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(string obs)
        {
            Observacoes = obs;
            return this;
        }

        public NotaFiscalBuilder ComAcao(IList<AcaoNF> acoes)
        {
            Acoes = acoes;
            return this;
        }

        public NotaFiscal Constroi()
        {
            var nf = new NotaFiscal(RazaoSocial, Cnpj, Data, ValorTotal,
                                Impostos, Itens, Observacoes);

            foreach (var acao in Acoes)
            {
                acao.Executa(nf);
            }

            return nf;
        }
    }
}
