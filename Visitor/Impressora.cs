using Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class Impressora
    {
        public void ImprimeSoma(Soma soma)
        {
            Console.Write("(");
            Console.Write("(");
            Console.Write("+");
            //Console.Write("(");
            Console.Write(")");
        }

        public void ImprimeSubtracao(Subtracao subtracao)
        {
            Console.Write("(");
            //Console.Write("(");
            Console.Write("-");
            //Console.Write("(");
            Console.Write(")");
        }

        public void ImprimeNumero(Numero numero)
        {
            //Console.Write(numero.);
        }
    }
}
