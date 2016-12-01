using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoBancaria
{
    public class Conta
    {
        public string Nome { get; set; }
        public double Saldo { get; set; }

        public Conta(string nome, double saldo)
        {
            Nome = nome;
            Saldo = saldo;
        }
    }
}
