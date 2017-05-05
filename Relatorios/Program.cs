using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relatorios
{
    class Program
    {
        static void Main(string[] args)
        {
            var banco = new Banco("Banco REPZ", "(47) 99999-9999", "Rua Teste, 123", "repz@banco.com");
            banco.AdicionaConta(new ContaBancaria("Fulano", "1234", "5555-5", 123000));
            banco.AdicionaConta(new ContaBancaria("Zezinho", "5462", "8452-X", 0));
            banco.AdicionaConta(new ContaBancaria("Ciclano", "1321", "0135-9", 999));
            banco.AdicionaConta(new ContaBancaria("Beltrano", "9846", "4668-7", 16540));

            var relatorioSimples = new RelatorioSimples();
            relatorioSimples.Imprimir(banco);

            var relatorioCompleto = new RelatorioCompleto();
            relatorioCompleto.Imprimir(banco);

            Console.ReadKey();
        }
    }
}
