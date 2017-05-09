using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid5
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<ContaComum> contas = ContasDoBanco();

            foreach (var conta in contas)
            {
                conta.SomaInvestimento();
                Console.WriteLine($"O novo saldo é {conta.Saldo}");
            }
            Console.ReadKey();
        }

        private static IList<ContaComum> ContasDoBanco()
        {
            var contas = new List<ContaComum>();
            contas.Add(umaContaComum(100));
            contas.Add(umaContaComum(150));
            contas.Add(umaContaEstudante(100));
            return contas;
        }

        private static ContaEstudante umaContaEstudante(double saldo)
        {
            var conta = new ContaEstudante();
            conta.Deposita(saldo);
            return conta;
        }

        private static ContaComum umaContaComum(double saldo)
        {
            var conta = new ContaComum();
            conta.Deposita(saldo);
            return conta;
        }
    }
}
