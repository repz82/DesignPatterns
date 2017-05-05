using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estados
{
    public class Negativo : EstadoConta
    {
        public void Deposita(Conta conta, double valor)
        {
            conta.Saldo += valor * 0.95;

            if (conta.Saldo > 0)
                conta.EstadoAtual = new Positivo();
        }

        public void Saca(Conta conta, double valor)
        {
            throw new Exception("Conta sem saldo para saque!");
        }
    }
}
