using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relatorios
{
    public class RelatorioSimples : TemplateRelatorio
    {
        protected override void ImprimirCabecalho(Banco banco)
        {
            Console.WriteLine($"{banco.Nome}");
        }
        protected override void ImprimirContas(Banco banco)
        {
            Console.WriteLine($"Titular - Saldo");
            foreach (var item in banco.Contas)
            {
                Console.WriteLine($"{item.Titular} - R$ {item.Saldo}");
            }
        }
        protected override void ImprimirRodape(Banco banco)
        {
            Console.WriteLine($"{banco.Telefone}");
        }
    }
}
