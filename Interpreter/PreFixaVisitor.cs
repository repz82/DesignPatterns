﻿using Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class PreFixaVisitor : IVisitor
    {
        public void ImprimeSoma(Soma soma)
        {
            Console.Write("+");
            Console.Write(" ");
            soma.Esquerda.Aceita(this);
            Console.Write(" ");
            soma.Direita.Aceita(this);
        }

        public void ImprimeSubtracao(Subtracao subtracao)
        {
            Console.Write("-");
            subtracao.Esquerda.Aceita(this);
            Console.Write(" ");
            subtracao.Direita.Aceita(this);
            Console.Write(" ");
        }

        public void ImprimeNumero(Numero numero)
        {
            Console.Write(numero.Valor);
        }
    }
}
