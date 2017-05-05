using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtros
{
    public class Conta
    {
        public string Nome { get; set; }
        public double Saldo { get; set; }
        public DateTime DataAbertura { get; set; }

        public Conta(string nome, double saldo, DateTime data)
        {
            Nome = nome;
            Saldo = saldo;
            DataAbertura = data;
        }
    }
}
