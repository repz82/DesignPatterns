using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var fila = new FilaTrabalho();
            var pedido1 = new Pedido("Teste 1", 100.0);
            var pedido2 = new Pedido("Teste 2", 500.0);
            fila.Adiciona(new PagaPedido(pedido1));
            fila.Adiciona(new PagaPedido(pedido2));
            fila.Adiciona(new FinalizaPedido(pedido1));
            fila.Processa();
            Console.ReadKey();
        }
    }
}
