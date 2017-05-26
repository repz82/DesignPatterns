﻿using Visitor;

namespace Interpreter
{
    public class Numero : IExpressao
    {
        public int Valor { get; private set;  }

        public Numero(int numero)
        {
            Valor = numero;
        }

        public int Avalia()
        {
            return Valor;
        }
        public void Aceita(IVisitor impressora)
        {
            impressora.ImprimeNumero(this);
        }
    }
}