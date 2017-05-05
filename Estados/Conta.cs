using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estados
{
    public class Conta
    {
        public EstadoConta EstadoAtual { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }

        public Conta(string nome, double saldo)
        {
            Nome = nome;
            Saldo = saldo;
            EstadoAtual = new Positivo();
        }

        public void Saca(double valor)
        {
            EstadoAtual.Saca(this, valor);
        }
        public void Deposita(double valor)
        {
            EstadoAtual.Deposita(this, valor);
        }

    }
}
