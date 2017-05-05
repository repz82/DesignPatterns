using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relatorios
{
    public class ContaBancaria
    {
        public string Titular { get; private set; }
        public string Agencia { get; private set; }
        public string Numero { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(string titular, string agencia, string numero, double saldo)
        {
            Titular = titular;
            Agencia = agencia;
            Numero = numero;
            Saldo = saldo;
        }
    }
}
