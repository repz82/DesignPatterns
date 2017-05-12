using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var conexao = new ConnectionFactory().GetConnection();

            var comando = conexao.CreateCommand();
            comando.CommandText = "SELECT * FROM tabela";

        }
    }
}
