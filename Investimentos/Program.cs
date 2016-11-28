using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investimentos
{
    class Program
    {
        static void Main(string[] args)
        {
            var conservador = new Conservador();
            var moderado = new Moderado();
            var arrojado = new Arrojado();
            var contaBancaria = new ContaBancaria();
            contaBancaria.Deposita(1000);
            var realizador = new RealizadorDeInvestimento();

            realizador.RealizaCalculo(contaBancaria, moderado);
            realizador.RealizaCalculo(contaBancaria, conservador);
            realizador.RealizaCalculo(contaBancaria, arrojado);

            Console.ReadKey();
        }
    }
}
