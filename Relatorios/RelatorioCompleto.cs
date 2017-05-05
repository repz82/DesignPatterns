using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relatorios
{
    public class RelatorioCompleto : TemplateRelatorio
    {
        protected override void ImprimirCabecalho(Banco banco)
        {
            Console.WriteLine($"{banco.Nome} - {banco.Endereco} - {banco.Telefone}");
        }
        protected override void ImprimirContas(Banco banco)
        {
            Console.WriteLine($"Titular - Agência - Conta - Saldo");
            foreach (var item in banco.Contas)
            {
                Console.WriteLine($"{item.Titular} - {item.Agencia} - {item.Numero} - R$ {item.Saldo}");
            }
        }
        protected override void ImprimirRodape(Banco banco)
        {
            Console.WriteLine($"{banco.Email} - {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}");
        }
    }
}
