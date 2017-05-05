using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estados
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta = new Conta("Teste", 200);
            Console.WriteLine(conta.Saldo);
            conta.Saca(300);
            Console.WriteLine(conta.Saldo);
            conta.Deposita(500);
            Console.WriteLine(conta.Saldo);
            conta.Deposita(100);
            Console.WriteLine(conta.Saldo);
            Console.ReadKey();
        }
    }
}
