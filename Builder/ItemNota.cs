using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ItemNota
    {
        public string Nome { get; set; }
        public double Valor { get; set; }

        public ItemNota(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }
    }
}
