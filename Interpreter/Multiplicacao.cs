using System;
using Visitor;

namespace Interpreter
{
    public class Multiplicacao : IExpressao
    {
        private IExpressao esquerda;
        private IExpressao direita;

        public Multiplicacao(IExpressao esquerda, IExpressao direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }

        public int Avalia()
        {
            return esquerda.Avalia() * direita.Avalia();
        }
        public void Aceita(IVisitor impressora)
        {
            throw new Exception();
        }
    }
}