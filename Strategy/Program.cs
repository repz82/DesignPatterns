using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var iss = new ISS();
            var icms = new ICMS();
            var iccc = new ICCC();
            var orcamento = new Orcamento(3001);
            var calculador = new CalculadorDeImposto();
            calculador.RealizaCalculo(orcamento, icms);
            calculador.RealizaCalculo(orcamento, iss);
            calculador.RealizaCalculo(orcamento, iccc);
            Console.ReadKey();
        }
    }
}
