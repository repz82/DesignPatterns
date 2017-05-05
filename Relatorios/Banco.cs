using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relatorios
{
    public class Banco
    {
        public string Nome { get; private set; }
        public string Telefone { get; private set; }
        public string Endereco { get; private set; }
        public string Email { get; private set; }
        public IList<ContaBancaria> Contas { get; private set; }

        public Banco(string nome, string telefone, string endereco, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            Email = email;
            Contas = new List<ContaBancaria>();
        }

        public void AdicionaConta(ContaBancaria conta)
        {
            Contas.Add(conta);
        }
    }
}
