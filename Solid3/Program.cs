using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid3
{
    class Program
    {
        static void Main(string[] args)
        {
            var compra = new Compra("Sao Paulo", 500);
            var calculadora = new CalculadoraDePrecos(new TabelaDePrecoPadrao(), new Frete());

            var resultado = calculadora.Calcula(compra);

            Console.WriteLine($"O preco da compra é {resultado}");
            Console.ReadKey();
        }
    }
}
