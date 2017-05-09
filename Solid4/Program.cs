using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid4
{
    class Program
    {
        static void Main(string[] args)
        {
            var boletos = new List<Boleto>();
            boletos.Add(new Boleto(200));
            boletos.Add(new Boleto(300));
            boletos.Add(new Boleto(400));

            var fatura = new Fatura("Caelum", 900);

            var pdb = new ProcessadorDeBoletos();
            pdb.Processa(boletos, fatura);

            Console.WriteLine(fatura.Pago);
            Console.ReadKey();
        }
    }
}
