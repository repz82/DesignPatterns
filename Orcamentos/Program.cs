using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orcamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculador = new CalculadorDeDescontos();

            var orcamento = new Orcamento(250);
            orcamento.AdicionaItem(new Item("Produto 1", 100));
            orcamento.AdicionaItem(new Item("Produto 2", 50));
            orcamento.AdicionaItem(new Item("LAPIS", 50));
            orcamento.AdicionaItem(new Item("CANETA", 50));

            var desconto = calculador.Calcula(orcamento);

            Console.WriteLine(desconto);
            Console.ReadKey();
        }
        //static void Main(string[] args)
        //{
        //    var iss = new ISS();
        //    var icms = new ICMS();
        //    var iccc = new ICCC();
        //    var orcamento = new Orcamento(3001);
        //    var calculador = new CalculadorDeImposto();
        //    calculador.RealizaCalculo(orcamento, icms);
        //    calculador.RealizaCalculo(orcamento, iss);
        //    calculador.RealizaCalculo(orcamento, iccc);
        //    Console.ReadKey();
        //}
    }
}
