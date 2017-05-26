using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridges
{
    class Program
    {
        static void Main(string[] args)
        {
            var mensagem = new MensagemCliente("Teste");
            var enviador = new EnviaSMS();
            mensagem.Enviador = enviador;
            mensagem.Envia();

            Console.ReadKey();
        }
    }
}
