using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiosDental.br.com.projeto.conexao
{
    public class ConnectionFactory
    {
        public SqlConnection getconnection()
        {
            string conexao = ConfigurationManager.ConnectionStrings["AXIOS_DENTAL_DEV"].ConnectionString;
            return new SqlConnection(conexao);
        }

    }
}
