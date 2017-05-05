using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ItemNotaBuilder
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public ItemNotaBuilder ComNome(string nome)
        {
            Nome = nome;
            return this;
        }
        public ItemNotaBuilder ComValor(double valor)
        {
            Valor = valor;
            return this;
        }

        public ItemNota Constroi()
        {
            return new ItemNota(Nome, Valor);
        }
    }
}
