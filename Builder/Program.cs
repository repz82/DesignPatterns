using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var cItem1 = new ItemNotaBuilder();
            cItem1
                .ComNome("Item 1")
                .ComValor(100);

            var item1 = cItem1.Constroi();

            var cItem2 = new ItemNotaBuilder();
            cItem2
                .ComNome("Item 2")
                .ComValor(200);

            var item2 = cItem2.Constroi();

            var cItem3 = new ItemNotaBuilder();
            cItem3
                .ComNome("Item 3")
                .ComValor(300);

            var item3 = cItem3.Constroi();

            var criador = new NotaFiscalBuilder();
            criador
                .ParaEmpresa("Teste")
                .ComCnpj("123.456.789/0001-10")
                .ComItem(item1)
                .ComItem(item2)
                .ComItem(item3)
                .ComObservacoes("entregar nf pessoalmente")
                .NaDataAtual(DateTime.Now);

            criador.NovaAcao(new EnviarEmail());
            criador.NovaAcao(new EnviarSMS());
            criador.NovaAcao(new Imprimir());
            criador.NovaAcao(new NotaFiscalDAO());

            var nf = criador.Constroi();
            

            Console.WriteLine($"{nf.Cnpj}");
            Console.WriteLine($"{nf.ValorBruto}");
            Console.WriteLine($"{nf.Impostos}");
            Console.ReadKey();
        }
    }
}
