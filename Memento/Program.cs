using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            var historico = new Historico();
            var contrato = new Contrato(DateTime.Now, "Teste", TipoContrato.Novo);
            historico.Adiciona(contrato.SalvaEstado());
            Console.WriteLine(contrato.Tipo);
            contrato.Avanca();
            historico.Adiciona(contrato.SalvaEstado());
            Console.WriteLine(contrato.Tipo);
            contrato.Avanca();
            historico.Adiciona(contrato.SalvaEstado());
            Console.WriteLine(contrato.Tipo);

            Console.WriteLine(historico.Pega(0).Contrato.Tipo);

            Console.ReadKey();
        }
    }
}
