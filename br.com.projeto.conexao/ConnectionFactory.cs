using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiosDental.br.com.projeto.conexao
{
    public class ConnectionFactory
    {
        public MySqlConnection getconnection()
        {
            string conexao = ConfigurationManager.ConnectionStrings["axiostecnologi02"].ConnectionString;
            return new MySqlConnection(conexao);
        }

    }
}
