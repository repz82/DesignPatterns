using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente();
            cliente.Nome = "Teste";
            cliente.Endereco = "Rua Teste, 1";
            cliente.DataNascimento = new DateTime(2017, 03, 30);

            var xml = new GeradorXML().GeraXML(cliente);

            Console.WriteLine(xml);
            Console.ReadLine();
        }
    }
}
