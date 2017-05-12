using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var esquerda = new Soma(new Numero(1), new Numero(10));
            var direita = new Subtracao(new Numero(20), new Numero(10));
            var resultado = new Soma(esquerda, direita);

            Console.WriteLine(resultado.Avalia());
            Console.ReadKey();
        }
    }
}
