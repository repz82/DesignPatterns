using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid3
{
    public class CalculadoraDePrecos
    {
        private ITabelaDePreco tabela;
        private IServicoEntrega entrega;

        public CalculadoraDePrecos(ITabelaDePreco tabela, IServicoEntrega entrega)
        {
            this.tabela = tabela;
            this.entrega = entrega;
        }
        public double Calcula(Compra produto)
        {
            var tabela = new TabelaDePrecoPadrao();
            var correios = new Frete();

            var desconto = tabela.DescontoPara(produto.Valor);
            var frete = correios.Para(produto.Cidade);

            return produto.Valor * (1 - desconto) + frete;
        }
    }
}
