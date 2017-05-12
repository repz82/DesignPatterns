using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class ConnectionFactory
    {
        public IDbConnection GetConnection()
        {
            var conexao = new SqlConnection();
            conexao.ConnectionString = "User Id=sa;Password=;Server=localhost;Database=teste";
            conexao.Open();

            return conexao;
        }
    }
}
